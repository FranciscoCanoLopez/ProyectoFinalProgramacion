using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacion
{
    public partial class DataStructuresForm : Form
    {
        public DataStructuresForm()
        {
            InitializeComponent();
        }
        private void btnLinear_Click(object sender, EventArgs e)
        {
            LinearStructuresForm linearForm = new LinearStructuresForm();
            linearForm.Show();
            this.Hide();
        }

        private void btnNonLinear_Click(object sender, EventArgs e)
        {
            NonLinearStructuresForm nonLinearForm = new NonLinearStructuresForm();
            nonLinearForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
