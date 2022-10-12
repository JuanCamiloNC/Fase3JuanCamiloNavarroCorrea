namespace Fase3JuanCamiloNavarroCorrea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Menu menu =new Menu();
        private void button1_Click(object sender, EventArgs e)
        {
            if (F_Contraseña.Text != "")
            {
                if (F_Contraseña.Text == "123")
                {
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta.");
                }
            }
            else
            {
                MessageBox.Show("Escriba la contraseña.");
            }
        }
    }
}