namespace ExamenADONET
{
    partial class frmBuscar
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
            btnBuscarProducto = new Button();
            dgvProductos = new DataGridView();
            label1 = new Label();
            txtNombreProducto = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(295, 60);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(75, 23);
            btnBuscarProducto.TabIndex = 0;
            btnBuscarProducto.Text = "BUSCAR";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(61, 129);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(458, 124);
            dgvProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 29);
            label1.Name = "label1";
            label1.Size = new Size(226, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el nombre del producto a buscar: ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(61, 60);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(228, 23);
            txtNombreProducto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 84);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Ejemplo: Leche";
            // 
            // frmBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 346);
            Controls.Add(label2);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscarProducto);
            Name = "frmBuscar";
            Text = "BUSCAR PRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarProducto;
        private DataGridView dgvProductos;
        private Label label1;
        private TextBox txtNombreProducto;
        private Label label2;
    }
}