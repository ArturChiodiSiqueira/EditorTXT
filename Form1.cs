﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu Arquivo
        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
        }

        private void mArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        #endregion
    }
}
