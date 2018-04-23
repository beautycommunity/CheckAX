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
    public partial class frmChkSumSaleAXCond : frmReportCondition
    {
        string StrConn;
        string Brand;
        TextBox txt_Sql = new TextBox();
        TextBox txt_Bl = new TextBox();
        TextBox txt_Whcode = new TextBox();
        TextBox txt_wBl = new TextBox();

        DataSet ds = new DataSet();

        public frmChkSumSaleAXCond()
        {
            InitializeComponent();

            InitializeComponent();
            StrConn = "data source=192.168.1.53,1733; initial catalog=CMD-BX;Integrated Security=false;User id=sa;Password=0211";
            Brand = "BM";
            txt_Bl.Text = "false";
            txt_Sql.Text = "";
        }

        public frmChkSumSaleAXCond(string _StrConn, String _Brand,ref TextBox _txt_Sql,ref TextBox _txt_Bl)
        {
            InitializeComponent();
            StrConn = _StrConn;
            Brand = _Brand;
            txt_Bl = _txt_Bl;
            txt_Sql = _txt_Sql;

            txt_Bl.Text = "false";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void radAtDate_CheckedChanged(object sender, EventArgs e)
        {
            if(radAtDate.Checked)
            {
                gbxAtdate.Enabled = true;
                gbxBetween.Enabled = false;
            }
            else
            {
                gbxAtdate.Enabled = false;
                gbxBetween.Enabled = true;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lv.SelectedItems[0].Remove();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmWhcode frm = new frmWhcode(StrConn,Brand,ref txt_Whcode,ref txt_wBl);
                frm.ShowDialog();

                if(txt_wBl.Text.ToLower() == "true")
                {
                    string strWhcode = txt_Whcode.Text;
                    string[] ArWhcode;
                    string[] ArWhname;

                    ArWhcode = strWhcode.Split(',');

                    for (int i = 0; i <= ArWhcode.Length - 1; i++)
                    {
                        ListViewItem LvItm;
                        ArWhname = ArWhcode[i].Split(':');
                        LvItm = lv.Items.Add((i+1).ToString());
                        int idx = lv.Items.IndexOf(LvItm);
                        lv.Items[idx].SubItems.Add(ArWhname[0]);
                        lv.Items[idx].SubItems.Add(ArWhname[1]);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด\n" + ex.Message);
            }
        }

        public override void btnSubmit_Click(object sender, EventArgs e)
        {
            //base.btnSubmit_Click(sender, e);

            txt_Bl.Text = "false";

            string sql = "";
            string whstr = "";



            if (radAtDate.Checked)
            {
                if (Brand.ToLower() == "bb")
                {
                    sql = "exec PP_CHECK_BB_SALES_DATE '" + dtpAtDate.getDateOnlyForSql() + "' , '" + dtpAtDate.getDateOnlyForSql() + "' ";
                }
                else
                {
                    sql = "exec [dbbeautycommsupport]..PP_CHECK_SALES_DATE '" + dtpAtDate.getDateOnlyForSql() + "' , '" + dtpAtDate.getDateOnlyForSql() + "' ";
                }
            }
            else
            {
                if (Brand.ToLower() == "bb")
                {
                    sql = "exec PP_CHECK_BB_SALES_DATE '" + dtpSDate.getDateOnlyForSql() + "' , '" + dtpFDate.getDateOnlyForSql() + "' ";
                }
                else
                {
                    sql = "exec [dbbeautycommsupport]..PP_CHECK_SALES_DATE '" + dtpSDate.getDateOnlyForSql() + "' , '" + dtpFDate.getDateOnlyForSql() + "' ";
                }
            }
           
            txt_Bl.Text = "true";
            txt_Sql.Text = sql;

            this.Close();
        }
    }
}
