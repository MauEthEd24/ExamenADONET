namespace ExamenADONET
{
    partial class frmActualizar
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
            button1 = new Button();
            btnGrabar = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label4 = new Label();
            txtIdProducto = new TextBox();
            label5 = new Label();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(297, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(143, 174);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 1;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Location = new Point(71, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 203);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del producto seleccionado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 70);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 99);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Stock:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(131, 62);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(152, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(131, 91);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(152, 23);
            txtStock.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 66);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 9;
            label4.Text = "Id:";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(169, 62);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 25);
            label5.Name = "label5";
            label5.Size = new Size(245, 15);
            label5.TabIndex = 9;
            label5.Text = "INGRESE EL ID DEL PRODUCTO A MODIFICAR";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(194, 385);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 431);
            Controls.Add(btnSalir);
            Controls.Add(txtIdProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "frmActualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACTUALIZAR PRODUCTO";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnGrabar;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtIdProducto;
        private Label label5;
        private Button btnSalir;
    }
}