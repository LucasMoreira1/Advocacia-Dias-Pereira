﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advocacia_Dias_Pereira
{
    public partial class FormGerarDocumentos : Form
    {
        public FormGerarDocumentos()
        {
            InitializeComponent();
        }

        private void FormGerarDocumentos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
