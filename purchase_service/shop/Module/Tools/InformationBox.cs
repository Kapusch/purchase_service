﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magasin.Module.Tools
{
    public partial class InformationBox : Form
    {
        public InformationBox(string info)
        {
            InitializeComponent();
            lblInfo.Text = info;
        }
    }
}
