namespace Fase3JuanCamiloNavarroCorrea
{
    partial class Cola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.C_Comunas = new System.Windows.Forms.ComboBox();
            this.C_Genero = new System.Windows.Forms.ComboBox();
            this.C_Identificacion = new System.Windows.Forms.TextBox();
            this.C_NombreC = new System.Windows.Forms.TextBox();
            this.C_Direccion = new System.Windows.Forms.TextBox();
            this.DatosDeLaCola = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaDeRegistro = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.C_AuxilioE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.C_ProximoP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDeLaCola)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genero";
            // 
            // C_Comunas
            // 
            this.C_Comunas.FormattingEnabled = true;
            this.C_Comunas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.C_Comunas.Location = new System.Drawing.Point(226, 187);
            this.C_Comunas.Name = "C_Comunas";
            this.C_Comunas.Size = new System.Drawing.Size(121, 23);
            this.C_Comunas.TabIndex = 5;
            // 
            // C_Genero
            // 
            this.C_Genero.FormattingEnabled = true;
            this.C_Genero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "No Binario"});
            this.C_Genero.Location = new System.Drawing.Point(226, 241);
            this.C_Genero.Name = "C_Genero";
            this.C_Genero.Size = new System.Drawing.Size(121, 23);
            this.C_Genero.TabIndex = 6;
            // 
            // C_Identificacion
            // 
            this.C_Identificacion.Location = new System.Drawing.Point(226, 40);
            this.C_Identificacion.Name = "C_Identificacion";
            this.C_Identificacion.Size = new System.Drawing.Size(100, 23);
            this.C_Identificacion.TabIndex = 7;
            // 
            // C_NombreC
            // 
            this.C_NombreC.Location = new System.Drawing.Point(226, 89);
            this.C_NombreC.Name = "C_NombreC";
            this.C_NombreC.Size = new System.Drawing.Size(100, 23);
            this.C_NombreC.TabIndex = 8;
            // 
            // C_Direccion
            // 
            this.C_Direccion.Location = new System.Drawing.Point(226, 135);
            this.C_Direccion.Name = "C_Direccion";
            this.C_Direccion.Size = new System.Drawing.Size(100, 23);
            this.C_Direccion.TabIndex = 9;
            // 
            // DatosDeLaCola
            // 
            this.DatosDeLaCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDeLaCola.Location = new System.Drawing.Point(63, 288);
            this.DatosDeLaCola.Name = "DatosDeLaCola";
            this.DatosDeLaCola.RowTemplate.Height = 25;
            this.DatosDeLaCola.Size = new System.Drawing.Size(674, 150);
            this.DatosDeLaCola.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.limpiarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha";
            // 
            // FechaDeRegistro
            // 
            this.FechaDeRegistro.Location = new System.Drawing.Point(459, 48);
            this.FechaDeRegistro.Name = "FechaDeRegistro";
            this.FechaDeRegistro.Size = new System.Drawing.Size(232, 23);
            this.FechaDeRegistro.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Auxilio Economico";
            // 
            // C_AuxilioE
            // 
            this.C_AuxilioE.Enabled = false;
            this.C_AuxilioE.Location = new System.Drawing.Point(514, 89);
            this.C_AuxilioE.Name = "C_AuxilioE";
            this.C_AuxilioE.Size = new System.Drawing.Size(100, 23);
            this.C_AuxilioE.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Proximo pago";
            // 
            // C_ProximoP
            // 
            this.C_ProximoP.Enabled = false;
            this.C_ProximoP.Location = new System.Drawing.Point(514, 135);
            this.C_ProximoP.Name = "C_ProximoP";
            this.C_ProximoP.Size = new System.Drawing.Size(177, 23);
            this.C_ProximoP.TabIndex = 17;
            // 
            // Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.C_ProximoP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.C_AuxilioE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaDeRegistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DatosDeLaCola);
            this.Controls.Add(this.C_Direccion);
            this.Controls.Add(this.C_NombreC);
            this.Controls.Add(this.C_Identificacion);
            this.Controls.Add(this.C_Genero);
            this.Controls.Add(this.C_Comunas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cola";
            this.Text = "Cola";
            ((System.ComponentModel.ISupportInitialize)(this.DatosDeLaCola)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox C_Comunas;
        private ComboBox C_Genero;
        private TextBox C_Identificacion;
        private TextBox C_NombreC;
        private TextBox C_Direccion;
        private DataGridView DatosDeLaCola;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label6;
        private DateTimePicker FechaDeRegistro;
        private ErrorProvider errorProvider1;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private TextBox C_AuxilioE;
        private Label label7;
        private ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private TextBox C_ProximoP;
        private Label label8;
    }
}