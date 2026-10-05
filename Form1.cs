using System;
using System.Windows.Forms;

namespace GitHubLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            using (Form2 form = new Form2())
            {
                form.ShowDialog(this);
            }
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Авторизация выполнена успешно.", "Авторизация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тест функции пройден.", "Тест",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
