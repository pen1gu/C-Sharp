
namespace SelectFoodProject
{
    partial class RandomMenuForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnStartEvent = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.FoodCheckList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMenu = new System.Windows.Forms.TextBox();
            this.BtnCurrentFood = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnStartEvent);
            this.panel1.Location = new System.Drawing.Point(202, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 325);
            this.panel1.TabIndex = 0;
            // 
            // BtnStartEvent
            // 
            this.BtnStartEvent.Location = new System.Drawing.Point(131, 298);
            this.BtnStartEvent.Name = "BtnStartEvent";
            this.BtnStartEvent.Size = new System.Drawing.Size(91, 22);
            this.BtnStartEvent.TabIndex = 5;
            this.BtnStartEvent.Text = "시작";
            this.BtnStartEvent.UseVisualStyleBackColor = true;
            this.BtnStartEvent.Click += new System.EventHandler(this.BtnStartEvent_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(468, 354);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(92, 25);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "추가";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FoodCheckList
            // 
            this.FoodCheckList.FormattingEnabled = true;
            this.FoodCheckList.Location = new System.Drawing.Point(582, 12);
            this.FoodCheckList.Name = "FoodCheckList";
            this.FoodCheckList.Size = new System.Drawing.Size(196, 324);
            this.FoodCheckList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "최근 나온 메뉴";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "메뉴 추가";
            // 
            // TxtMenu
            // 
            this.TxtMenu.Location = new System.Drawing.Point(263, 357);
            this.TxtMenu.Name = "TxtMenu";
            this.TxtMenu.Size = new System.Drawing.Size(199, 21);
            this.TxtMenu.TabIndex = 4;
            // 
            // BtnCurrentFood
            // 
            this.BtnCurrentFood.Location = new System.Drawing.Point(103, 14);
            this.BtnCurrentFood.Name = "BtnCurrentFood";
            this.BtnCurrentFood.Size = new System.Drawing.Size(95, 26);
            this.BtnCurrentFood.TabIndex = 6;
            this.BtnCurrentFood.Text = "최근 통계 보기";
            this.BtnCurrentFood.UseVisualStyleBackColor = true;
            this.BtnCurrentFood.Click += new System.EventHandler(this.BtnCurrentFood_Click);
            // 
            // RandomMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.BtnCurrentFood);
            this.Controls.Add(this.TxtMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoodCheckList);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.panel1);
            this.Name = "RandomMenuForm";
            this.Text = "메뉴 랜덤 선택";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.CheckedListBox FoodCheckList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMenu;
        private System.Windows.Forms.Button BtnStartEvent;
        private System.Windows.Forms.Button BtnCurrentFood;
    }
}

