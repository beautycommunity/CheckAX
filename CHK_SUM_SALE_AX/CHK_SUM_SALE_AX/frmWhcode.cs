using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using k.libary;

namespace CHK_SUM_SALE_AX
{
    public partial class frmWhcode : frmReportCondition
    {
        string StrConn;
        string Brand;
        TextBox txt_whcode = new TextBox();
        TextBox txt_Bl = new TextBox();

        public frmWhcode()
        {

            InitializeComponent();
            StrConn = "data source=192.168.1.53,1733; initial catalog=CMD-BX;Integrated Security=false;User id=sa;Password=0211";
            Brand = "BM";
            txt_Bl.Text = "false";
            txt_whcode.Text = "";
        }

        public frmWhcode(string _StrConn, String _Brand, ref TextBox _txt_Whcode, ref TextBox _txt_Bl)
        {
            InitializeComponent();
            StrConn = _StrConn;
            Brand = _Brand;
            txt_Bl = _txt_Bl;
            txt_whcode = _txt_Whcode;

            txt_Bl.Text = "false";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void GetWhcode ()
        {
            try
            {
                string sql = "";

                sql = "select * from [cmd-bx]..mas_wh where whcode like '%" + txtSearch.Text + "%' or abbname = '%" + txtSearch.Text + "%' or fullname like '%" + txtSearch.Text + "%'";

                DataSet dsWhcode = new DataSet();

                dsWhcode = cData.getDataSetWithSqlCommand(StrConn, sql, 100000, true);

                lv.addDataWithDataset(dsWhcode, true, true);
            }
            catch(Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด\n" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetWhcode();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                GetWhcode();
            }
        }

        public override void btnSubmit_Click(object sender, EventArgs e)
        {
            //base.btnSubmit_Click(sender, e);
            txt_whcode.Text = "";
            if (lv.Items.Count > 0)
            {
                for (int rw = 0; rw <= lv.Items.Count - 1; rw++)
                {
                    if (lv.Items[rw].Checked)
                    {
                        if (txt_whcode.Text == "")
                        {
                            txt_whcode.Text = lv.Items[rw].SubItems[1].Text + ":" + lv.Items[rw].SubItems[2].Text;
                        }
                        else
                        {
                            txt_whcode.Text = "," + lv.Items[rw].SubItems[1].Text + ":" + lv.Items[rw].SubItems[2].Text;
                        }
                    }
                }

                if (txt_whcode.Text == "")
                {
                    txt_Bl.Text = "false";
                }
                else
                {
                    txt_Bl.Text = "true";
                }
            }
            else
            {
                txt_Bl.Text = "false";
            }

            this.Close();

        }
    }
}
