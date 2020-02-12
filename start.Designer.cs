namespace Docs_for_GSTC
{
    partial class startLayout
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectTeam_lbl = new System.Windows.Forms.Label();
            this.managementOperationTeam = new System.Windows.Forms.ComboBox();
            this.planningStrategyTeam = new System.Windows.Forms.ComboBox();
            this.AIRnDTeam = new System.Windows.Forms.ComboBox();
            this.HRNurtureTeam = new System.Windows.Forms.ComboBox();
            this.explain_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.operationHQTeam = new System.Windows.Forms.ComboBox();
            this.namereset_btn = new System.Windows.Forms.Button();
            this.all_task_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectTeam_lbl
            // 
            this.selectTeam_lbl.AutoSize = true;
            this.selectTeam_lbl.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectTeam_lbl.Location = new System.Drawing.Point(78, 145);
            this.selectTeam_lbl.Name = "selectTeam_lbl";
            this.selectTeam_lbl.Size = new System.Drawing.Size(84, 22);
            this.selectTeam_lbl.TabIndex = 0;
            this.selectTeam_lbl.Text = "팀 선택";
            // 
            // managementOperationTeam
            // 
            this.managementOperationTeam.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.managementOperationTeam.FormattingEnabled = true;
            this.managementOperationTeam.Location = new System.Drawing.Point(186, 179);
            this.managementOperationTeam.Name = "managementOperationTeam";
            this.managementOperationTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.managementOperationTeam.Size = new System.Drawing.Size(205, 33);
            this.managementOperationTeam.TabIndex = 1;
            this.managementOperationTeam.Text = "관리운영팀";
            // 
            // planningStrategyTeam
            // 
            this.planningStrategyTeam.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.planningStrategyTeam.FormattingEnabled = true;
            this.planningStrategyTeam.Location = new System.Drawing.Point(186, 218);
            this.planningStrategyTeam.Name = "planningStrategyTeam";
            this.planningStrategyTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.planningStrategyTeam.Size = new System.Drawing.Size(205, 33);
            this.planningStrategyTeam.TabIndex = 2;
            this.planningStrategyTeam.Text = "기획전략팀";
            // 
            // AIRnDTeam
            // 
            this.AIRnDTeam.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AIRnDTeam.FormattingEnabled = true;
            this.AIRnDTeam.Location = new System.Drawing.Point(186, 257);
            this.AIRnDTeam.Name = "AIRnDTeam";
            this.AIRnDTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AIRnDTeam.Size = new System.Drawing.Size(205, 33);
            this.AIRnDTeam.TabIndex = 3;
            this.AIRnDTeam.Text = "인공지능R&D팀";
            // 
            // HRNurtureTeam
            // 
            this.HRNurtureTeam.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HRNurtureTeam.FormattingEnabled = true;
            this.HRNurtureTeam.Location = new System.Drawing.Point(186, 296);
            this.HRNurtureTeam.Name = "HRNurtureTeam";
            this.HRNurtureTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HRNurtureTeam.Size = new System.Drawing.Size(205, 33);
            this.HRNurtureTeam.TabIndex = 4;
            this.HRNurtureTeam.Text = "인력양성팀";
            // 
            // explain_lbl
            // 
            this.explain_lbl.AutoSize = true;
            this.explain_lbl.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explain_lbl.Location = new System.Drawing.Point(78, 55);
            this.explain_lbl.Name = "explain_lbl";
            this.explain_lbl.Size = new System.Drawing.Size(359, 57);
            this.explain_lbl.TabIndex = 5;
            this.explain_lbl.Text = "자신의 이름을 찾아 팀을 선택해주세요.\r\n\r\n중복 선택은 오류를 발생시킵니다.";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_btn.Location = new System.Drawing.Point(562, 345);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(226, 93);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // operationHQTeam
            // 
            this.operationHQTeam.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.operationHQTeam.FormattingEnabled = true;
            this.operationHQTeam.Location = new System.Drawing.Point(186, 139);
            this.operationHQTeam.Name = "operationHQTeam";
            this.operationHQTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.operationHQTeam.Size = new System.Drawing.Size(205, 33);
            this.operationHQTeam.TabIndex = 7;
            this.operationHQTeam.Text = "운영본부";
            // 
            // namereset_btn
            // 
            this.namereset_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.namereset_btn.Location = new System.Drawing.Point(186, 361);
            this.namereset_btn.Name = "namereset_btn";
            this.namereset_btn.Size = new System.Drawing.Size(205, 60);
            this.namereset_btn.TabIndex = 8;
            this.namereset_btn.Text = "이름 초기화";
            this.namereset_btn.UseVisualStyleBackColor = true;
            this.namereset_btn.Click += new System.EventHandler(this.namereset_btn_Click);
            // 
            // all_task_btn
            // 
            this.all_task_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.all_task_btn.Location = new System.Drawing.Point(538, 79);
            this.all_task_btn.Name = "all_task_btn";
            this.all_task_btn.Size = new System.Drawing.Size(250, 133);
            this.all_task_btn.TabIndex = 9;
            this.all_task_btn.Text = "전체 업무 보기";
            this.all_task_btn.UseVisualStyleBackColor = true;
            this.all_task_btn.Click += new System.EventHandler(this.all_task_btn_Click);
            // 
            // startLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.all_task_btn);
            this.Controls.Add(this.namereset_btn);
            this.Controls.Add(this.operationHQTeam);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.explain_lbl);
            this.Controls.Add(this.HRNurtureTeam);
            this.Controls.Add(this.AIRnDTeam);
            this.Controls.Add(this.planningStrategyTeam);
            this.Controls.Add(this.managementOperationTeam);
            this.Controls.Add(this.selectTeam_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "startLayout";
            this.Text = "GSTC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectTeam_lbl;
        private System.Windows.Forms.ComboBox managementOperationTeam;
        private System.Windows.Forms.ComboBox planningStrategyTeam;
        private System.Windows.Forms.ComboBox AIRnDTeam;
        private System.Windows.Forms.ComboBox HRNurtureTeam;
        private System.Windows.Forms.Label explain_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.ComboBox operationHQTeam;
        private System.Windows.Forms.Button namereset_btn;
        private System.Windows.Forms.Button all_task_btn;
    }
}

