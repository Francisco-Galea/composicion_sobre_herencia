using ComposicionSobreHerencia.Controllers;

namespace ComposicionSobreHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string vehicle = txtVehicle.Text;
            string engine = comboBoxEngine.SelectedItem.ToString();
            string driver = comboBoxDriver.SelectedItem.ToString();

            var transport = MainController.CreateVehicle(vehicle, engine, driver);

            txtResults.Text = transport.showInfo();
        }
    }
}
