using System;
using Backend.SDK;
using System.Windows.Forms;

namespace TokenUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackendSDKModel m = new BackendSDKModel() {
                AccountID = textBox1.Text,
                BrandID = Convert.ToInt16(textBox2.Text),
                CurrencyID = textBox3.Text,
                LanguageCode = textBox4.Text,
                PermissionFunctionID = textBox5.Text
            };
            textBox6.Text = m.GenerateToken(1440);
        }
    }
}
