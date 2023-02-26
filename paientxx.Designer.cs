namespace 医院门诊
{
    partial class paientxx
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
            this.labxm = new System.Windows.Forms.Label();
            this.btnzhuxiao = new System.Windows.Forms.Button();
            this.btnguahao = new System.Windows.Forms.Button();
            this.btngeirxx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labxm
            // 
            this.labxm.AutoSize = true;
            this.labxm.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labxm.Location = new System.Drawing.Point(262, 24);
            this.labxm.Name = "labxm";
            this.labxm.Size = new System.Drawing.Size(0, 33);
            this.labxm.TabIndex = 0;
            // 
            // btnzhuxiao
            // 
            this.btnzhuxiao.Location = new System.Drawing.Point(487, 24);
            this.btnzhuxiao.Name = "btnzhuxiao";
            this.btnzhuxiao.Size = new System.Drawing.Size(125, 33);
            this.btnzhuxiao.TabIndex = 1;
            this.btnzhuxiao.Text = "注销";
            this.btnzhuxiao.UseVisualStyleBackColor = true;
            this.btnzhuxiao.Click += new System.EventHandler(this.btnzhuxiao_Click);
            // 
            // btnguahao
            // 
            this.btnguahao.Location = new System.Drawing.Point(107, 282);
            this.btnguahao.Name = "btnguahao";
            this.btnguahao.Size = new System.Drawing.Size(99, 89);
            this.btnguahao.TabIndex = 2;
            this.btnguahao.Text = "挂号预约";
            this.btnguahao.UseVisualStyleBackColor = true;
            this.btnguahao.Click += new System.EventHandler(this.btnguahao_Click);
            // 
            // btngeirxx
            // 
            this.btngeirxx.Location = new System.Drawing.Point(107, 128);
            this.btngeirxx.Name = "btngeirxx";
            this.btngeirxx.Size = new System.Drawing.Size(99, 93);
            this.btngeirxx.TabIndex = 3;
            this.btngeirxx.Text = "个人中心";
            this.btngeirxx.UseVisualStyleBackColor = true;
            this.btngeirxx.Click += new System.EventHandler(this.btngeirxx_Click);
            // 
            // paientxx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngeirxx);
            this.Controls.Add(this.btnguahao);
            this.Controls.Add(this.btnzhuxiao);
            this.Controls.Add(this.labxm);
            this.Name = "paientxx";
            this.Text = "医院门诊系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labxm;
        private System.Windows.Forms.Button btnzhuxiao;
        private System.Windows.Forms.Button btnguahao;
        private System.Windows.Forms.Button btngeirxx;
    }
}