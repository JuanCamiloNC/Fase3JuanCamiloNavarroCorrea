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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        Pila pila = new Pila();
        Cola cola = new Cola();
        private void button1_Click(object sender, EventArgs e)
        {
            pila.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cola.Show();
            this.Hide();
        }
    }
}
