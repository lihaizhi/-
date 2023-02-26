namespace 医院门诊
{
    partial class paitentinfornation
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
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxm = new System.Windows.Forms.TextBox();
            this.btnxiugai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "性别：";
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(194, 30);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(43, 19);
            this.rdbmale.TabIndex = 1;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "男";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Location = new System.Drawing.Point(255, 30);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(43, 19);
            this.rdbfemale.TabIndex = 2;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "女";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "电话：";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(194, 81);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(138, 25);
            this.txtphone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "姓名：";
            // 
            // txtxm
            // 
            this.txtxm.Location = new System.Drawing.Point(194, 143);
            this.txtxm.Name = "txtxm";
            this.txtxm.Size = new System.Drawing.Size(138, 25);
            this.txtxm.TabIndex = 6;
            // 
            // btnxiugai
            // 
            this.btnxiugai.Location = new System.Drawing.Point(223, 248);
            this.btnxiugai.Name = "btnxiugai";
            this.btnxiugai.Size = new System.Drawing.Size(75, 50);
            this.btnxiugai.TabIndex = 7;
            this.btnxiugai.Text = "修改信息";
            this.btnxiugai.UseVisualStyleBackColor = true;
            this.btnxiugai.Click += new System.EventHandler(this.btnxiugai_Click);
            // 
            // paitentinfornation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxiugai);
            this.Controls.Add(this.txtxm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbfemale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.label1);
            this.Name = "paitentinfornation";
            this.Text = "患者个人基本信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxm;
        private System.Windows.Forms.Button btnxiugai;
    }
}