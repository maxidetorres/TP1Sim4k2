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

        double x;//semilla proxima
        int ord;
        List<double> lista = new List<double>();

        public Principal()
        {
            InitializeComponent();
            lbl_tamuestra.Enabled = false;
            txt_tam_muestra.Enabled = false;

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            dataNumeros.Rows.Clear();

            var a = double.Parse(txt_multiplicativo.Text);
            var m = double.Parse(txt_divisor.Text);
            var x0 = double.Parse(txt_semilla.Text);

            //Congruencial Mixto : Xn = (A * Xn-1 + C ) Mod M
            if (rdb_Cong_Mixto.Checked)
            {
                var c = double.Parse(txt_sumatorio.Text);

                //Calculamos y mostramos:
                for (int i = 0; i < 20; i++)
                {
                    x = ((a * x0) + c) % m;
                    x0 = x;
                    double r = TruncateFunction((x / m), 4); //con m como denominador
                    //double r = TruncateFunction((x1 / (m1 - 1)), 4); //con m-1 como denominador
                    ord++;
                    dataNumeros.Rows.Add(ord, r);
                    lista.Add(r);
                }
            }

            if (rdb_Cong_Multiplicativo.Checked)
            {
                //Calculamos y mostramos:

                for (int i = 0; i < 20; i++)
                {
                    x = (a * x0) % m;
                    x0 = x;
                    double r = TruncateFunction((x / m), 4); //con m como denominador
                    //double r = TruncateFunction((x / (m - 1)), 4); //con m-1 como denominador
                    ord++;
                    dataNumeros.Rows.Add(ord, r);
                }
            }
            btn_generar.Enabled = false;
        }

        public double TruncateFunction(double number, int digits) 
        {
            double stepper = (double)(Math.Pow(10.0, (double)digits)); 
            int temp = (int)(stepper * number); 
            return (double)temp / stepper; 
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            //Congruencial Mixto
            if (rdb_Cong_Mixto.Checked)
            {
                ord++;
                double xsig = ((x * double.Parse(txt_multiplicativo.Text)) + double.Parse(txt_sumatorio.Text)) % double.Parse(txt_sumatorio.Text);
                double m1 = double.Parse(txt_divisor.Text);
                double res = TruncateFunction((xsig / m1), 4); //con m como denominador
                //double res = TruncateFunction(xsig / (m1 - 1), 4); //con m-1 como denominador
                dataNumeros.Rows.Add(ord, res);
                x = xsig;
                lista.Add(res);
            }

            //Congruencial Multiplicativo
            if (rdb_Cong_Multiplicativo.Checked)
            {
                ord++;
                double xsig = (x * double.Parse(txt_multiplicativo.Text)) % double.Parse(txt_divisor.Text);
                double m1 = double.Parse(txt_divisor.Text);
                double res = TruncateFunction((xsig / m1), 4); //con m como denominador
                //double res = TruncateFunction(xsig / (m1 - 1), 4); //con m-1 como denominador
                dataNumeros.Rows.Add(ord, res);
                x = xsig;

            }
        }
    }
}
