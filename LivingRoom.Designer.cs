namespace MillSuppoter
{
    partial class LivingRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBHum = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "온도";
            // 
            // LBTemp
            // 
            this.LBTemp.AutoSize = true;
            this.LBTemp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBTemp.Location = new System.Drawing.Point(73, 9);
            this.LBTemp.Name = "LBTemp";
            this.LBTemp.Size = new System.Drawing.Size(24, 16);
            this.LBTemp.TabIndex = 1;
            this.LBTemp.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "습도";
            // 
            // LBHum
            // 
            this.LBHum.AutoSize = true;
            this.LBHum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBHum.Location = new System.Drawing.Point(73, 36);
            this.LBHum.Name = "LBHum";
            this.LBHum.Size = new System.Drawing.Size(24, 16);
            this.LBHum.TabIndex = 1;
            this.LBHum.Text = "00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(281, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LivingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 362);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LBHum);
            this.Controls.Add(this.LBTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "LivingRoom";
            this.Text = "생활관";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBHum;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}