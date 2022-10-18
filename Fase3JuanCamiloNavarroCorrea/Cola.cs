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
    public partial class Cola : Form
    {
        public Cola()
        {
            InitializeComponent();
        }
        Queue<ColaJuventud> colaDeDatos = new Queue<ColaJuventud>();
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColaJuventud joven = new ColaJuventud();
            joven.Identificacion = C_Identificacion.Text;
            joven.NombreCompleto = C_NombreC.Text;
            joven.Direccion = C_Direccion.Text;
            joven.Comunas = C_Comunas.Text;
            joven.Genero = C_Genero.Text;
            joven.Fecha = FechaDeRegistro.Value;
            colaDeDatos.Enqueue(joven);
            DatosDeLaCola.DataSource = null;
            DatosDeLaCola.DataSource = colaDeDatos.ToList();
            limpiarDatos();
        }
        private void limpiarDatos()
        {
            C_Identificacion.Clear();
            C_NombreC.Clear();
            C_Direccion.Clear();
            C_Comunas.Text = "";
            C_Genero.Text = "";
           
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colaDeDatos.Count != 0)
            {

            }
            else
            {
                MessageBox.Show("NO hay elementos para eliminar.");
            }
        }
    }
}
