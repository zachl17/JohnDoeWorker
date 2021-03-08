namespace JohnDoeWorker
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
            this.lblRemainingTotalCount = new System.Windows.Forms.Label();
            this.lblRemainingTotal = new System.Windows.Forms.Label();
            this.txtActionDate = new System.Windows.Forms.TextBox();
            this.lblActionDate = new System.Windows.Forms.Label();
            this.txtDebtor = new System.Windows.Forms.TextBox();
            this.lblDebtor = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRemainingTotalCount
            // 
            this.lblRemainingTotalCount.AutoSize = true;
            this.lblRemainingTotalCount.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblRemainingTotalCount.Location = new System.Drawing.Point(453, 336);
            this.lblRemainingTotalCount.Name = "lblRemainingTotalCount";
            this.lblRemainingTotalCount.Size = new System.Drawing.Size(0, 31);
            this.lblRemainingTotalCount.TabIndex = 13;
            // 
            // lblRemainingTotal
            // 
            this.lblRemainingTotal.AutoSize = true;
            this.lblRemainingTotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblRemainingTotal.Location = new System.Drawing.Point(233, 336);
            this.lblRemainingTotal.Name = "lblRemainingTotal";
            this.lblRemainingTotal.Size = new System.Drawing.Size(218, 31);
            this.lblRemainingTotal.TabIndex = 12;
            this.lblRemainingTotal.Text = "Remaining Total:";
            // 
            // txtActionDate
            // 
            this.txtActionDate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.txtActionDate.Location = new System.Drawing.Point(431, 166);
            this.txtActionDate.Name = "txtActionDate";
            this.txtActionDate.Size = new System.Drawing.Size(136, 30);
            this.txtActionDate.TabIndex = 11;
            // 
            // lblActionDate
            // 
            this.lblActionDate.AutoSize = true;
            this.lblActionDate.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblActionDate.Location = new System.Drawing.Point(233, 162);
            this.lblActionDate.Name = "lblActionDate";
            this.lblActionDate.Size = new System.Drawing.Size(153, 31);
            this.lblActionDate.TabIndex = 10;
            this.lblActionDate.Text = "Action Date";
            // 
            // txtDebtor
            // 
            this.txtDebtor.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.txtDebtor.Location = new System.Drawing.Point(431, 88);
            this.txtDebtor.Name = "txtDebtor";
            this.txtDebtor.Size = new System.Drawing.Size(136, 30);
            this.txtDebtor.TabIndex = 9;
            // 
            // lblDebtor
            // 
            this.lblDebtor.AutoSize = true;
            this.lblDebtor.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblDebtor.Location = new System.Drawing.Point(233, 84);
            this.lblDebtor.Name = "lblDebtor";
            this.lblDebtor.Size = new System.Drawing.Size(96, 31);
            this.lblDebtor.TabIndex = 8;
            this.lblDebtor.Text = "Debtor";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(317, 249);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(187, 60);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRemainingTotalCount);
            this.Controls.Add(this.lblRemainingTotal);
            this.Controls.Add(this.txtActionDate);
            this.Controls.Add(this.lblActionDate);
            this.Controls.Add(this.txtDebtor);
            this.Controls.Add(this.lblDebtor);
            this.Controls.Add(this.btnDone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemainingTotalCount;
        private System.Windows.Forms.Label lblRemainingTotal;
        private System.Windows.Forms.TextBox txtActionDate;
        private System.Windows.Forms.Label lblActionDate;
        private System.Windows.Forms.TextBox txtDebtor;
        private System.Windows.Forms.Label lblDebtor;
        private System.Windows.Forms.Button btnDone;
    }
}

