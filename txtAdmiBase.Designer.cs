namespace WindowsFormsApp4
{
    partial class txtAdmiBase
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UsuariosList = new System.Windows.Forms.ListBox();
            this.Registrolist = new System.Windows.Forms.ListBox();
            this.DevolucionesList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuariosList
            // 
            this.UsuariosList.FormattingEnabled = true;
            this.UsuariosList.Location = new System.Drawing.Point(20, 17);
            this.UsuariosList.Name = "UsuariosList";
            this.UsuariosList.Size = new System.Drawing.Size(277, 433);
            this.UsuariosList.TabIndex = 0;
            // 
            // Registrolist
            // 
            this.Registrolist.FormattingEnabled = true;
            this.Registrolist.Location = new System.Drawing.Point(19, 19);
            this.Registrolist.Name = "Registrolist";
            this.Registrolist.Size = new System.Drawing.Size(282, 433);
            this.Registrolist.TabIndex = 1;
            // 
            // DevolucionesList
            // 
            this.DevolucionesList.FormattingEnabled = true;
            this.DevolucionesList.Location = new System.Drawing.Point(25, 19);
            this.DevolucionesList.Name = "DevolucionesList";
            this.DevolucionesList.Size = new System.Drawing.Size(277, 433);
            this.DevolucionesList.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UsuariosList);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 463);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios Registrados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Registrolist);
            this.groupBox2.Location = new System.Drawing.Point(356, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 463);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Registrados de Prestamos ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DevolucionesList);
            this.groupBox3.Location = new System.Drawing.Point(698, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 463);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro de Devolcuion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Menu Aplicacion  ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Menu Administrador ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAdmiBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1042, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "txtAdmiBase";
            this.Text = "Usuarios ";
            this.Load += new System.EventHandler(this.txtUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox DevolucionesList;
        private System.Windows.Forms.ListBox UsuariosList;
        private System.Windows.Forms.ListBox Registrolist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}