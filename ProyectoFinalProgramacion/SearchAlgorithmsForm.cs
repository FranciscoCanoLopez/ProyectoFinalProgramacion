﻿using System;
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
    public partial class SearchAlgorithmsForm : Form
    {
        public SearchAlgorithmsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AlgorithmsForm algorithmsForm = new AlgorithmsForm();
            algorithmsForm.Show();
            this.Close();
        }
    }
}
