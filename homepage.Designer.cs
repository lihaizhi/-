namespace 医院门诊
{
    partial class homepage
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
            this.btndoctor = new System.Windows.Forms.Button();
            this.btnpillmanage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpatientno = new System.Windows.Forms.TextBox();
            this.btnguahao = new System.Windows.Forms.Button();
            this.btnjiangka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndoctor
            // 
            this.btndoctor.Location = new System.Drawing.Point(96, 243);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(210, 154);
            this.btndoctor.TabIndex = 0;
            this.btndoctor.Text = "我是医生";
            this.btndoctor.UseVisualStyleBackColor = true;
            this.btndoctor.Click += new System.EventHandler(this.btndoctor_Click);
            // 
            // btnpillmanage
            // 
            this.btnpillmanage.Location = new System.Drawing.Point(818, 243);
            this.btnpillmanage.Name = "btnpillmanage";
            this.btnpillmanage.Size = new System.Drawing.Size(219, 154);
            this.btnpillmanage.TabIndex = 1;
            this.btnpillmanage.Text = "我是药品管理者";
            this.btnpillmanage.UseVisualStyleBackColor = true;
            this.btnpillmanage.Click += new System.EventHandler(this.btnpillmanage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "患者卡号：";
            // 
            // txtpatientno
            // 
            this.txtpatientno.Location = new System.Drawing.Point(455, 161);
            this.txtpatientno.Name = "txtpatientno";
            this.txtpatientno.Size = new System.Drawing.Size(208, 25);
            this.txtpatientno.TabIndex = 3;
            // 
            // btnguahao
            // 
            this.btnguahao.Location = new System.Drawing.Point(455, 217);
            this.btnguahao.Name = "btnguahao";
            this.btnguahao.Size = new System.Drawing.Size(208, 70);
            this.btnguahao.TabIndex = 4;
            this.btnguahao.Text = "进入门诊系统";
            this.btnguahao.UseVisualStyleBackColor = true;
            this.btnguahao.Click += new System.EventHandler(this.btnguahao_Click);
            // 
            // btnjiangka
            // 
            this.btnjiangka.Location = new System.Drawing.Point(455, 323);
            this.btnjiangka.Name = "btnjiangka";
            this.btnjiangka.Size = new System.Drawing.Size(208, 93);
            this.btnjiangka.TabIndex = 5;
            this.btnjiangka.Text = "还未建卡？";
            this.btnjiangka.UseVisualStyleBackColor = true;
            this.btnjiangka.Click += new System.EventHandler(this.btnjiangka_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 555);
            this.Controls.Add(this.btnjiangka);
            this.Controls.Add(this.btnguahao);
            this.Controls.Add(this.txtpatientno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpillmanage);
            this.Controls.Add(this.btndoctor);
            this.Name = "homepage";
            this.Text = "医院首页";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndoctor;
        private System.Windows.Forms.Button btnpillmanage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpatientno;
        private System.Windows.Forms.Button btnguahao;
        private System.Windows.Forms.Button btnjiangka;
    }
}