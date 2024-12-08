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
    public partial class Stacks : Form
    {
        public Stacks()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LinearStructuresForm linearStructuresForm = new LinearStructuresForm();
            linearStructuresForm.Show();
            this.Close();
        }

        //static stack

        private void btnPushStaticStack_Click(object sender, EventArgs e)
        {

        }

        private void btnPopStaticStack_Click(object sender, EventArgs e)
        {

        }

        private void btnPeekStaticStack_Click(object sender, EventArgs e)
        {

        }
    }
}
