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
    public partial class typingLayout : Form
    {
        private string dbServer, dbName, dbUid, dbPwd, DB_INFO;
        MySqlConnection conn;

        string[][] taskList = new string[11][]
        {
            new string[] { "kangsinho", "강신호 본부장" },
            new string[] { "janghyunyong", "장현용 수석팀장" },

            new string[] { "leeguwon", "조합관리", "인사관리" },
            new string[] { "leejihwi", "운영사업,예산관리", "센터행사기획" },
            new string[] { "jidosung", "체험관운영", "보안관리", "사용성평가" },
            new string[] { "jungkukhwan", "시설관리" },

            new string[] { "choihwimin", "신규사업기획", "센터홍보" },
            new string[] { "seolhyungho", "센터기업지원", "공동활용기업" },
            new string[] { "kimbora", "연계사업1(지역연고)" },

            new string[] { "kimchangseok", "R&D사업기획", "센터\n 데이터확보" },
            new string[] { "limhyuntaek", "시스템개발 및 구축", "자산운용/관리" }
        };

        string userName;
        int node = -1;
        DateTime now;

        public typingLayout(string curUser)
        {
            InitializeComponent();
            
            now = DateTime.Now;
            string access_date = now.ToString("yyyy-MM-dd H:mm:ss");

            // Current user setting
            for (int i = 0; i < 11; i++)
            {
                if (taskList[i][0].Equals(curUser))
                {
                    userName = curUser;
                    node = i;
                    break;
                }
            }
            // Add items
            for (int i = 1; i < taskList[node].Length; i++)
            {
                selectTask.Items.Add(taskList[node][i]);
            }

            accessTime.Text = "접속 시간 : " + access_date;

            dbServer = "localhost";
            dbUid = "devLupin";
            dbPwd = "lht1080";
        }

        private void update_Click(object sender, EventArgs e)
        {
            string cur_task = "";
            bool chk = false;
            for(int i=1; i< taskList[node].Length; i++)
            {
                if (taskList[node][i].Equals(selectTask.Text))
                {
                    cur_task = selectTask.Text;
                    chk = true;
                }
            }

            if (chk) {
                if (MessageBox.Show("적용하시겠습니까?\n" +
                    "항상 최신의 데이터만 저장됩니다.", "",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Database_set_INSERT();
                    using (conn = new MySqlConnection(DB_INFO))
                    {
                        conn.Open();
                        try
                        {
                            string sql = "CREATE TABLE IF NOT EXISTS " + "TEST2" + "(" +
                                "NAME VARCHAR(30) NOT NULL, " +
                                "TASK_NAME VARCHAR(50) NOT NULL, " + 
                                "LASTWEEK_TASK VARCHAR(500) NOT NULL, " +
                                "LASTWEEK_TASK_ACHIEVE VARCHAR(500) NOT NULL, " +
                                "THISWEEK_TASK VARCHAR(500) NOT NULL, " +
                                "THISWEEK_TASK_ACHIEVE VARCHAR(500) NOT NULL, " +
                                "SAVE_DATE DATE PRIMARY KEY NOT NULL" +
                                ")";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("CREATE TABLE IF NOT EXISTS error!");
                            MessageBox.Show(ex.Message);
                            MessageBox.Show(ex.StackTrace);
                        }
                        try
                        {
                            string save_date = now.ToString("yyyy-MM-dd");
                            string sql = "INSERT INTO " + "TEST2" + " VALUES(" +
                                "'" + userName + "'," +
                                "'" + selectTask.Text + "'," +
                                "'" + lastWeekTask.Text + "'," +
                                "'" + lastWeekTaskAchievement.Text + "'," +
                                "'" + thisWeekTask.Text + "'," +
                                "'" + thisWeekTaskAchievement.Text + "'," +
                                "'" + save_date + "'" +
                                ")" +
                                "ON DUPLICATE KEY UPDATE " +
                                "LASTWEEK_TASK = " + "'" + lastWeekTask.Text + "'," +
                                "LASTWEEK_TASK_ACHIEVE = " + "'" + lastWeekTaskAchievement.Text + "'," +
                                "THISWEEK_TASK = " + "'" + lastWeekTask.Text + "'," +
                                "THISWEEK_TASK_ACHIEVE = " + "'" + lastWeekTaskAchievement.Text + "'";

                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("INSERT INTO cur_task VALUES error!");
                            MessageBox.Show(ex.Message);
                            MessageBox.Show(ex.StackTrace);
                        }
                    }
                    conn.Close();
                    MessageBox.Show("저장되었습니다!");
                }
            }
            else
            {
                MessageBox.Show("업무를 선택해주세요!");
            }
        }

        private void Database_set_INSERT()
        {
            dbName = "WEEK_TASK";

            DB_INFO = "Data Source=" + dbServer + ";" + "Database=" + dbName + ";" + "User ID=" + dbUid + ";" + "Password=" + dbPwd + ";" +
                "charset=euckr;";
        }
    }
}
