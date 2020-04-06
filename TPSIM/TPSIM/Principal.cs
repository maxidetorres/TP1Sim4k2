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
            return this.TruncateFunction(random);
        }

        private double congruencialMulti(int a, int sem, double m)
        {
            int siguiente = (a * sem) % (int)m;
            double random = siguiente / (m - 1); 
            this.semilla = siguiente;
            return this.TruncateFunction(random);
        }
        //truncar numero a 4 decimales
        public double TruncateFunction(double number)
        {
            return Math.Truncate(10000 * number) / 10000;
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

                //Generamos aleatorios
                double[] aleatorio = new double[n];
                Random rnd = new Random();
                double nro;
                for (int i = 0; i < n; i++)
                {
                    nro = TruncateFunction(rnd.NextDouble());
                    aleatorio[i] = nro;
                    System.Console.WriteLine(aleatorio[i]); //Mostramos en salida para corroborar

                }



            }
            else
            {
                //generar con el congruencial mixto - PUNTO C

            }
        }
        
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
    }
}
