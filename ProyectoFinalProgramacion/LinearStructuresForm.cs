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
    public partial class LinearStructuresForm : Form
    {
        public LinearStructuresForm()
        {
            InitializeComponent();
        }

        private void btnLists_Click(object sender, EventArgs e)
        {
            Lists lists = new Lists();
            lists.Show();
            this.Hide();
        }

        private void btnStacks_Click(object sender, EventArgs e)
        {
            Stacks stacks = new Stacks();
            stacks.Show();
            this.Hide();
        }

        private void btnQueues_Click(object sender, EventArgs e)
        {
            Queues queues = new Queues();
            queues.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataStructuresForm dataStructuresForm = new DataStructuresForm();
            dataStructuresForm.Show();
            this.Close();
        }
    }
}
