namespace 医院门诊
{
    partial class Phymanagersdenglu
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
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtmima = new System.Windows.Forms.TextBox();
            this.btndenglu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(221, 130);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 25);
            this.txtno.TabIndex = 2;
            // 
            // txtmima
            // 
            this.txtmima.Location = new System.Drawing.Point(221, 190);
            this.txtmima.Name = "txtmima";
            this.txtmima.Size = new System.Drawing.Size(100, 25);
            this.txtmima.TabIndex = 3;
            // 
            // btndenglu
            // 
            this.btndenglu.Location = new System.Drawing.Point(209, 269);
            this.btndenglu.Name = "btndenglu";
            this.btndenglu.Size = new System.Drawing.Size(112, 36);
            this.btndenglu.TabIndex = 4;
            this.btndenglu.Text = "登录";
            this.btndenglu.UseVisualStyleBackColor = true;
            this.btndenglu.Click += new System.EventHandler(this.btndenglu_Click);
            // 
            // Phymanagersdenglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndenglu);
            this.Controls.Add(this.txtmima);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Phymanagersdenglu";
            this.Text = "药房管理者登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtmima;
        private System.Windows.Forms.Button btndenglu;
    }
}