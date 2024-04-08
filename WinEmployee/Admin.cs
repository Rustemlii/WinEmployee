using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinEmployee.Crud;

namespace WinEmployee
{

    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        int id = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetAll get = new GetAll(dataGridView1);
        }

        void Sifirlama()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtBIrthday.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtPosition.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtexperience.Text = string.Empty;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                id = Convert.ToInt32(item.Cells[0].Value.ToString());
                Delete delete = new Delete(id, dataGridView1);
                GetAll get = new GetAll(dataGridView1);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                id = Convert.ToInt32(item.Cells[0].Value);
                Update updated = new Update(id, txtName.Text, txtSurname.Text, txtBIrthday.Text, Convert.ToInt32(txtexperience.Text),
                    txtPosition.Text, txtDepartment.Text, txtStatus.Text, Convert.ToDecimal(txtSalary.Text), dataGridView1);
                GetAll get = new GetAll(dataGridView1);
                Sifirlama();

            }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectRow = 0;
            selectRow = e.RowIndex;
            txtName.Text = dataGridView1.Rows[selectRow].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[selectRow].Cells[2].Value.ToString();
            txtBIrthday.Text = dataGridView1.Rows[selectRow].Cells[3].Value.ToString();
            txtexperience.Text = dataGridView1.Rows[selectRow].Cells[4].Value.ToString();
            txtPosition.Text = dataGridView1.Rows[selectRow].Cells[5].Value.ToString();
            txtDepartment.Text = dataGridView1.Rows[selectRow].Cells[6].Value.ToString();
            txtStatus.Text = dataGridView1.Rows[selectRow].Cells[7].Value.ToString();
            txtSalary.Text = dataGridView1.Rows[selectRow].Cells[8].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                Search search = new Search(txtSearch.Text, dataGridView1);
            }
            else
            {
                MessageBox.Show("Axtaracaginiz iscinin adini qeyd edin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
