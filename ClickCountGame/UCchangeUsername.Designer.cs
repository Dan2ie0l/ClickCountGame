namespace ClickCountGame
{
    partial class UCchangeUsername
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbUserNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUserNames
            // 
            this.cmbUserNames.FormattingEnabled = true;
            this.cmbUserNames.Location = new System.Drawing.Point(306, 152);
            this.cmbUserNames.Name = "cmbUserNames";
            this.cmbUserNames.Size = new System.Drawing.Size(188, 21);
            this.cmbUserNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(252, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name։";
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeUsername.Location = new System.Drawing.Point(338, 231);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(100, 35);
            this.btnChangeUsername.TabIndex = 12;
            this.btnChangeUsername.Text = "Change";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            // 
            // UCchangeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangeUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUserNames);
            this.Name = "UCchangeUsername";
            this.Size = new System.Drawing.Size(800, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeUsername;
    }
}
