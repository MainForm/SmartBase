namespace MillSuppoter
{
    partial class MainForm
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
            this.아두이노연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아두이노연결AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LBToilet = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 아두이노연결ToolStripMenuItem
            // 
            this.아두이노연결ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.아두이노연결AToolStripMenuItem});
            this.아두이노연결ToolStripMenuItem.Name = "아두이노연결ToolStripMenuItem";
            this.아두이노연결ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.아두이노연결ToolStripMenuItem.Text = "메뉴(&M)";
            // 
            // 아두이노연결AToolStripMenuItem
            // 
            this.아두이노연결AToolStripMenuItem.Name = "아두이노연결AToolStripMenuItem";
            this.아두이노연결AToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.아두이노연결AToolStripMenuItem.Text = "아두이노 연결(&A)";
            this.아두이노연결AToolStripMenuItem.Click += new System.EventHandler(this.아두이노연결AToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.아두이노연결ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 92);
            this.button2.TabIndex = 2;
            this.button2.Text = "1생활관";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LBToilet);
            this.panel1.Location = new System.Drawing.Point(335, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 104);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(85, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "화장실";
            // 
            // LBToilet
            // 
            this.LBToilet.AutoSize = true;
            this.LBToilet.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBToilet.Location = new System.Drawing.Point(98, 20);
            this.LBToilet.Name = "LBToilet";
            this.LBToilet.Size = new System.Drawing.Size(129, 64);
            this.LBToilet.TabIndex = 0;
            this.LBToilet.Text = "0/5";
            this.LBToilet.Click += new System.EventHandler(this.panel1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "스마트 병영";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem 아두이노연결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 아두이노연결AToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBToilet;
        private System.Windows.Forms.Label label2;
    }
}

