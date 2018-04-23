using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using k.libary;
using System.Globalization;

namespace CHK_SUM_SALE_AX
{
    public partial class frmChkSumSaleAX : frmReport
    {
        string StrConn;
        string Brand;
        TextBox txt_Sql = new TextBox();
        TextBox txt_Bl = new TextBox();

        public frmChkSumSaleAX()
        {
            InitializeComponent();
            StrConn = "data source=192.168.1.220,1433; initial catalog=CMD-BX;Integrated Security=false;User id=sa;Password=0211";
            Brand = "BB";
        }

        public frmChkSumSaleAX(string _StrConn,String _Brand)
        {
            InitializeComponent();
            StrConn = _StrConn;
            Brand = _Brand;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }

        private void frmChkSumSaleAX_Load(object sender, EventArgs e)
        {
            btnSearch.Visible = false;
            btnRefreshData.Visible = false;
            btnAddData.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnImportCSV.Visible = false;
            btnImportData.Visible = false;
            btnImportTextTab.Visible = false;
            btnNewData.Visible = false;
            btnRefreshDataAll.Visible = false;
            btnRefreshDataClose.Visible = false;
            btnRefreshDataOpen.Visible = false;
            btnSaveData.Visible = false;
            btnSubmit.Visible = false;
            btnSyncData.Visible = false;
            toolStripButton1.Visible = false;
            toolStripSeparator2.Visible = false;
            toolStripSeparator4.Visible = false;

            this.Text = Brand;
        }

        public override void btnCondition_Click(object sender, EventArgs e)
        {
            //base.btnCondition_Click(sender, e);

            try
            {
                frmChkSumSaleAXCond frm = new frmChkSumSaleAXCond(StrConn,Brand,ref txt_Sql,ref txt_Bl);
                frm.ShowDialog();

                if(txt_Bl.Text.ToLower() == "true")
                {
                    string sql = txt_Sql.Text;

                    DataSet ds = new DataSet();

                    using (cWaitIndicator cw = new cWaitIndicator())
                    {
                        getstr();
                        ds = cData.getDataSetWithSqlCommand(StrConn, sql, 1000000, true);
                        setstr();
                        //lsvReport.addDataWithDataset(ds, true, true);

                        for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                        {
                            ListViewItem LvItm;
                           
                            LvItm = lsvReport.Items.Add((i + 1).ToString());
                            int idx = lsvReport.Items.IndexOf(LvItm);
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["whcode"].ToString());
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["whname"].ToString());
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["wh_dns"].ToString());
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["atdate"].ToString());
                            lsvReport.Items[idx].SubItems.Add(decimal.Parse( ds.Tables[0].Rows[i]["financial_amt"].ToString()).ToString("#,##0.00"));
                            lsvReport.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[i]["support_amt"].ToString()).ToString("#,##0.00"));
                            lsvReport.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[i]["cmd_amt"].ToString()).ToString("#,##0.00"));
                            lsvReport.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[i]["csmile_amt"].ToString()).ToString("#,##0.00"));
                            lsvReport.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[i]["ax_amt"].ToString()).ToString("#,##0.00"));
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["csmile_docno"].ToString());
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["ax_docno"].ToString());
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["remark"].ToString());
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["workdate_sql"].ToString());
                            lsvReport.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["wh_id"].ToString());

                        }

                    }

                    MessageBox.Show("ดึงข้อมูลสำเร็จ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด\n" + ex.Message);
            }
        }

        private void getstr()
        {
            if (Brand.ToLower() == "bb")
            {
                int chk = StrConn.IndexOf("192.168.1.220");

               if (chk > 0 )
                {
                    
                    StrConn = "data source=192.168.10.199; initial catalog=InterfaceBBPrd;Integrated Security=false;User id=sa;Password=Bea@#02";
                }
                else
                {
                    StrConn = "data source=beautyax.dyndns.info; initial catalog=InterfaceBBPrd;Integrated Security=false;User id=sa;Password=Bea@#02";
                }

            }
        }

        private void setstr()
        {
            if (Brand.ToLower() == "bb")
            {
                int chk = StrConn.IndexOf("192.168.10.199");

                if (chk > 0)
                {

                    StrConn = "data source=192.168.1.220; initial catalog=CMD-BX;Integrated Security=false;User id=sa;Password=0211";
                }
                else
                {
                    StrConn = "data source=testmona.homeunix.com; initial catalog=CMD-BX;Integrated Security=false;User id=sa;Password=0211";
                }

            }
        }

        private void tsmDocno_Click(object sender, EventArgs e)
        {
            
            if (lsvReport.SelectedItems[0].SubItems[10].Text != "")
            {
                Clipboard.SetText(lsvReport.SelectedItems[0].SubItems[10].Text);
            }
        }

        private void tsmDNS_Click(object sender, EventArgs e)
        {
            if (lsvReport.SelectedItems[0].SubItems[3].Text != "")
            {
                Clipboard.SetText(lsvReport.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void lsvReport_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = lsvReport.PointToScreen(e.Location);
                tms.Show(pt);
            }
        }

        private void tsmSupport_Click(object sender, EventArgs e)
        {
            using (cWaitIndicator cw = new cWaitIndicator())
            {
                for (int i = 0; i <= lsvReport.SelectedItems.Count - 1; i++)
                {
                    Boolean blwh;
                    blwh = GetSupport(lsvReport.SelectedItems[i].SubItems[3].Text, lsvReport.SelectedItems[i].SubItems[14].Text, DateTime.Parse(lsvReport.SelectedItems[i].SubItems[13].Text));

                    if(blwh)
                    {
                        lsvReport.SelectedItems[i].SubItems[12].Text = "สำเร็จ";
                    }
                    else
                    {
                        lsvReport.SelectedItems[i].SubItems[12].Text = "ไม่สำเร็จ";
                    }
                }
            }
            MessageBox.Show("Completed");
        }

        private void tsmALL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= lsvReport.SelectedItems.Count - 1; i++)
            {
                getstr();
                Boolean blwh;
                blwh = GetALL(lsvReport.SelectedItems[i].SubItems[1].Text, DateTime.Parse(lsvReport.SelectedItems[i].SubItems[13].Text));

                if (blwh)
                {
                    lsvReport.SelectedItems[i].SubItems[12].Text = "สำเร็จ";
                }
                else
                {
                    lsvReport.SelectedItems[i].SubItems[12].Text = "ไม่สำเร็จ";
                }
                setstr();
            }
        }

        private Boolean GetSupport(string _dns,string _wh_id ,DateTime _workdate)
        {
            Boolean bl = false;

            string conn_wh_str = "data source=" + _dns + "; initial catalog=CMD-FX;Integrated Security=false;User id=sa;Password=0000";
            SqlConnection connwh = new SqlConnection(conn_wh_str);
            SqlCommand commwh = new SqlCommand();

            try
            {
                
                string sqlwh = "";
                string dt = getdatesql(_workdate);

                
                if (Brand.ToLower() == "bb")
                {
                    sqlwh = "insert [testmona.homeunix.com].[dbbeautycommsupport].dbo.pos_pt Select *,null as cmd_f from [cmd-fx]..pos_pt where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";
                    sqlwh = sqlwh + " insert [testmona.homeunix.com].[dbbeautycommsupport].dbo.pos_pi  Select * from [cmd-fx]..pos_pi where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";
                    sqlwh = sqlwh + " insert [testmona.homeunix.com].[dbbeautycommsupport].dbo.pos_pt_pr  Select * from [cmd-fx]..pos_pt_pr where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";


                }
                else if (Brand.ToLower() == "bc")
                {
                    sqlwh = "insert [5cosmeda.homeunix.com,1833].[dbbeautycommsupport].dbo.pos_pt Select *,null as cmd_f from [cmd-fx]..pos_pt where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";
                    sqlwh = sqlwh + " insert [5cosmeda.homeunix.com,1833].[dbbeautycommsupport].dbo.pos_pi  Select * from [cmd-fx]..pos_pi where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";
                    sqlwh = sqlwh + " insert [5cosmeda.homeunix.com,1833].[dbbeautycommsupport].dbo.pos_pt_pr  Select * from [cmd-fx]..pos_pt_pr where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";


                }
                else
                {
                    sqlwh = "insert [5cosmeda.homeunix.com,1733].[dbbeautycommsupport].dbo.pos_pt Select *,null as cmd_f from [cmd-fx]..pos_pt where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";
                    sqlwh = sqlwh + " insert [5cosmeda.homeunix.com,1733].[dbbeautycommsupport].dbo.pos_pi  Select * from [cmd-fx]..pos_pi where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";
                    sqlwh = sqlwh + " insert [5cosmeda.homeunix.com,1733].[dbbeautycommsupport].dbo.pos_pt_pr  Select * from [cmd-fx]..pos_pt_pr where wh_id = '" + _wh_id + "' and workdate = '" + dt + "';";


                }


                if (connwh.State == ConnectionState.Closed)
                {
                    connwh.Open();
                }

                commwh.CommandText = sqlwh;
                commwh.Connection = connwh;
                commwh.CommandTimeout = 100000;

                commwh.ExecuteNonQuery();
 
                bl = true;
                connwh.Close();
            }
            catch(Exception ex)
            {
                connwh.Close();
                //MessageBox.Show(ex.Message);
                bl = false;
            }

            return bl;

        }

        private string getdatesql(DateTime _dt)
        {
            string dt;

            dt = _dt.Year + "." + _dt.Month + "." + _dt.Day;

            return dt;
        }

        private Boolean GetALL( string _whcode, DateTime _workdate)
        {
            Boolean bl = false;

            SqlConnection connsr = new SqlConnection(StrConn);
            SqlCommand commsr = new SqlCommand();

            try
            {


                string sqlsr = "";
                string dt = getdatesql(_workdate);

                if (Brand.ToLower() == "bb")
                {
                    sqlsr = "exec [192.168.1.220,1433].[cmd-bx].dbo.PP_CommSupport_2_CMD_wh '" + _whcode + "' ,'" + dt + "' ,'" + dt + "';";
                    sqlsr = sqlsr + " exec bb_interface_sale '" + _whcode + "' ,'" + dt + "' ,'" + dt + "';";

                }
                else if (Brand.ToLower() == "bc")
                {
                    sqlsr = "exec [cmd-bx]..PP_CommSupport_2_CMD_wh '" + _whcode + "' ,'" + dt + "' ,'" + dt + "';";
                    sqlsr = sqlsr + " exec [192.168.10.199].[InterfaceBBPrd].dbo.bc_interface_sale '" + _whcode + "' ,'" + dt + "' ,'" + dt + "';";

                }
                else
                {
                    sqlsr = "exec [cmd-bx]..PP_CommSupport_2_CMD_wh '" + _whcode + "' ,'" + dt + "' ,'" + dt + "';";
                    sqlsr = sqlsr + " exec [192.168.10.199].[InterfaceBBPrd].dbo.bm_interface_sale '" + _whcode + "' ,'" + dt + "' ,'" + dt + "';";

                }


                if (connsr.State == ConnectionState.Closed)
                {
                    connsr.Open();
                }

                commsr.CommandText = sqlsr;
                commsr.Connection = connsr;
                commsr.CommandTimeout = 100000;

                commsr.ExecuteNonQuery();

                bl = true;
                connsr.Close();
            }
            catch (Exception ex)
            {
                connsr.Close();
                bl = false;
            }

            return bl;

        }


    }
}
