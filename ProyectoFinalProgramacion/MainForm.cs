namespace ProyectoFinalProgramacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnAlgorithms_Click(object sender, EventArgs e)
        {
            AlgorithmsForm algorithmsForm = new AlgorithmsForm();
            algorithmsForm.Show();
            this.Hide();
        }

        private void btnDataStructures_Click(object sender, EventArgs e)
        {
            DataStructuresForm dataStructuresForm = new DataStructuresForm();
            dataStructuresForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
