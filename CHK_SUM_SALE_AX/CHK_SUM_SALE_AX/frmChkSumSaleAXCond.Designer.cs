namespace CHK_SUM_SALE_AX
{
    partial class frmChkSumSaleAXCond
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tc = new kBeautyLibrary.kbTabControl(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radBetween = new kBeautyLibrary.kbRadioButton(this.components);
            this.radAtDate = new kBeautyLibrary.kbRadioButton(this.components);
            this.gbxBetween = new kBeautyLibrary.kbGroupBox(this.components);
            this.dtpSDate = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.kbLabel1 = new kBeautyLibrary.kbLabel(this.components);
            this.dtpFDate = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.kbLabel2 = new kBeautyLibrary.kbLabel(this.components);
            this.gbxAtdate = new kBeautyLibrary.kbGroupBox(this.components);
            this.dtpAtDate = new kBeautyLibrary.kbDateTimePicker(this.components);
            this.kbLabel3 = new kBeautyLibrary.kbLabel(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lv = new kBeautyLibrary.kbListView(this.components);
            this.btnAdd = new kBeautyLibrary.kbButton(this.components);
            this.btnDel = new kBeautyLibrary.kbButton(this.components);
            this.btnAll = new kBeautyLibrary.kbButton(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxBetween.SuspendLayout();
            this.gbxAtdate.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabPage1);
            this.tc.Controls.Add(this.tabPage2);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 39);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(477, 411);
            this.tc.TabIndex = 192;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radBetween);
            this.tabPage1.Controls.Add(this.radAtDate);
            this.tabPage1.Controls.Add(this.gbxBetween);
            this.tabPage1.Controls.Add(this.gbxAtdate);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วันที่";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radBetween
            // 
            this.radBetween.AutoSize = true;
            this.radBetween.Location = new System.Drawing.Point(38, 156);
            this.radBetween.Name = "radBetween";
            this.radBetween.Size = new System.Drawing.Size(17, 16);
            this.radBetween.TabIndex = 7;
            this.radBetween.UseVisualStyleBackColor = true;
            // 
            // radAtDate
            // 
            this.radAtDate.AutoSize = true;
            this.radAtDate.Checked = true;
            this.radAtDate.Location = new System.Drawing.Point(38, 33);
            this.radAtDate.Name = "radAtDate";
            this.radAtDate.Size = new System.Drawing.Size(17, 16);
            this.radAtDate.TabIndex = 6;
            this.radAtDate.TabStop = true;
            this.radAtDate.UseVisualStyleBackColor = true;
            this.radAtDate.CheckedChanged += new System.EventHandler(this.radAtDate_CheckedChanged);
            // 
            // gbxBetween
            // 
            this.gbxBetween.Controls.Add(this.dtpSDate);
            this.gbxBetween.Controls.Add(this.kbLabel1);
            this.gbxBetween.Controls.Add(this.dtpFDate);
            this.gbxBetween.Controls.Add(this.kbLabel2);
            this.gbxBetween.Enabled = false;
            this.gbxBetween.Location = new System.Drawing.Point(73, 144);
            this.gbxBetween.Name = "gbxBetween";
            this.gbxBetween.Size = new System.Drawing.Size(295, 152);
            this.gbxBetween.TabIndex = 5;
            this.gbxBetween.TabStop = false;
            this.gbxBetween.Text = "ช่วงวันที่";
            // 
            // dtpSDate
            // 
            this.dtpSDate.DisplayThai = true;
            this.dtpSDate.Location = new System.Drawing.Point(73, 37);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(200, 27);
            this.dtpSDate.TabIndex = 2;
            // 
            // kbLabel1
            // 
            this.kbLabel1.AutoSize = true;
            this.kbLabel1.Location = new System.Drawing.Point(27, 43);
            this.kbLabel1.Name = "kbLabel1";
            this.kbLabel1.Size = new System.Drawing.Size(40, 21);
            this.kbLabel1.TabIndex = 0;
            this.kbLabel1.Text = "วันที่";
            // 
            // dtpFDate
            // 
            this.dtpFDate.DisplayThai = true;
            this.dtpFDate.Location = new System.Drawing.Point(73, 84);
            this.dtpFDate.Name = "dtpFDate";
            this.dtpFDate.Size = new System.Drawing.Size(200, 27);
            this.dtpFDate.TabIndex = 3;
            // 
            // kbLabel2
            // 
            this.kbLabel2.AutoSize = true;
            this.kbLabel2.Location = new System.Drawing.Point(4, 90);
            this.kbLabel2.Name = "kbLabel2";
            this.kbLabel2.Size = new System.Drawing.Size(63, 21);
            this.kbLabel2.TabIndex = 1;
            this.kbLabel2.Text = "ถึง วันที่";
            // 
            // gbxAtdate
            // 
            this.gbxAtdate.Controls.Add(this.dtpAtDate);
            this.gbxAtdate.Controls.Add(this.kbLabel3);
            this.gbxAtdate.Location = new System.Drawing.Point(73, 23);
            this.gbxAtdate.Name = "gbxAtdate";
            this.gbxAtdate.Size = new System.Drawing.Size(295, 100);
            this.gbxAtdate.TabIndex = 4;
            this.gbxAtdate.TabStop = false;
            this.gbxAtdate.Text = "ณ วันที่";
            // 
            // dtpAtDate
            // 
            this.dtpAtDate.DisplayThai = true;
            this.dtpAtDate.Location = new System.Drawing.Point(73, 37);
            this.dtpAtDate.Name = "dtpAtDate";
            this.dtpAtDate.Size = new System.Drawing.Size(200, 27);
            this.dtpAtDate.TabIndex = 4;
            // 
            // kbLabel3
            // 
            this.kbLabel3.AutoSize = true;
            this.kbLabel3.Location = new System.Drawing.Point(27, 43);
            this.kbLabel3.Name = "kbLabel3";
            this.kbLabel3.Size = new System.Drawing.Size(40, 21);
            this.kbLabel3.TabIndex = 3;
            this.kbLabel3.Text = "วันที่";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAll);
            this.tabPage2.Controls.Add(this.btnDel);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.lv);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สาขา";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(8, 55);
            this.lv.Name = "lv";
            this.lv.Row = null;
            this.lv.Size = new System.Drawing.Size(453, 316);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(400, 16);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(25, 33);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(431, 16);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(30, 33);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "--";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ลำดับ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "รหัสสาขา";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "สาขา";
            this.columnHeader3.Width = 162;
            // 
            // frmChkSumSaleAXCond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.tc);
            this.Name = "frmChkSumSaleAXCond";
            this.Controls.SetChildIndex(this.tc, 0);
            this.tc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxBetween.ResumeLayout(false);
            this.gbxBetween.PerformLayout();
            this.gbxAtdate.ResumeLayout(false);
            this.gbxAtdate.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kBeautyLibrary.kbTabControl tc;
        private System.Windows.Forms.TabPage tabPage1;
        private kBeautyLibrary.kbRadioButton radBetween;
        private kBeautyLibrary.kbRadioButton radAtDate;
        private kBeautyLibrary.kbGroupBox gbxBetween;
        private kBeautyLibrary.kbDateTimePicker dtpSDate;
        private kBeautyLibrary.kbLabel kbLabel1;
        private kBeautyLibrary.kbDateTimePicker dtpFDate;
        private kBeautyLibrary.kbLabel kbLabel2;
        private kBeautyLibrary.kbGroupBox gbxAtdate;
        private kBeautyLibrary.kbDateTimePicker dtpAtDate;
        private kBeautyLibrary.kbLabel kbLabel3;
        private System.Windows.Forms.TabPage tabPage2;
        private kBeautyLibrary.kbButton btnAll;
        private kBeautyLibrary.kbButton btnDel;
        private kBeautyLibrary.kbButton btnAdd;
        private kBeautyLibrary.kbListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}