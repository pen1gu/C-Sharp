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
        List <MenuControlData> _resultList = new List<MenuControlData>();
        public RandomMenuForm()
        {
            InitializeComponent();
        //    this.Paint += new PaintEventHandler();
        }

        
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            FoodCheckList.Items.Add(TxtMenu.Text,CheckState.Unchecked);
            TxtMenu.Text = "";
        }

        private void BtnStartEvent_Click(object sender, EventArgs e)
        {
            //TODO: 돌림판 이벤트 구성

            int listCount = FoodCheckList.CheckedItems.Count;
            string[] randomItem = new string[listCount];
            string menuText = "";

            for(int i = 0; i <listCount; i++)
            {
                randomItem[i] = (string)FoodCheckList.CheckedItems[i];
            }

            MenuControlData controlData = new MenuControlData();

            Random random = new Random();
            menuText = randomItem[random.Next(0, listCount)];

            Label newMenuLabel = new Label();
            newMenuLabel.Text = menuText;

            controlData.MenuText = randomItem[random.Next(0, listCount)];
            controlData.Control = newMenuLabel;

            _resultList.Add(controlData);
            UpdateMenuBoard();
        }

        private void BtnCurrentFood_Click(object sender, EventArgs e)
        {
            //TODO: 엑셀 파일 구성, 로드 전용 폼 구성
        }

        private void TxtMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                FoodCheckList.Items.Add(TxtMenu.Text, CheckState.Unchecked);
                TxtMenu.Text = "";
            }
        }

        //TODO: 최근 메뉴 동적 추가 구성

        private void UpdateMenuBoard()
        {
            int index = 0;

            MenuPanel.Controls.Clear();

            foreach (var result in _resultList)
            {
                result.Control.SetBounds(0 , index * 30 + 10, 60, 20);

                MenuPanel.Controls.Add(result.Control);
                index++;
            }
        }

        private void FoodCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: 체크한 것이 없을 시 버튼 비활성화
           
        }
    }

    public class MenuControlData
    {
        public string MenuText;
        public Label Control;
    }
}
