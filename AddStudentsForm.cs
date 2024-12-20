﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class AddStudentsForm : MetroFramework.Forms.MetroForm
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public AddStudentsForm()
        {
            InitializeComponent();
        }

        private void AddStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentsTBL' table. You can move, or remove it, as needed.
            this.studentsTBLTableAdapter.Fill(this.dataSet1.StudentsTBL);
            lblAddStudentsFormClassIDPlaceholder.Text = ClassID.ToString();
            lblAddStudentsFormClassNamePlaceholder.Text = ClassName.ToString();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudentsFormSave_Click(object sender, EventArgs e)
        {
            this.studentsTBLBindingSource.EndEdit();
            this.studentsTBLTableAdapter.Update(dataSet1.StudentsTBL);
        }
    }
}
