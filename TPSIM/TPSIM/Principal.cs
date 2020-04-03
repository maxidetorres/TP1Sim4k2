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
            return random;
        }

        private double congruencialMulti(int a, int sem, double m)
        {
            int siguiente = (a * sem) % (int)m;
            double random = siguiente / (m - 1); //falta truncarlo a 4 decimales
            this.semilla = siguiente;
            return random;
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
            btn_pruebaChi.Enabled = true;
            txt_cant_generada.Enabled = true;
            cmb_metodo.Enabled = false;
        }

        private void btn_pruebaChi_Click(object sender, EventArgs e)
        {
            //validar un intervalo seleccionado u obligar uno por defecto?

            if (cmb_generacion.SelectedIndex == 0)
            {
                //generar usando random del lenguaje

            }
            else
            {
                //generar con el congruencial mixto

            }
        }
    }
}
