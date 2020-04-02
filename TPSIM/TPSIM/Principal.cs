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
    public partial class Principal : Form{

        double x;
        double m1;
        double aMix;
        double aMul;
        double c;

        int ord;
        List<double> lista = new List<double>();

        public Principal()
        {
            InitializeComponent();
            btn_siguienteNumero.Enabled = false;


        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            var listError = new List<string>();
            
            double x0 = 0;
            double k = 0;
            int g = 0;
            


            dgvNumeros.Rows.Clear();
            ord = 0;
            if (txt_semilla.Text.Length != 0)
            {
               x0 = double.Parse(txt_semilla.Text);
            }
            else
            {
               listError.Add("Debe ingresar valor en semilla.");

            }

            if (txt_k.Text.Length != 0)
            {
                k = double.Parse(txt_k.Text);
            }
            else
            {
               listError.Add("Debe ingresar valor en k");
            }

            if (txt_g.Text.Length != 0)
            {
                g = int.Parse(txt_g.Text);
            }
            else
            {
                listError.Add("Debe ingresar valor en g");
            }

            if (rdb_cong_mixto.Checked && txt_c.Text.Length ==0)
            {
                listError.Add("Debe ingresar valor en c.");
            }

            if (listError.Count !=0)
            {
                foreach (var mensaje in listError)
                {
                   MessageBox.Show(mensaje.ToString());
                }
                return;
            }
            
          
            var m = Math.Pow(2, g);
            m1 = double.Parse(m.ToString());
            

            if (rdb_cong_mixto.Checked)
            {

               c = double.Parse(txt_c.Text);
               aMix = 1 + 4 * k;

                for (int i = 0; i < 20; i++)
                {
                    x = ((aMix * x0) + c) % m;
                    x0 = x;
                    double r = TruncateFunction((x / (m1 - 1)), 4); 
                    ord++;
                    dgvNumeros.Rows.Add(ord, r);
                    lista.Add(r);
                }

            }


            if (rdb_cong_multiplicativo.Checked)
            {
                aMul = 3 + 8 * k;


                for (int i = 0; i < 20; i++)
                {
                    x = (aMul * x0) % m;
                    x0 = x;
                    double r = TruncateFunction((x / (m - 1)), 4);
                    ord++;
                    dgvNumeros.Rows.Add(ord, r);
                }


            }

            btn_siguienteNumero.Enabled = true;

        }


        public double TruncateFunction(double number, int digits)
        {
            double stepper = (double)(Math.Pow(10.0, (double)digits));
            int temp = (int)(stepper * number);
            return (double)temp / stepper;
        }

        private void btn_siguienteNumero_Click(object sender, EventArgs e)
        {
            //Congruencial Mixto
            if (rdb_cong_mixto.Checked)
            {
                ord++;
                double xsig = ((x * aMix) + c) % m1;
                double res = TruncateFunction(xsig / (m1 - 1), 4); 
                dgvNumeros.Rows.Add(ord, res);
                x = xsig;
                lista.Add(res);
            }

            //Congruencial Multiplicativo
            if (rdb_cong_multiplicativo.Checked)
            {
                ord++;
                double xsig = (x * aMul) % m1;
                double res = TruncateFunction(xsig / (m1 - 1), 4);
                dgvNumeros.Rows.Add(ord, res);
                x = xsig;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_semilla.Clear();
            txt_k.Clear();
            txt_g.Clear();
            txt_c.Clear();
            btn_siguienteNumero.Enabled = false;
            dgvNumeros.Rows.Clear();
        }
    }
}
