﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoalYoutuber
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListaYoutuber().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new ListaYoutuber().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
