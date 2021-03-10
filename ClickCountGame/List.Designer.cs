namespace ClickCountGame
{
    partial class List
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
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.btnShowPlayers = new System.Windows.Forms.Button();
            this.btnSortPlayers = new System.Windows.Forms.Button();
            this.btnSortResults = new System.Windows.Forms.Button();
            this.rbAge = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbScore = new System.Windows.Forms.RadioButton();
            this.rbtime = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(196, 5);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(559, 433);
            this.lstPlayers.TabIndex = 0;
            // 
            // btnShowResults
            // 
            this.btnShowResults.Location = new System.Drawing.Point(43, 104);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(99, 23);
            this.btnShowResults.TabIndex = 1;
            this.btnShowResults.Text = "Show Results";
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowPlayers
            // 
            this.btnShowPlayers.Location = new System.Drawing.Point(43, 64);
            this.btnShowPlayers.Name = "btnShowPlayers";
            this.btnShowPlayers.Size = new System.Drawing.Size(99, 23);
            this.btnShowPlayers.TabIndex = 2;
            this.btnShowPlayers.Text = "Show Players";
            this.btnShowPlayers.UseVisualStyleBackColor = true;
            this.btnShowPlayers.Click += new System.EventHandler(this.btnShowPlayers_Click);
            // 
            // btnSortPlayers
            // 
            this.btnSortPlayers.Location = new System.Drawing.Point(43, 157);
            this.btnSortPlayers.Name = "btnSortPlayers";
            this.btnSortPlayers.Size = new System.Drawing.Size(99, 39);
            this.btnSortPlayers.TabIndex = 3;
            this.btnSortPlayers.Text = "Sort Players";
            this.btnSortPlayers.UseVisualStyleBackColor = true;
            // 
            // btnSortResults
            // 
            this.btnSortResults.Location = new System.Drawing.Point(43, 265);
            this.btnSortResults.Name = "btnSortResults";
            this.btnSortResults.Size = new System.Drawing.Size(99, 39);
            this.btnSortResults.TabIndex = 4;
            this.btnSortResults.Text = "Sort Results";
            this.btnSortResults.UseVisualStyleBackColor = true;
            // 
            // rbAge
            // 
            this.rbAge.AutoSize = true;
            this.rbAge.Location = new System.Drawing.Point(29, 215);
            this.rbAge.Name = "rbAge";
            this.rbAge.Size = new System.Drawing.Size(56, 17);
            this.rbAge.TabIndex = 5;
            this.rbAge.TabStop = true;
            this.rbAge.Text = "ByAge";
            this.rbAge.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(91, 215);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(65, 17);
            this.rbName.TabIndex = 6;
            this.rbName.TabStop = true;
            this.rbName.Text = "ByName";
            this.rbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbScore
            // 
            this.rbScore.AutoSize = true;
            this.rbScore.Location = new System.Drawing.Point(91, 325);
            this.rbScore.Name = "rbScore";
            this.rbScore.Size = new System.Drawing.Size(65, 17);
            this.rbScore.TabIndex = 8;
            this.rbScore.TabStop = true;
            this.rbScore.Text = "ByScore";
            this.rbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbScore.UseVisualStyleBackColor = true;
            // 
            // rbtime
            // 
            this.rbtime.AutoSize = true;
            this.rbtime.Location = new System.Drawing.Point(29, 325);
            this.rbtime.Name = "rbtime";
            this.rbtime.Size = new System.Drawing.Size(60, 17);
            this.rbtime.TabIndex = 7;
            this.rbtime.TabStop = true;
            this.rbtime.Text = "ByTime";
            this.rbtime.UseVisualStyleBackColor = true;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbScore);
            this.Controls.Add(this.rbtime);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.rbAge);
            this.Controls.Add(this.btnSortResults);
            this.Controls.Add(this.btnSortPlayers);
            this.Controls.Add(this.btnShowPlayers);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.lstPlayers);
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Button btnShowPlayers;
        private System.Windows.Forms.Button btnSortPlayers;
        private System.Windows.Forms.Button btnSortResults;
        private System.Windows.Forms.RadioButton rbAge;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbScore;
        private System.Windows.Forms.RadioButton rbtime;
    }
}