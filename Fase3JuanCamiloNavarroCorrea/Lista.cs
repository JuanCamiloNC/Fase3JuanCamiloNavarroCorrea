using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3JuanCamiloNavarroCorrea
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }
        List<ListaEstudiante> listStuden = new List<ListaEstudiante>();

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }
        public void limpiarLista()
        {
            L_estratoS.Text = "";
            L_IdentificacionDelEs.Text = "";
            L_Nombre.Clear();
            L_tipoDeI.Text = "";
            L_Edad.Clear();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEstudiante estudiante = new ListaEstudiante();
            
        }
    }
}
