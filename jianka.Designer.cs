namespace 医院门诊
{
    partial class jianka
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnjiaka = new System.Windows.Forms.Button();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.rdbfamale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(229, 113);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(108, 25);
            this.txtname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "电话号码：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(229, 185);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(108, 25);
            this.txtphone.TabIndex = 6;
            // 
            // btnjiaka
            // 
            this.btnjiaka.Location = new System.Drawing.Point(229, 279);
            this.btnjiaka.Name = "btnjiaka";
            this.btnjiaka.Size = new System.Drawing.Size(75, 23);
            this.btnjiaka.TabIndex = 7;
            this.btnjiaka.Text = "建卡";
            this.btnjiaka.UseVisualStyleBackColor = true;
            this.btnjiaka.Click += new System.EventHandler(this.btnjiaka_Click);
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(229, 46);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(43, 19);
            this.rdbmale.TabIndex = 8;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "男";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // rdbfamale
            // 
            this.rdbfamale.AutoSize = true;
            this.rdbfamale.Location = new System.Drawing.Point(294, 46);
            this.rdbfamale.Name = "rdbfamale";
            this.rdbfamale.Size = new System.Drawing.Size(43, 19);
            this.rdbfamale.TabIndex = 9;
            this.rdbfamale.TabStop = true;
            this.rdbfamale.Text = "女";
            this.rdbfamale.UseVisualStyleBackColor = true;
            // 
            // jianka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbfamale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.btnjiaka);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "jianka";
            this.Text = "患者建卡";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnjiaka;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.RadioButton rdbfamale;
    }
}