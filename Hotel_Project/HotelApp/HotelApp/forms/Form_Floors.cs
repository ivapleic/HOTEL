﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.forms
{
    public partial class Form_Floors : Form
    {
        public Form_Floors()
        {
            InitializeComponent();
        }

        private void Form_Floors_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}