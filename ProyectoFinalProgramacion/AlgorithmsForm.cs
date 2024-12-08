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
    public partial class AlgorithmsForm : Form
    {
        public AlgorithmsForm()
        {
            InitializeComponent();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            SortingAlgorithmsForm sortingForm = new SortingAlgorithmsForm();
            sortingForm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAlgorithmsForm searchForm = new SearchAlgorithmsForm();
            searchForm.Show();
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
