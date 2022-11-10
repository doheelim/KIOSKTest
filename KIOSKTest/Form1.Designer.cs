namespace KIOSKTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuBox = new System.Windows.Forms.ListBox();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addMenu = new System.Windows.Forms.Button();
            this.orderBox = new System.Windows.Forms.ListBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delMenu = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBox
            // 
            this.menuBox.DataSource = this.menuBindingSource;
            this.menuBox.DisplayMember = "Name";
            this.menuBox.FormattingEnabled = true;
            this.menuBox.ItemHeight = 12;
            this.menuBox.Location = new System.Drawing.Point(95, 54);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(120, 184);
            this.menuBox.TabIndex = 0;
            this.menuBox.ValueMember = "Price";
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(KIOSKTest.Product);
            // 
            // addMenu
            // 
            this.addMenu.Location = new System.Drawing.Point(95, 244);
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(120, 23);
            this.addMenu.TabIndex = 1;
            this.addMenu.Text = "주문추가";
            this.addMenu.UseVisualStyleBackColor = true;
            this.addMenu.Click += new System.EventHandler(this.addMenu_Click);
            // 
            // orderBox
            // 
            this.orderBox.DataSource = this.orderBindingSource;
            this.orderBox.DisplayMember = "Name";
            this.orderBox.FormattingEnabled = true;
            this.orderBox.ItemHeight = 12;
            this.orderBox.Location = new System.Drawing.Point(245, 54);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(120, 148);
            this.orderBox.TabIndex = 2;
            this.orderBox.ValueMember = "Price";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(KIOSKTest.Product);
            // 
            // delMenu
            // 
            this.delMenu.Location = new System.Drawing.Point(245, 209);
            this.delMenu.Name = "delMenu";
            this.delMenu.Size = new System.Drawing.Size(120, 23);
            this.delMenu.TabIndex = 3;
            this.delMenu.Text = "선택삭제";
            this.delMenu.UseVisualStyleBackColor = true;
            this.delMenu.Click += new System.EventHandler(this.delMenu_Click);
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(245, 244);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(120, 23);
            this.payBtn.TabIndex = 4;
            this.payBtn.Text = "결제";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 326);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.delMenu);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.addMenu);
            this.Controls.Add(this.menuBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox menuBox;
        private System.Windows.Forms.Button addMenu;
        private System.Windows.Forms.ListBox orderBox;
        private System.Windows.Forms.Button delMenu;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
    }
}

