using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Docs_for_GSTC
{
    public partial class resultLayout : Form
    {
        private string dbServer, dbName, dbUid, dbPwd, DB_INFO;
        MySqlConnection conn;

        string date;

        void readData()
        {
            Database_set();
            using (conn = new MySqlConnection(DB_INFO))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                try
                {
                    string kangsinho = "SELECT * FROM TEST2 " + "WHERE NAME='kangsinho'";
                    MySqlCommand cmd_ksh = new MySqlCommand(kangsinho, conn);
                    MySqlDataReader rdr_ksh = cmd_ksh.ExecuteReader();

                    while (rdr_ksh.Read())
                    {
                        kangsinho_lasttask.Text += rdr_ksh["LASTWEEK_TASK"].ToString();
                        kangsinho_lasttask_achieve.Text += rdr_ksh["LASTWEEK_TASK_ACHIEVE"].ToString();
                        kangsinho_thistask.Text += rdr_ksh["THISWEEK_TASK"].ToString();
                        kangsinho_thistask_achieve.Text += rdr_ksh["THISWEEK_TASK_ACHIEVE"].ToString(); 
                    }

                    rdr_ksh.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string janghyunyong = "SELECT * FROM TEST2 " + "WHERE NAME='janghyunyong'";
                    MySqlCommand cmd_jhy = new MySqlCommand(janghyunyong, conn);
                    MySqlDataReader rdr_jhy = cmd_jhy.ExecuteReader();

                    while (rdr_jhy.Read())
                    {
                        janghyunyong_lasttask.Text += rdr_jhy["LASTWEEK_TASK"].ToString();
                        janghyunyong_lasttask_achieve.Text += rdr_jhy["LASTWEEK_TASK_ACHIEVE"].ToString();
                        janghyunyong_thistask.Text += rdr_jhy["THISWEEK_TASK"].ToString();
                        janghyunyong_thistask_achieve.Text += rdr_jhy["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_jhy.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string operBusiness = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='운영사업,예산관리'";
                    MySqlCommand cmd_operBusiness = new MySqlCommand(operBusiness, conn);
                    MySqlDataReader rdr_operBusiness = cmd_operBusiness.ExecuteReader();

                    while (rdr_operBusiness.Read())
                    {
                        operBusiness_lasttask.Text += rdr_operBusiness["LASTWEEK_TASK"].ToString();
                        operBusiness_lasttask_achieve.Text += rdr_operBusiness["LASTWEEK_TASK_ACHIEVE"].ToString();
                        operBusiness_thistask.Text += rdr_operBusiness["THISWEEK_TASK"].ToString();
                        operBusiness_thistask_achieve.Text += rdr_operBusiness["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_operBusiness.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string combination = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='조합관리'";
                    MySqlCommand cmd_combination = new MySqlCommand(combination, conn);
                    MySqlDataReader rdr_combination = cmd_combination.ExecuteReader();

                    while (rdr_combination.Read())
                    {
                        combination_lasttask.Text += rdr_combination["LASTWEEK_TASK"].ToString();
                        combination_lasttask_achieve.Text += rdr_combination["LASTWEEK_TASK_ACHIEVE"].ToString();
                        combination_thistask.Text += rdr_combination["THISWEEK_TASK"].ToString();
                        combination_thistask_achieve.Text += rdr_combination["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_combination.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string hr = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='인사관리'";
                    MySqlCommand cmd_hr = new MySqlCommand(hr, conn);
                    MySqlDataReader rdr_hr = cmd_hr.ExecuteReader();

                    while (rdr_hr.Read())
                    {
                        hr_lasttask.Text += rdr_hr["LASTWEEK_TASK"].ToString();
                        hr_lasttask_achieve.Text += rdr_hr["LASTWEEK_TASK_ACHIEVE"].ToString();
                        hr_thistask.Text += rdr_hr["THISWEEK_TASK"].ToString();
                        hr_thistask_achieve.Text += rdr_hr["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_hr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string expHall = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='체험관운영'";
                    MySqlCommand cmd_expHall = new MySqlCommand(expHall, conn);
                    MySqlDataReader rdr_expHall = cmd_expHall.ExecuteReader();

                    while (rdr_expHall.Read())
                    {
                        expHall_lasttask.Text += rdr_expHall["LASTWEEK_TASK"].ToString();
                        expHall_lasttask_achieve.Text += rdr_expHall["LASTWEEK_TASK_ACHIEVE"].ToString();
                        expHall_thistask.Text += rdr_expHall["THISWEEK_TASK"].ToString();
                        expHall_thistask_achieve.Text += rdr_expHall["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_expHall.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string facility = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='시설관리'";
                    MySqlCommand cmd_facility = new MySqlCommand(facility, conn);
                    MySqlDataReader rdr_facility = cmd_facility.ExecuteReader();

                    while (rdr_facility.Read())
                    {
                        facility_lasttask.Text += rdr_facility["LASTWEEK_TASK"].ToString();
                        facility_lasttask_achieve.Text += rdr_facility["LASTWEEK_TASK_ACHIEVE"].ToString();
                        facility_thistask.Text += rdr_facility["THISWEEK_TASK"].ToString();
                        facility_thistask_achieve.Text += rdr_facility["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_facility.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string secure = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='보안관리'";
                    MySqlCommand cmd_secure = new MySqlCommand(secure, conn);
                    MySqlDataReader rdr_secure = cmd_secure.ExecuteReader();

                    while (rdr_secure.Read())
                    {
                        secure_lasttask.Text += rdr_secure["LASTWEEK_TASK"].ToString();
                        secure_lasttask_achieve.Text += rdr_secure["LASTWEEK_TASK_ACHIEVE"].ToString();
                        secure_thistask.Text += rdr_secure["THISWEEK_TASK"].ToString();
                        secure_thistask_achieve.Text += rdr_secure["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_secure.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string usability = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='사용성평가'";
                    MySqlCommand cmd_usability = new MySqlCommand(usability, conn);
                    MySqlDataReader rdr_usability = cmd_usability.ExecuteReader();

                    while (rdr_usability.Read())
                    {
                        usability_lasttask.Text += rdr_usability["LASTWEEK_TASK"].ToString();
                        usability_lasttask_achieve.Text += rdr_usability["LASTWEEK_TASK_ACHIEVE"].ToString();
                        usability_thistask.Text += rdr_usability["THISWEEK_TASK"].ToString();
                        usability_thistask_achieve.Text += rdr_usability["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_usability.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string festival = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='센터행사기획'";
                    MySqlCommand cmd_festival = new MySqlCommand(festival, conn);
                    MySqlDataReader rdr_festival = cmd_festival.ExecuteReader();

                    while (rdr_festival.Read())
                    {
                        festival_lasttask.Text += rdr_festival["LASTWEEK_TASK"].ToString();
                        festival_lasttask_achieve.Text += rdr_festival["LASTWEEK_TASK_ACHIEVE"].ToString();
                        festival_thistask.Text += rdr_festival["THISWEEK_TASK"].ToString();
                        festival_thistask_achieve.Text += rdr_festival["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_festival.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string newBusiness = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='신규사업기획'";
                    MySqlCommand cmd_newBusiness = new MySqlCommand(newBusiness, conn);
                    MySqlDataReader rdr_newBusiness = cmd_newBusiness.ExecuteReader();

                    while (rdr_newBusiness.Read())
                    {
                        newBusiness_lasttask.Text += rdr_newBusiness["LASTWEEK_TASK"].ToString();
                        newBusiness_lasttask_achieve.Text += rdr_newBusiness["LASTWEEK_TASK_ACHIEVE"].ToString();
                        newBusiness_thistask.Text += rdr_newBusiness["THISWEEK_TASK"].ToString();
                        newBusiness_thistask_achieve.Text += rdr_newBusiness["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_newBusiness.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string ad = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='센터홍보'";
                    MySqlCommand cmd_ad = new MySqlCommand(ad, conn);
                    MySqlDataReader rdr_ad = cmd_ad.ExecuteReader();

                    while (rdr_ad.Read())
                    {
                        ad_lasttask.Text += rdr_ad["LASTWEEK_TASK"].ToString();
                        ad_lasttask_achieve.Text += rdr_ad["LASTWEEK_TASK_ACHIEVE"].ToString();
                        ad_thistask.Text += rdr_ad["THISWEEK_TASK"].ToString();
                        ad_thistask_achieve.Text += rdr_ad["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_ad.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string sup = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='센터기업지원'";
                    MySqlCommand cmd_sup = new MySqlCommand(sup, conn);
                    MySqlDataReader rdr_sup = cmd_sup.ExecuteReader();

                    while (rdr_sup.Read())
                    {
                        sup_lasttask.Text += rdr_sup["LASTWEEK_TASK"].ToString();
                        sup_lasttask_achieve.Text += rdr_sup["LASTWEEK_TASK_ACHIEVE"].ToString();
                        sup_thistask.Text += rdr_sup["THISWEEK_TASK"].ToString();
                        sup_thistask_achieve.Text += rdr_sup["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_sup.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string public_ = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='공동활용기업'";
                    MySqlCommand cmd_public = new MySqlCommand(public_, conn);
                    MySqlDataReader rdr_public = cmd_public.ExecuteReader();

                    while (rdr_public.Read())
                    {
                        public_lasttask.Text += rdr_public["LASTWEEK_TASK"].ToString();
                        public_lasttask_achieve.Text += rdr_public["LASTWEEK_TASK_ACHIEVE"].ToString();
                        public_thistask.Text += rdr_public["THISWEEK_TASK"].ToString();
                        public_thistask_achieve.Text += rdr_public["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_public.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string link = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='연계사업1(지역연고)'";
                    MySqlCommand cmd_link = new MySqlCommand(link, conn);
                    MySqlDataReader rdr_link = cmd_link.ExecuteReader();

                    while (rdr_link.Read())
                    {
                        link_lasttask.Text += rdr_link["LASTWEEK_TASK"].ToString();
                        link_lasttask_achieve.Text += rdr_link["LASTWEEK_TASK_ACHIEVE"].ToString();
                        link_thistask.Text += rdr_link["THISWEEK_TASK"].ToString();
                        link_thistask_achieve.Text += rdr_link["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_link.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string develop = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='시스템개발 및 구축'";
                    MySqlCommand cmd_develop = new MySqlCommand(develop, conn);
                    MySqlDataReader rdr_develop = cmd_develop.ExecuteReader();

                    while (rdr_develop.Read())
                    {
                        develop_lasttask.Text += rdr_develop["LASTWEEK_TASK"].ToString();
                        develop_lasttask_achieve.Text += rdr_develop["LASTWEEK_TASK_ACHIEVE"].ToString();
                        develop_thistask.Text += rdr_develop["THISWEEK_TASK"].ToString();
                        develop_thistask_achieve.Text += rdr_develop["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_develop.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string rnd = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='R&D사업기획'";
                    MySqlCommand cmd_rnd = new MySqlCommand(rnd, conn);
                    MySqlDataReader rdr_rnd = cmd_rnd.ExecuteReader();

                    while (rdr_rnd.Read())
                    {
                        rnd_lasttask.Text += rdr_rnd["LASTWEEK_TASK"].ToString();
                        rnd_lasttask_achieve.Text += rdr_rnd["LASTWEEK_TASK_ACHIEVE"].ToString();
                        rnd_thistask.Text += rdr_rnd["THISWEEK_TASK"].ToString();
                        rnd_thistask_achieve.Text += rdr_rnd["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_rnd.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string dataCollection = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='센터\n 데이터확보'";
                    MySqlCommand cmd_dataCollection = new MySqlCommand(dataCollection, conn);
                    MySqlDataReader rdr_dataCollection = cmd_dataCollection.ExecuteReader();

                    while (rdr_dataCollection.Read())
                    {
                        dataCollection_lasttask.Text += rdr_dataCollection["LASTWEEK_TASK"].ToString();
                        dataCollection_lasttask_achieve.Text += rdr_dataCollection["LASTWEEK_TASK_ACHIEVE"].ToString();
                        dataCollection_thistask.Text += rdr_dataCollection["THISWEEK_TASK"].ToString();
                        dataCollection_thistask_achieve.Text += rdr_dataCollection["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_dataCollection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                try
                {
                    string assets = "SELECT * FROM TEST2 " + "WHERE TASK_NAME='자산운용/관리'";
                    MySqlCommand cmd_assets = new MySqlCommand(assets, conn);
                    MySqlDataReader rdr_assets = cmd_assets.ExecuteReader();

                    while (rdr_assets.Read())
                    {
                        assets_lasttask.Text += rdr_assets["LASTWEEK_TASK"].ToString();
                        assets_lasttask_achieve.Text += rdr_assets["LASTWEEK_TASK_ACHIEVE"].ToString();
                        assets_thistask.Text += rdr_assets["THISWEEK_TASK"].ToString();
                        assets_thistask_achieve.Text += rdr_assets["THISWEEK_TASK_ACHIEVE"].ToString();
                    }

                    rdr_assets.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
            }
            conn.Close();
        }

        private void Database_set()
        {
            dbName = "WEEK_TASK";
            dbServer = "localhost";
            dbUid = "devLupin";
            dbPwd = "lht1080";

            DB_INFO = "Data Source=" + dbServer + ";" + "Database=" + dbName + ";" + "User ID=" + dbUid + ";" + "Password=" + dbPwd + ";" +
                "charset=euckr;";
        }

        public resultLayout(string date)
        {
            //this.date = date;
            //date_lbl.Text = this.date;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            readData();
        }
    }
}
