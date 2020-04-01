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
        public Principal()
        {
            InitializeComponent();
        }

        private void cmb_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilito o no la constante c y el boton generar
            if (cmb_metodo.Text.Equals("Congruencial Mixto"))
                txt_c.Enabled = true;
            else
                txt_c.Enabled = false;
            btn_generar.Enabled = true;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            //genera los 20 numeros del punto a
            btn_siguienteNumero.Enabled = true; //el boton para seguir generando numeros de a uno, si sobra tiempo se puede agregar una tecla para hacer lo mismo

        }
    }
}
