using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docs_for_GSTC
{
    public partial class startLayout : Form
    {
        string[] operationHQ = { "강신호", "장현용" };
        string[] managementOperation = { "정국환", "지도성", "이구원", "이지희" };
        string[] planningStrategy = { "설형호", "김보라", "최휘민", "신규1", "신규2", "신규3" };
        string[] AIRnD = { "김창석", "임현택" };
        string[] HRNurture = { "홍남표", "신규인력" };

        string[] operationHQ_eng = { "kangsinho", "janghyunyong" };
        string[] managementOperation_eng = { "jungkukhwan", "jidosung", "leeguwon", "leejihwi" };
        string[] planningStrategy_eng = { "seolhyungho", "kimbora", "choihwimin" };
        string[] AIRnD_eng = { "kimchangseok", "limhyuntaek" };
        string[] HRNurture_eng = { "hongnampyo" };

        bool chk = true;

        DateTime now;

        public startLayout()
        {
            InitializeComponent();

            for(int i=0; i<operationHQ.Length; i++)
            {
                operationHQTeam.Items.Add(operationHQ[i]);
            }
            for(int i=0; i<managementOperation.Length; i++)
            {
                managementOperationTeam.Items.Add(managementOperation[i]);
            }
            for (int i = 0; i < planningStrategy.Length; i++)
            {
                planningStrategyTeam.Items.Add(planningStrategy[i]);
            }
            for (int i = 0; i < AIRnD.Length; i++)
            {
                AIRnDTeam.Items.Add(AIRnD[i]);
            }
            for (int i = 0; i < HRNurture.Length; i++)
            {
                HRNurtureTeam.Items.Add(HRNurture[i]);
            }

            now = DateTime.Now;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (operationHQTeam.Text.Equals("운영본부") && managementOperationTeam.Text.Equals("관리운영팀") && planningStrategyTeam.Text.Equals("기획전략팀") &&
                AIRnDTeam.Text.Equals("인공지능R&D팀") && HRNurtureTeam.Text.Equals("인력양성팀"))
                MessageBox.Show("팀을 선택해주세요!");

            if (!operationHQTeam.Text.Equals("운영본부"))
            {
                if (MessageBox.Show(operationHQTeam.Text + "님이 맞습니까? 본인이 아닐경우 아니요를 눌러주세요.", "",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int node = -1;
                    for(int i=0; i<operationHQ.Length; i++)
                    {
                        if (operationHQ[i].Equals(operationHQTeam.Text))
                        {
                            node = i;
                            break;
                        }
                    }                

                    typingLayout typing = new typingLayout(operationHQ_eng[node]);
                    typing.Show();
                }
                else
                {
                    chk = false;
                    titleInit();
                }
            }
            if (!managementOperationTeam.Text.Equals("관리운영팀"))
            {
                if (MessageBox.Show(managementOperationTeam.Text + "님이 맞습니까? 본인이 아닐경우 아니요를 눌러주세요.", "",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int node = -1;
                    for (int i = 0; i < managementOperation.Length; i++)
                    {
                        if (managementOperation[i].Equals(managementOperationTeam.Text))
                        {
                            node = i;
                            break;
                        }
                    }

                    typingLayout typing = new typingLayout(managementOperation_eng[node]);
                    typing.Show();
                }
                else
                {
                    chk = false;
                    titleInit();
                }
            }
            if (!planningStrategyTeam.Text.Equals("기획전략팀"))
            {
                if (MessageBox.Show(planningStrategyTeam.Text + "님이 맞습니까? 본인이 아닐경우 아니요를 눌러주세요.", "",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int node = -1;
                    for (int i = 0; i < planningStrategy.Length; i++)
                    {
                        if (planningStrategy[i].Equals(planningStrategyTeam.Text))
                        {
                            node = i;
                            break;
                        }
                    }

                    typingLayout typing = new typingLayout(planningStrategy_eng[node]);
                    typing.Show();
                }
                else
                {
                    chk = false;
                    titleInit();
                }
            }
            if (!AIRnDTeam.Text.Equals("인공지능R&D팀"))
            {
                if (MessageBox.Show(AIRnDTeam.Text + "님이 맞습니까? 본인이 아닐경우 아니요를 눌러주세요.", "",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int node = -1;
                    for (int i = 0; i < AIRnD.Length; i++)
                    {
                        if (AIRnD[i].Equals(AIRnDTeam.Text))
                        {
                            node = i;
                            break;
                        }
                    }

                    typingLayout typing = new typingLayout(AIRnD_eng[node]);
                    typing.Show();
                }
                else
                {
                    chk = false;
                }
            }
            if (!HRNurtureTeam.Text.Equals("인력양성팀"))
            {
                if (MessageBox.Show(HRNurtureTeam.Text + "님이 맞습니까? 본인이 아닐경우 아니요를 눌러주세요.", "",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int node = -1;
                    for (int i = 0; i < HRNurture.Length; i++)
                    {
                        if (HRNurture[i].Equals(HRNurtureTeam.Text))
                        {
                            node = i;
                            break;
                        }
                    }

                    typingLayout typing = new typingLayout(HRNurture_eng[node]);
                    typing.Show();
                }
                else
                {
                    chk = false;
                    titleInit();
                }
            }
        }

        private void titleInit()
        {
            operationHQTeam.Text = "운영본부";
            managementOperationTeam.Text = "관리운영팀";
            planningStrategyTeam.Text = "기획전략팀";
            AIRnDTeam.Text = "인공지능R&D팀";
            HRNurtureTeam.Text = "인력양성팀";

            operationHQTeam.Refresh();
            managementOperationTeam.Refresh();
            planningStrategyTeam.Refresh();
            AIRnDTeam.Refresh();
            HRNurtureTeam.Refresh();

            chk = true;
        }

        private void namereset_btn_Click(object sender, EventArgs e)
        {
            titleInit();
        }

        private void all_task_btn_Click(object sender, EventArgs e)
        {
            string date = now.ToString("yyyy-MM-dd");

            resultLayout result = new resultLayout(date);
            result.Show();
        }
    }
}
