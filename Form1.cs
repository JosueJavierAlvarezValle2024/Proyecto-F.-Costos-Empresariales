namespace Proyecto_F._Costos_Empresariales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtainedData.MateriaPrima = double.Parse(txtMateriaPrima.Text);
                ObtainedData.GradoDeAvanceMP = double.Parse(txtGradoAvanceMP.Text);
                ObtainedData.VolumenProducido = double.Parse(txtVolumenProducido.Text);
                ObtainedData.ManoDeObra = double.Parse(txtManoDeObra.Text);
                ObtainedData.GradoDeAvanceMO = double.Parse(txtGradoAvanceMO.Text);
                ObtainedData.VolumenTerminado = double.Parse(TxtVolumenTerminado.Text);
                ObtainedData.CostosIndirectos = double.Parse(txtCostosIndirectos.Text);
                ObtainedData.GradoDeAvanceCI = double.Parse(txtGradoAvanceCI.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }


    }
}
