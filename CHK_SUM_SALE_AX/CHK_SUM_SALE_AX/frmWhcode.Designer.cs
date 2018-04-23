namespace CHK_SUM_SALE_AX
{
    partial class frmWhcode
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
            this.kbLabel1 = new kBeautyLibrary.kbLabel(this.components);
            this.txtSearch = new kBeautyLibrary.kbTextBox(this.components);
            this.btnSearch = new kBeautyLibrary.kbButton(this.components);
            this.lv = new kBeautyLibrary.kbListView(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAll = new kBeautyLibrary.kbLinkLabel(this.components);
            this.SuspendLayout();
            // 
            // kbLabel1
            // 
            this.kbLabel1.AutoSize = true;
            this.kbLabel1.Location = new System.Drawing.Point(68, 66);
            this.kbLabel1.Name = "kbLabel1";
            this.kbLabel1.Size = new System.Drawing.Size(46, 21);
            this.kbLabel1.TabIndex = 192;
            this.kbLabel1.Text = "สาขา";
            // 
            // txtSearch
            // 
            this.txtSearch._clickColorShow = false;
            this.txtSearch.code = null;
            this.txtSearch.Location = new System.Drawing.Point(120, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 27);
            this.txtSearch.TabIndex = 193;
            this.txtSearch.value = null;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(361, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 194;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.CheckBoxes = true;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 116);
            this.lv.Name = "lv";
            this.lv.Row = null;
            this.lv.Size = new System.Drawing.Size(539, 473);
            this.lv.TabIndex = 195;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "รหัสสาขา";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "สาขา";
            this.columnHeader3.Width = 297;
            // 
            // lblAll
            // 
            this.lblAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(449, 93);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(84, 21);
            this.lblAll.TabIndex = 196;
            this.lblAll.TabStop = true;
            this.lblAll.Text = "All / None";
            // 
            // frmWhcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 601);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.kbLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmWhcode";
            this.Text = "สาขา";
            this.Controls.SetChildIndex(this.kbLabel1, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.lv, 0);
            this.Controls.SetChildIndex(this.lblAll, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kBeautyLibrary.kbLabel kbLabel1;
        private kBeautyLibrary.kbTextBox txtSearch;
        private kBeautyLibrary.kbButton btnSearch;
        private kBeautyLibrary.kbListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private kBeautyLibrary.kbLinkLabel lblAll;
    }
}