﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class roles : Semple
    {
        public roles()
        {
            InitializeComponent();
        }

        private void roles_Load(object sender, EventArgs e)
        {

        }

        private void rolenameTxt_TextChanged(object sender, EventArgs e)
        {
            if (rolenameTxt.Text == " ") { rolenameerror.Visible = true; } else { rolenameerror.Visible = false; }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1)  { rolestatuserror.Visible = true; } else { rolestatuserror.Visible = false; }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
