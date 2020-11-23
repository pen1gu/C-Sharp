using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessangerApplication
{
    public partial class LoginForm : Form
    {
        UserData userData;
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "현준" && txtPassword.Text == "1234")
            {
                MessageBox.Show(txtId.Text + "님 환영합니다.", "환영합니다.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userData = new UserData();
                userData.setUserId(txtId.Text);

                this.Visible = false;
                ChattingForm chatting = new ChattingForm();
                chatting.Show();
            }
        }
    }
}
