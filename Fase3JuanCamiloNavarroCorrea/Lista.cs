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
            if(L_tipoDeI.Text == ""){
                Error1.SetError(L_tipoDeI,"Debe agregar su tipo de identidad primero");
                L_tipoDeI.Focus();
                return;
            }
            else
            {
                Error1.SetError(L_tipoDeI, "");
            }
            if (L_Nombre.Text == "")
            {
                Error1.SetError(L_Nombre, "Debe ingresar un nombre primero");
                L_Nombre.Focus();
                return;
            }
            else
            {
                Error1.SetError(L_Nombre, "");
            }
            if (L_Edad.Text == "")
            {
                Error1.SetError(L_Edad, "Debe ingresar la edad primero");
                L_Edad.Focus();
                return;
            }
            else
            {
                Error1.SetError(L_Edad, "");
            }

            if (L_estratoS.Text == "")
            {
                Error1.SetError(L_estratoS, "Debe ingresar el estrato socioeconomico");
                L_estratoS.Focus();
                return;
            }
            else
            {
                Error1.SetError(L_estratoS, "");
            }
            if(L_IdentificacionDelEs.Text == "")
            {
                Error1.SetError(L_IdentificacionDelEs, "Debe ingresar el numero de identificacion primero");
                L_IdentificacionDelEs.Focus();
                return;
            }
            else
            {
                Error1.SetError(L_IdentificacionDelEs, "");
            }

            //guardar los datos de los estudiantes.
            ListaEstudiante estudiante = new ListaEstudiante();
            estudiante.tipoDeIdentificacion = L_tipoDeI.Text;
            estudiante.numeroDeIdentificacion = L_IdentificacionDelEs.Text;
            estudiante.numeroDeIdentificacion = L_Nombre.Text;
            estudiante.edad = L_Edad.Text;
            estudiante.estratoSocioeconomico = L_estratoS.Text;
            if (radioButton1.Checked == true)
            {
                estudiante.votar = true;
            }

            if (radioButton2.Checked == true)
            {
                estudiante.votar = false;
            }
            estudiante.fecha = L_Fecha.Value;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarLista();
        }

    }
}
