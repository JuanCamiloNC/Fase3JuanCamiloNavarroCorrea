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
    public partial class Pila : Form
    {
        public Pila()
        {
            InitializeComponent();
        }
        Stack<PilaCDT> usuariosDelCTD = new Stack<PilaCDT>();

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        //Funcion para agregar a la pila
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PilaCDT p = new PilaCDT();
            p.numeroDelCDT = Convert.ToDouble(P_NumeroDelCDT.Text);
            p.numeroDeIdentificacion = Convert.ToDouble(P_NumeroDeIdentificacion.Text);
            p.estrato = Convert.ToInt32(P_estrato.Text);
            p.categoria = P_Categoria.Text;
            p.ingresarUnValor = Convert.ToDouble(P_IngreseUnValor.Text);
            p.mesDeApertura = P_MesDeApertura.Text;
            p.nombre = P_Nombre.Text;
            p.direccion = P_Direccion.Text;
            p.tiempoDelCDT = P_TiempoDelCDT.Text;
            P_TotalApagar.Text = Convert.ToString(p.calcularElPago());
            p.totalAPagar = P_TotalApagar.Text;
            usuariosDelCTD.Push(p);
            DatosEnPantalla.DataSource = null;
            DatosEnPantalla.DataSource = usuariosDelCTD.ToArray();
            
        }


        //Funcion para eliminar de la pila
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PilaCDT p = new PilaCDT();
            if (usuariosDelCTD.Count != 0)
            {
                p = usuariosDelCTD.Pop();
                DatosEnPantalla.DataSource = usuariosDelCTD.ToArray();
                MessageBox.Show("Se elimino el elemento");
           
            }
            else
            {
                MessageBox.Show("NO hay elementos que borrar");

            }
        }

        private void limpiarElementos()
        {
            P_NumeroDelCDT.Clear();
            P_NumeroDeIdentificacion.Clear();
            P_estrato.Text = "";
            P_Categoria.Text = "";
            P_IngreseUnValor.Clear();
            P_MesDeApertura.Text = "";
            P_Nombre.Clear();
            P_Direccion.Clear();
            P_TiempoDelCDT.Clear();
            P_TotalApagar.Clear();
        }

        private void limpiarFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarElementos();
        }
    }
}
