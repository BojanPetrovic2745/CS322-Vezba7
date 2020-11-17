using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_Vezba7_BojanPetrovic2745
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database21DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.database21DataSet.Employees);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MoveNext();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesBindingSource.EndEdit();
                this.employeesTableAdapter.Update(this.database21DataSet.Employees);
                this.employeesTableAdapter.Fill(this.database21DataSet.Employees);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Save | Update failed!" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                this.employeesBindingSource.RemoveCurrent();
                this.employeesBindingSource.EndEdit();
                this.employeesTableAdapter.Update(this.database21DataSet.Employees);
                this.employeesTableAdapter.Fill(this.database21DataSet.Employees);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Save | Update failed!" + ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnAddNew.PerformClick();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            btnPrevious.PerformClick();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            btnNext.PerformClick();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
