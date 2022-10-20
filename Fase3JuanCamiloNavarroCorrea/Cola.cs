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
            //Filtros para que no se ingresen valores en blanco.
            if (C_Identificacion.Text == "")
            {
                errorProvider1.SetError(C_Identificacion, "Debe ingresar la identificacion");
                C_Identificacion.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(C_Identificacion, "");
            }
            if (C_NombreC.Text == "")
            {
                errorProvider1.SetError(C_NombreC, "Debe ingresar un nombre");
                C_NombreC.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(C_NombreC, "");
            }
            if (C_Direccion.Text == "")
            {
                errorProvider1.SetError(C_Direccion, "Debe ingresar una direccion.");
                C_Direccion.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(C_Direccion, "");
            }
            if (C_Comunas.Text == "")
            {
                errorProvider1.SetError(C_Comunas, "Debe elegir una comuna.");
                C_Comunas.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(C_Comunas, "");
            }
            if (C_Genero.Text == "")
            {
                errorProvider1.SetError(C_Genero, "Debe seleccionar su genero.");
                C_Genero.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(C_Genero, "");
            }
            ColaJuventud joven = new ColaJuventud();
            joven.Identificacion = C_Identificacion.Text;
            joven.NombreCompleto = C_NombreC.Text;
            joven.Direccion = C_Direccion.Text;
            joven.Comunas = C_Comunas.Text;
            joven.Genero = C_Genero.Text;
            joven.Fecha = FechaDeRegistro.Value;
            C_AuxilioE.Text = Convert.ToString(joven.auxilioEconomico());
            colaDeDatos.Enqueue(joven);
            DatosDeLaCola.DataSource = null;
            DatosDeLaCola.DataSource = colaDeDatos.ToList();
            
        }
        private void limpiarDatos()
        {
            C_Identificacion.Clear();
            C_NombreC.Clear();
            C_Direccion.Clear();
            C_Comunas.Text = "";
            C_Genero.Text = "";
            C_AuxilioE.Clear();
           
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colaDeDatos.Count != 0)
            {
                ColaJuventud joven = new ColaJuventud();   
                joven = colaDeDatos.Dequeue();
                DatosDeLaCola.DataSource = colaDeDatos.ToList();
                MessageBox.Show("Se elimino el elemento.");
            }
            else
            {
                MessageBox.Show("NO hay elementos para eliminar.");
            }
        }

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = colaDeDatos.Count.ToString();
            MessageBox.Show($"Total de registros ingresados: {mensaje}");
        }
    }
}
