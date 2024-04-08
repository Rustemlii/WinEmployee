using System.Data.SqlClient;
using WinEmployee.Crud;
using WinEmployee.SqlConnecttion;

namespace WinEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Sifirlama()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtMaaw.Text = string.Empty;
            numericUpDown1.Value = 0;
            cmbSahe.Text = string.Empty;
            cmbStatus.Text = string.Empty;
            cmbWobe.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            int experience = Convert.ToInt32(numericUpDown1.Value);
            string date = dateTimePicker1.Value.ToString();
            string sahe = cmbSahe.SelectedItem.ToString();
            string department = cmbWobe.SelectedItem.ToString();
            string status = cmbStatus.SelectedItem.ToString();
            decimal maaw = Convert.ToDecimal(txtMaaw.Text);

            Create c = new Create(txtAd.Text, txtSoyad.Text, date, experience,
                 sahe, department, status, maaw);
            Sifirlama();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginPassword lg = new LoginPassword();
            lg.Show();
        }
    }
}