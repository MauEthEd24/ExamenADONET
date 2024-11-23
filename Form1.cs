namespace ExamenADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrear frmCrear = new frmCrear();
            frmCrear.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frmeliminar = new frmEliminar();
            frmeliminar.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar frmBuscar = new frmBuscar();
            frmBuscar.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizar frmActualizar = new frmActualizar();
            frmActualizar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
