namespace Exam2EC
{
    partial class Form1
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
            this.codeLbl = new System.Windows.Forms.Label();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.outputNameLbl = new System.Windows.Forms.Label();
            this.findNameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(14, 16);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(102, 13);
            this.codeLbl.TabIndex = 0;
            this.codeLbl.Text = "Enter Country Code:";
            // 
            // codeTxt
            // 
            this.codeTxt.Location = new System.Drawing.Point(122, 13);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(100, 20);
            this.codeTxt.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(39, 46);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(77, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Country Name:";
            // 
            // outputNameLbl
            // 
            this.outputNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputNameLbl.Location = new System.Drawing.Point(122, 45);
            this.outputNameLbl.Name = "outputNameLbl";
            this.outputNameLbl.Size = new System.Drawing.Size(100, 20);
            this.outputNameLbl.TabIndex = 3;
            // 
            // findNameBtn
            // 
            this.findNameBtn.Location = new System.Drawing.Point(105, 76);
            this.findNameBtn.Name = "findNameBtn";
            this.findNameBtn.Size = new System.Drawing.Size(75, 23);
            this.findNameBtn.TabIndex = 4;
            this.findNameBtn.Text = "Find Name";
            this.findNameBtn.UseVisualStyleBackColor = true;
            this.findNameBtn.Click += new System.EventHandler(this.findNameBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.findNameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.findNameBtn);
            this.Controls.Add(this.outputNameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.codeLbl);
            this.Name = "Form1";
            this.Text = "Exam 2 EC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label outputNameLbl;
        private System.Windows.Forms.Button findNameBtn;
    }
}

