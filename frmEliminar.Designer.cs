namespace ExamenADONET
{
    partial class frmEliminar
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
            txtIdProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEliminar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(149, 64);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 68);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 26);
            label2.Name = "label2";
            label2.Size = new Size(197, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el ID del producto a eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(268, 64);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(190, 230);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 265);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdProducto);
            Name = "frmEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELIMINAR PRODUCTO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProducto;
        private Label label1;
        private Label label2;
        private Button btnEliminar;
        private Button btnSalir;
    }
}