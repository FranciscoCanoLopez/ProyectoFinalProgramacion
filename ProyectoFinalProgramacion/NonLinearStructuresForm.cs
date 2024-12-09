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
    public partial class NonLinearStructuresForm : Form
    {
        public NonLinearStructuresForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataStructuresForm dataStructuresForm = new DataStructuresForm();
            dataStructuresForm.Show();
            this.Close();
        }

        private void btnBinariTree_Click(object sender, EventArgs e)
        {
            BinariTree tree = new BinariTree();
            tree.Show();
            this.Hide();
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            Graphs graphs = new Graphs();
            graphs.Show();
            this.Hide();
        }
    }
}
