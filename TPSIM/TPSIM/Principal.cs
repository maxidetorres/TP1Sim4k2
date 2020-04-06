using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPSIM
{
    public partial class Principal : Form
    {
        int semilla;
        int k;
        int g;
        int c;
        double m;
        int ultimoTabla;
        int n; //Nro muestras para el Chi
        int ki; //Nro intervalo seleccionado
        // double[] aleatorio; //Armamos vector para guardar nros aleatorios del lenguaje
        List<double> lista = new List<double>();
        double chi;


        public Principal()
        {
            InitializeComponent();
        }

        private void cmb_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilito o no la constante c y el boton generar
            if (cmb_metodo.SelectedIndex == 0)
                txt_c.Enabled = true;
            else
                txt_c.Enabled = false;
            btn_generar.Enabled = true;
            cmb_generacion.Enabled = false; //usar el punto a) bloquea el punto b) y c)
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            //genera los 20 numeros del punto a
            btn_siguienteNumero.Enabled = true; //el boton para seguir generando numeros de a uno

            semilla = int.Parse(txt_semilla.Text);
            k = int.Parse(txt_k.Text);
            g = int.Parse(txt_g.Text);
            m = Math.Pow(2, g);

            if (cmb_metodo.SelectedIndex == 0)
            {
                c = int.Parse(txt_c.Text);
                int a = 1 + 4 * k;
                for (int i = 0; i < 20; i++)
                {
                    double random = congruencialMixto(c, a, semilla, m);
                    dgvNumeros.Rows.Add(i + 1, random);
                    ultimoTabla = i + 2;
                }
            }
            else
            {
                int a = 3 + 8 * k;
                for (int i = 0; i < 20; i++)
                {
                    double random = congruencialMulti(a, semilla, m);
                    dgvNumeros.Rows.Add(i + 1, random);
                    ultimoTabla = i + 2;
                }
            }
        }

        private double congruencialMixto(int c, int a, int sem, double m)
        {
            int siguiente = (a * sem + c) % (int)m;
            double random = siguiente / (m - 1); //falta truncarlo a 4 decimales
            this.semilla = siguiente;
            return this.TruncateFunction(random, 4);
        }

        private double congruencialMulti(int a, int sem, double m)
        {
            int siguiente = (a * sem) % (int)m;
            double random = siguiente / (m - 1); 
            this.semilla = siguiente;
            return this.TruncateFunction(random, 4);
        }
        //truncar numero a 4 decimales
        public double TruncateFunction(double number, int digit)  
        {
            return Math.Truncate((Math.Pow(10.0, (double) digit) * number)) / (Math.Pow(10.0, (double)digit));
        }

        private void btn_siguienteNumero_Click(object sender, EventArgs e)
        {
            if (cmb_metodo.SelectedIndex == 0)
            {
                int a = 1 + 4 * k;
                double random = congruencialMixto(c, a, semilla, m);
                dgvNumeros.Rows.Add(ultimoTabla++, random);
            }
            else
            {
                int a = 3 + 8 * k;
                double random = congruencialMulti(a, semilla, m);
                dgvNumeros.Rows.Add(ultimoTabla++, random);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgvNumeros.Rows.Clear();
            txt_c.Clear();
            txt_g.Clear();
            txt_k.Clear();
            txt_semilla.Clear();
            txt_cant_generada.Clear();
            cmb_metodo.SelectedIndex = -1;
            cmb_metodo.Enabled = true;
            btn_generar.Enabled = false;
            btn_siguienteNumero.Enabled = false;
            cmb_generacion.SelectedIndex = -1;
            cmb_generacion.Enabled = true;
            txt_cant_generada.Enabled = false;
            grafico.Series.Clear();
            dataGridView1.Rows.Clear();
            lbl_chi.Text = "";
            lbl_gl.Text = "";
            lbl_resultado.Text = "";
            txt_valor.Clear();

        }

        private void cmb_generacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btn_pruebaChi.Enabled = true;
            txt_cant_generada.Enabled = true;
            cmb_metodo.Enabled = false;
        }

        //PUNTO B Y C
        private void btn_pruebaChi_Click(object sender, EventArgs e)
        {
            //validar un intervalo seleccionado u obligar uno por defecto?

            //Tomo cantidad de muestra n ingresada
            n = int.Parse(txt_cant_generada.Text);

            //Tomo intervalo seleccionado
            if (rbtn_5.Checked) { ki = 5; }
            else if (rbtn_10.Checked) { ki = 10; }
            else if (rbtn_15.Checked) { ki = 15; }
            else if (rbtn_20.Checked) { ki = 20; }

            //else if { }//Mostrar mensaje avisando que tiene que seleccionar uno

            if (cmb_generacion.SelectedIndex == 0)  //generar usando random del lenguaje - PUNTO B
            {

                //Generamos aleatorios y guardo en vector
                double[] aleatorios = new double[n]; // vector de aleatorios
                Random rnd = new Random();
                double nro; //nro random
                for (int i = 0; i < n; i++)
                {
                    nro = TruncateFunction(rnd.NextDouble(),4);
                    aleatorios[i] = nro;
                    System.Console.WriteLine(aleatorios[i]); //Mostramos en salida para corroborar

                }
                
                GenerarResultados(ki, aleatorios);

                //Generamos intervalos 
                
            }

            
        
            else
            {
                //generar con el congruencial mixto - PUNTO C

            }
        }



        private void GenerarResultados(int kintervalo, double[] aleatorio)
        {
            double superior;
            Intervalo[] intervalo; //vector de subintervalos
            intervalo = new Intervalo[kintervalo]; //creo los subintervalos del histograma
            for (int i = 0; i < kintervalo; i++)
            {
                if (i == 0)
                {
                    superior = this.TruncateFunction((double)(((float)1 / kintervalo)) * (i + 1),4);
                    intervalo[i] = new Intervalo(0, (float)superior);
                }
                else
                {
                    superior = this.TruncateFunction((double)(((float)1 / kintervalo)) * (i + 1),4);
                    intervalo[i] = new Intervalo(intervalo[i - 1].LimiteSuperior, (float)superior);
                }
            }

            //ahora recorremos la lista para calcular las frecuencias.
            for (int i = 0; i < aleatorio.Length; i++)
            {
                for (int j = 0; j < intervalo.Length; j++)
                {
                    if (aleatorio[i] >= intervalo[j].LimiteInferior && aleatorio[i] < intervalo[j].LimiteSuperior) //Pongo sólo MENOR y no <=
                    {
                        intervalo[j].CantidadObservaciones++;
                    }
                }
            }


            //limpiamos el chart y preparamos el nuevo histograma
            List<int> cantidades = new List<int>();//lista para acumular las cantidades de cada intervalo y luego poder obtener el MAX()
            grafico.Series.Clear();
            grafico.Series.Add("Frecuecias Observadas");

            for (int i = 0; i < kintervalo; i++)
            {
                cantidades.Add(intervalo[i].CantidadObservaciones);
                grafico.Series[0].Points.Add(intervalo[i].CantidadObservaciones);
                double limiteInferior = this.TruncateFunction(intervalo[i].LimiteInferior, 2);
                double limiteSuperior = this.TruncateFunction(intervalo[i].LimiteSuperior, 2);

                grafico.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                grafico.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                grafico.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
                grafico.Series[0].IsValueShownAsLabel = true;
                grafico.ChartAreas[0].AxisX.Interval = 1;
                grafico.Series[0].Points[i].AxisLabel = "[" + limiteInferior + " - " + limiteSuperior + "]";
               
                
            }
            double cantidadObservaciones = double.Parse(lista.Count.ToString());
            grafico.ChartAreas[0].AxisY.Maximum = cantidades.Max();
            
            //Calculamos y mostramos la frecuencia esperada
            
            lbl_gl.Text = (kintervalo - 1).ToString(); //mostrar
            grafico.Series["Frecuecias Observadas"].Color = Color.BlueViolet;

            //cargamos la tabla de frecuencias;
            for (int i = 0; i < intervalo.Length; i++)
            {
                string subint = intervalo[i].LimiteInferior + " - " + intervalo[i].LimiteSuperior;
                double freEsp = n / ki;
                dataGridView1.Rows.Add(subint, intervalo[i].CantidadObservaciones, freEsp, (Math.Pow((intervalo[i].CantidadObservaciones - freEsp), 2)) / freEsp);
            }
            double suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                suma += Convert.ToDouble(row.Cells[3].Value);
            }
            chi = suma;
            lbl_chi.Text = Convert.ToString(chi);//mostramos el chi2
            grafico.Visible = true;


        }




        //Metodo exportación a Excel
        /*
        private void ExportarExcel(double[] rnd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el Vector rellenando la hoja de trabajo
                
                for (int i = 0; i < rnd.Length; i++)
                {
                    
                   // for (int j = 0; j < rnd.Length; j++)
                    ////{
                        hoja_trabajo.Cells[i + 1, 1] = rnd[i]; //grd.Rows[i].Cells[j].Value.ToString();
                   // }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        */

        //Validar que el dato ingresado en los input sea solo numerico
        private void validate_only_number(object sender,KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permite un solo decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txt_semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validate_only_number(sender, e);
        }

        private void txt_k_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validate_only_number(sender, e);
        }

        private void txt_g_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validate_only_number(sender, e);
        }

        private void txt_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validate_only_number(sender, e);
        }

        private void txt_cant_generada_Validating(object sender, CancelEventArgs e)
        {
            if (txt_cant_generada.Text != "")
            {
                btn_pruebaChi.Enabled = true;
            }
            else {
                btn_pruebaChi.Enabled = false;
                e.Cancel = true;
            }
            
        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Grafico_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Lbl_chi_Click(object sender, EventArgs e)
        {

        }

        private void Btn_hipotesis_Click(object sender, EventArgs e)
        {
            if (chi <= double.Parse(txt_valor.Text))
           {
                lbl_resultado.Text = "Hipótesis Rechazada";
            }
            else
            {
                lbl_resultado.Text = "Hipótesis Aceptada";
            }
        }
    }
}
