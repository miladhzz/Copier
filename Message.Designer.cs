namespace Copier
{
    partial class Message
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
            this.BtnCancell = new System.Windows.Forms.Button();
            this.BtnNoToAll = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnYestToAll = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancell
            // 
            this.BtnCancell.Location = new System.Drawing.Point(361, 95);
            this.BtnCancell.Name = "BtnCancell";
            this.BtnCancell.Size = new System.Drawing.Size(75, 23);
            this.BtnCancell.TabIndex = 0;
            this.BtnCancell.Text = "Cancel";
            this.BtnCancell.UseVisualStyleBackColor = true;
            this.BtnCancell.Click += new System.EventHandler(this.BtnCancell_Click);
            // 
            // BtnNoToAll
            // 
            this.BtnNoToAll.Location = new System.Drawing.Point(280, 95);
            this.BtnNoToAll.Name = "BtnNoToAll";
            this.BtnNoToAll.Size = new System.Drawing.Size(75, 23);
            this.BtnNoToAll.TabIndex = 1;
            this.BtnNoToAll.Text = "No to all";
            this.BtnNoToAll.UseVisualStyleBackColor = true;
            this.BtnNoToAll.Click += new System.EventHandler(this.BtnNoToAll_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.Location = new System.Drawing.Point(199, 95);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(75, 23);
            this.BtnNo.TabIndex = 2;
            this.BtnNo.Text = "No";
            this.BtnNo.UseVisualStyleBackColor = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // BtnYestToAll
            // 
            this.BtnYestToAll.Location = new System.Drawing.Point(118, 95);
            this.BtnYestToAll.Name = "BtnYestToAll";
            this.BtnYestToAll.Size = new System.Drawing.Size(75, 23);
            this.BtnYestToAll.TabIndex = 3;
            this.BtnYestToAll.Text = "Yes to all";
            this.BtnYestToAll.UseVisualStyleBackColor = true;
            this.BtnYestToAll.Click += new System.EventHandler(this.BtnYestToAll_Click);
            // 
            // BtnYes
            // 
            this.BtnYes.Location = new System.Drawing.Point(37, 95);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(75, 23);
            this.BtnYes.TabIndex = 4;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseVisualStyleBackColor = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.BtnYestToAll);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnNoToAll);
            this.Controls.Add(this.BtnCancell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancell;
        private System.Windows.Forms.Button BtnNoToAll;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Button BtnYestToAll;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Label label1;
    }
}