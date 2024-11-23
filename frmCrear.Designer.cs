namespace ExamenADONET
{
    partial class frmCrear
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
            btnGrabar = new Button();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(199, 199);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 0;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(189, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(189, 119);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(152, 23);
            txtPrecio.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(189, 148);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(152, 23);
            txtStock.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 98);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 156);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 127);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Precio:";
            // 
            // frmCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 366);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(btnGrabar);
            Name = "frmCrear";
            Text = "CREAR PRODUCTOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGrabar;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}