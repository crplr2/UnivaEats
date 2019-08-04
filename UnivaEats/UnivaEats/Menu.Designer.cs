namespace UnivaEats
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxCafes = new System.Windows.Forms.ComboBox();
            this.cbxPanes = new System.Windows.Forms.ComboBox();
            this.cbxRefrescos = new System.Windows.Forms.ComboBox();
            this.cbxHelados = new System.Windows.Forms.ComboBox();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCafes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPanes = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregarRefrescos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAgregarHelados = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstPrecio = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnivaEats.Properties.Resources.Menu1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbxCafes
            // 
            this.cbxCafes.FormattingEnabled = true;
            this.cbxCafes.Items.AddRange(new object[] {
            "Americano",
            "Capuchino",
            "Expresso",
            "Expresso Doble",
            "Frappe",
            "Mocka Frappe"});
            this.cbxCafes.Location = new System.Drawing.Point(4, 25);
            this.cbxCafes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCafes.Name = "cbxCafes";
            this.cbxCafes.Size = new System.Drawing.Size(92, 21);
            this.cbxCafes.TabIndex = 1;
            this.cbxCafes.SelectedIndexChanged += new System.EventHandler(this.CbxCafes_SelectedIndexChanged);
            // 
            // cbxPanes
            // 
            this.cbxPanes.FormattingEnabled = true;
            this.cbxPanes.Items.AddRange(new object[] {
            "Minbon",
            "Mini Peackabon",
            "Cinnabon",
            "Peackabon"});
            this.cbxPanes.Location = new System.Drawing.Point(4, 17);
            this.cbxPanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPanes.Name = "cbxPanes";
            this.cbxPanes.Size = new System.Drawing.Size(92, 21);
            this.cbxPanes.TabIndex = 3;
            this.cbxPanes.SelectedIndexChanged += new System.EventHandler(this.CbxPanes_SelectedIndexChanged);
            // 
            // cbxRefrescos
            // 
            this.cbxRefrescos.FormattingEnabled = true;
            this.cbxRefrescos.Items.AddRange(new object[] {
            "Lata",
            "600 ml",
            "Agua 500 ml"});
            this.cbxRefrescos.Location = new System.Drawing.Point(4, 17);
            this.cbxRefrescos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxRefrescos.Name = "cbxRefrescos";
            this.cbxRefrescos.Size = new System.Drawing.Size(92, 21);
            this.cbxRefrescos.TabIndex = 5;
            this.cbxRefrescos.SelectedIndexChanged += new System.EventHandler(this.CbxRefrescos_SelectedIndexChanged);
            // 
            // cbxHelados
            // 
            this.cbxHelados.FormattingEnabled = true;
            this.cbxHelados.Items.AddRange(new object[] {
            "Chocolate Sencillo",
            "Chocolate Doble",
            "Vainilla Sencillo",
            "Vainilla Doble",
            "Chocochips Sencillo",
            "Chocochips Doble",
            "Galleta Oreo Sencillo",
            "Galleta Oreo Doble"});
            this.cbxHelados.Location = new System.Drawing.Point(4, 17);
            this.cbxHelados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxHelados.Name = "cbxHelados";
            this.cbxHelados.Size = new System.Drawing.Size(92, 21);
            this.cbxHelados.TabIndex = 7;
            this.cbxHelados.SelectedIndexChanged += new System.EventHandler(this.CbxHelados_SelectedIndexChanged);
            // 
            // lstPedido
            // 
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.Location = new System.Drawing.Point(4, 17);
            this.lstPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(107, 134);
            this.lstPedido.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(707, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(748, 469);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 30);
            this.lblTotal.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarCafes);
            this.groupBox1.Controls.Add(this.cbxCafes);
            this.groupBox1.Location = new System.Drawing.Point(494, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(248, 60);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cafes";
            // 
            // btnAgregarCafes
            // 
            this.btnAgregarCafes.Location = new System.Drawing.Point(133, 20);
            this.btnAgregarCafes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCafes.Name = "btnAgregarCafes";
            this.btnAgregarCafes.Size = new System.Drawing.Size(69, 24);
            this.btnAgregarCafes.TabIndex = 2;
            this.btnAgregarCafes.Text = "Agregar";
            this.btnAgregarCafes.UseVisualStyleBackColor = true;
            this.btnAgregarCafes.Click += new System.EventHandler(this.BtnAgregarCafes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarPanes);
            this.groupBox2.Controls.Add(this.cbxPanes);
            this.groupBox2.Location = new System.Drawing.Point(494, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(248, 60);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panes";
            // 
            // btnAgregarPanes
            // 
            this.btnAgregarPanes.Location = new System.Drawing.Point(140, 17);
            this.btnAgregarPanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarPanes.Name = "btnAgregarPanes";
            this.btnAgregarPanes.Size = new System.Drawing.Size(69, 24);
            this.btnAgregarPanes.TabIndex = 3;
            this.btnAgregarPanes.Text = "Agregar";
            this.btnAgregarPanes.UseVisualStyleBackColor = true;
            this.btnAgregarPanes.Click += new System.EventHandler(this.BtnAgregarPanes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregarRefrescos);
            this.groupBox3.Controls.Add(this.cbxRefrescos);
            this.groupBox3.Location = new System.Drawing.Point(494, 179);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(248, 60);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Refrescos";
            // 
            // btnAgregarRefrescos
            // 
            this.btnAgregarRefrescos.Location = new System.Drawing.Point(140, 17);
            this.btnAgregarRefrescos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarRefrescos.Name = "btnAgregarRefrescos";
            this.btnAgregarRefrescos.Size = new System.Drawing.Size(69, 24);
            this.btnAgregarRefrescos.TabIndex = 4;
            this.btnAgregarRefrescos.Text = "Agregar";
            this.btnAgregarRefrescos.UseVisualStyleBackColor = true;
            this.btnAgregarRefrescos.Click += new System.EventHandler(this.BtnAgregarRefrescos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAgregarHelados);
            this.groupBox4.Controls.Add(this.cbxHelados);
            this.groupBox4.Location = new System.Drawing.Point(494, 244);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(248, 60);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Helados";
            // 
            // btnAgregarHelados
            // 
            this.btnAgregarHelados.Location = new System.Drawing.Point(140, 17);
            this.btnAgregarHelados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarHelados.Name = "btnAgregarHelados";
            this.btnAgregarHelados.Size = new System.Drawing.Size(69, 24);
            this.btnAgregarHelados.TabIndex = 6;
            this.btnAgregarHelados.Text = "Agregar";
            this.btnAgregarHelados.UseVisualStyleBackColor = true;
            this.btnAgregarHelados.Click += new System.EventHandler(this.BtnAgregarHelados_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(710, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(748, 369);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 30);
            this.lblPrecio.TabIndex = 13;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(604, 474);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(86, 33);
            this.btnOrdenar.TabIndex = 18;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // lstPrecio
            // 
            this.lstPrecio.FormattingEnabled = true;
            this.lstPrecio.Location = new System.Drawing.Point(115, 17);
            this.lstPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPrecio.Name = "lstPrecio";
            this.lstPrecio.Size = new System.Drawing.Size(62, 134);
            this.lstPrecio.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstPrecio);
            this.groupBox5.Controls.Add(this.lstPedido);
            this.groupBox5.Location = new System.Drawing.Point(497, 309);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(199, 160);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pedido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(93, 7);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 20);
            this.lblUsuario.TabIndex = 21;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblUsuario);
            this.groupBox6.Location = new System.Drawing.Point(496, 6);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(246, 39);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Usuario Matricula ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(504, 474);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 33);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 514);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxCafes;
        private System.Windows.Forms.ComboBox cbxPanes;
        private System.Windows.Forms.ComboBox cbxRefrescos;
        private System.Windows.Forms.ComboBox cbxHelados;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCafes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarPanes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregarRefrescos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAgregarHelados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstPrecio;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLimpiar;
    }
}