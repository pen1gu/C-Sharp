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
        public ChattingForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtContents.AppendText(txtChatting.Text + "\n");
        }
    }
}
