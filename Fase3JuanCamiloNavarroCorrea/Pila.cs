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
            p.numeroDelCDT = Convert.ToInt32(P_NumeroDelCDT);
            p.numeroDeIdentificacion = Convert.ToDouble(P_NumeroDeIdentificacion.Text);
            p.estrato = Convert.ToInt32(P_estrato.Text);
            p.categoria = P_Categoria.Text;
            p.ingresarUnValor = Convert.ToDouble(P_IngreseUnValor.Text);
            p.mesDeApertura = P_MesDeApertura.Text;
            p.nombre = P_Nombre.Text;
            p.direccion = P_Direccion.Text;
            p.tiempoDelCDT = P_TiempoDelCDT.Text;
            usuariosDelCTD.Push(p);
            DatosEnPantalla.DataSource = null;
            DatosEnPantalla.DataSource = usuariosDelCTD.ToArray();
        }


        //Funcion para eliminar de la pila
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
