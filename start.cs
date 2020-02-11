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

        string[] operationHQ_temp = {}

        string[][] taskList = new string[9][]
        {
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

        bool chk = true;

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
                    typingLayout typing = new typingLayout(operationHQTeam.Text);
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
                    typingLayout typing = new typingLayout(managementOperationTeam.Text);
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
                    typingLayout typing = new typingLayout(planningStrategyTeam.Text);
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
                    typingLayout typing = new typingLayout(AIRnDTeam.Text);
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
                    typingLayout typing = new typingLayout(HRNurtureTeam.Text);
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

            chk = true;
        }
    }
}
