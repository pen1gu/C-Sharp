using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectFoodProject
{
    public partial class RandomMenuForm : Form
    {
        private Graphics g;
        public RandomMenuForm()
        {
            InitializeComponent();
        //    this.Paint += new PaintEventHandler();
        }

        
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            FoodCheckList.Items.Add(TxtMenu.Text,CheckState.Unchecked);
        }

        private void BtnStartEvent_Click(object sender, EventArgs e)
        {
            //TODO: 돌림판 이벤트 구성
        }

        private void BtnCurrentFood_Click(object sender, EventArgs e)
        {
            //TODO: 엑셀 파일 구성
        }

        //TODO: 최근 메뉴 동적 추가 구성
    }
}
