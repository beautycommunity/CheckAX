namespace CHK_SUM_SALE_AX
{
    partial class frmChkSumSaleAX
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmALL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDocno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDNS = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(1045, 492);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Size = new System.Drawing.Size(1037, 460);
            // 
            // lsvReport
            // 
            this.lsvReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lsvReport.FullRowSelect = true;
            this.lsvReport.Size = new System.Drawing.Size(1029, 452);
            this.lsvReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvReport_MouseClick);
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
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DNS";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "วันที่";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "FIN_AMT";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SUP_AMT";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CMD_AMT";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CSM_AMT";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "AX_AMT";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 110;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "CSM_DOC";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "AX_DOC";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "หมายเหตุ";
            this.columnHeader13.Width = 200;
            // 
            // tms
            // 
            this.tms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSupport,
            this.tsmALL,
            this.toolStripMenuItem2,
            this.tsmDocno,
            this.toolStripMenuItem3,
            this.tsmDNS});
            this.tms.Name = "tms";
            this.tms.Size = new System.Drawing.Size(222, 140);
            // 
            // tsmSupport
            // 
            this.tsmSupport.Name = "tsmSupport";
            this.tsmSupport.Size = new System.Drawing.Size(221, 24);
            this.tsmSupport.Text = "ดึงขายเข้า SUPPORT";
            this.tsmSupport.Click += new System.EventHandler(this.tsmSupport_Click);
            // 
            // tsmALL
            // 
            this.tsmALL.Name = "tsmALL";
            this.tsmALL.Size = new System.Drawing.Size(221, 24);
            this.tsmALL.Text = "ปรับ CMD ,CSMILE ,AX";
            this.tsmALL.Click += new System.EventHandler(this.tsmALL_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(218, 6);
            // 
            // tsmDocno
            // 
            this.tsmDocno.Name = "tsmDocno";
            this.tsmDocno.Size = new System.Drawing.Size(221, 24);
            this.tsmDocno.Text = "เลขที่เอกสาร";
            this.tsmDocno.Click += new System.EventHandler(this.tsmDocno_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(218, 6);
            // 
            // tsmDNS
            // 
            this.tsmDNS.Name = "tsmDNS";
            this.tsmDNS.Size = new System.Drawing.Size(221, 24);
            this.tsmDNS.Text = "DNS";
            this.tsmDNS.Click += new System.EventHandler(this.tsmDNS_Click);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "workdate";
            this.columnHeader14.Width = 0;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "wh_id";
            this.columnHeader15.Width = 0;
            // 
            // frmChkSumSaleAX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 531);
            this.Name = "frmChkSumSaleAX";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmChkSumSaleAX_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ContextMenuStrip tms;
        private System.Windows.Forms.ToolStripMenuItem tsmSupport;
        private System.Windows.Forms.ToolStripMenuItem tsmALL;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmDocno;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmDNS;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}

