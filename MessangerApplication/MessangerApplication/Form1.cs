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
    public partial class ChattingForm : Form
    {
        UserData userData;
        public ChattingForm(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            txtContents.AppendText(userData.getUserId().ToString() + " : " + txtChatting.Text + "\n");
            txtContents.ScrollToCaret();
            txtContents.Text = "";
        }
    }
}
