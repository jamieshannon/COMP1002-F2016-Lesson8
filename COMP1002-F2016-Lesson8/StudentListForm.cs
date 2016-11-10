using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using COMP1002_F2016_Lesson8.Models;
using System.Diagnostics;

namespace COMP1002_F2016_Lesson8
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void ListForm2_Load(object sender, EventArgs e)
        {

            this.studentsTableAdapter.Fill(this.cOMP1004DataSet.Students);

            // connect to the db using EF
            CollegeContext db = new CollegeContext();

            var StudentList = (from student in db.Students select student).ToList();

            StudentListDataGridView.DataSource = StudentList;
        }

        private void StudentListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowClicked = e.RowIndex;

            Debug.WriteLine(rowClicked);
        }
    }
}
