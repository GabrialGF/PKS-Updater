namespace Pathfinder_Kingdom_Spreadsheet_Updater
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
            this.OpenFileTextBox = new System.Windows.Forms.TextBox();
            this.ButtonOF = new System.Windows.Forms.Button();
            this.buttonSF = new System.Windows.Forms.Button();
            this.SaveFileTextBox = new System.Windows.Forms.TextBox();
            this.buttonCon = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // OpenFileTextBox
            // 
            this.OpenFileTextBox.Location = new System.Drawing.Point(12, 93);
            this.OpenFileTextBox.Name = "OpenFileTextBox";
            this.OpenFileTextBox.ReadOnly = true;
            this.OpenFileTextBox.Size = new System.Drawing.Size(371, 20);
            this.OpenFileTextBox.TabIndex = 0;
            // 
            // ButtonOF
            // 
            this.ButtonOF.Location = new System.Drawing.Point(389, 93);
            this.ButtonOF.Name = "ButtonOF";
            this.ButtonOF.Size = new System.Drawing.Size(75, 23);
            this.ButtonOF.TabIndex = 1;
            this.ButtonOF.Text = "Open";
            this.ButtonOF.UseVisualStyleBackColor = true;
            this.ButtonOF.Click += new System.EventHandler(this.ButtonOF_Click);
            // 
            // buttonSF
            // 
            this.buttonSF.Location = new System.Drawing.Point(389, 137);
            this.buttonSF.Name = "buttonSF";
            this.buttonSF.Size = new System.Drawing.Size(75, 23);
            this.buttonSF.TabIndex = 2;
            this.buttonSF.Text = "Destination";
            this.buttonSF.UseVisualStyleBackColor = true;
            this.buttonSF.Click += new System.EventHandler(this.buttonSF_Click);
            // 
            // SaveFileTextBox
            // 
            this.SaveFileTextBox.Location = new System.Drawing.Point(12, 139);
            this.SaveFileTextBox.Name = "SaveFileTextBox";
            this.SaveFileTextBox.ReadOnly = true;
            this.SaveFileTextBox.Size = new System.Drawing.Size(371, 20);
            this.SaveFileTextBox.TabIndex = 3;
            // 
            // buttonCon
            // 
            this.buttonCon.Location = new System.Drawing.Point(150, 226);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(176, 23);
            this.buttonCon.TabIndex = 4;
            this.buttonCon.Text = "CONVERT TO VERSION 5.4o";
            this.buttonCon.UseVisualStyleBackColor = true;
            this.buttonCon.Click += new System.EventHandler(this.buttonCon_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 186);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(452, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCon);
            this.Controls.Add(this.SaveFileTextBox);
            this.Controls.Add(this.buttonSF);
            this.Controls.Add(this.ButtonOF);
            this.Controls.Add(this.OpenFileTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OpenFileTextBox;
        private System.Windows.Forms.Button ButtonOF;
        private System.Windows.Forms.Button buttonSF;
        private System.Windows.Forms.TextBox SaveFileTextBox;
        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}

