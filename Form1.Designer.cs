namespace ExamenADONET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscar = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnCrear = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(112, 103);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 56);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(34, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 271);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manetendor de Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 48);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 4;
            label1.Text = "Elija la opción que desea realizar";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(247, 103);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(119, 56);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(247, 191);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 56);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(112, 191);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(119, 56);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(245, 378);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnCrear;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnSalir;
    }
}
