namespace ClickCountGame
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byAgeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.findUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.byScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrInterval = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.uc11 = new ClickCountGame.Uc1();
            this.uCstart1 = new ClickCountGame.UCstart();
            this.uCaddPlayer1 = new ClickCountGame.UCaddPlayer();
            this.uCchangeUsername1 = new ClickCountGame.UCchangeUsername();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUsernameToolStripMenuItem,
            this.addPlayerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeUsernameToolStripMenuItem
            // 
            this.changeUsernameToolStripMenuItem.Name = "changeUsernameToolStripMenuItem";
            this.changeUsernameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeUsernameToolStripMenuItem.Text = "Change Username";
            this.changeUsernameToolStripMenuItem.Click += new System.EventHandler(this.changeUsernameToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.toolStripSeparator3,
            this.findUserToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descendingToolStripMenuItem,
            this.toolStripSeparator4,
            this.ascendingToolStripMenuItem,
            this.byNameToolStripMenuItem1,
            this.byAgeToolStripMenuItem1});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            // 
            // byNameToolStripMenuItem1
            // 
            this.byNameToolStripMenuItem1.Name = "byNameToolStripMenuItem1";
            this.byNameToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.byNameToolStripMenuItem1.Text = "ByName";
            // 
            // byAgeToolStripMenuItem1
            // 
            this.byAgeToolStripMenuItem1.Name = "byAgeToolStripMenuItem1";
            this.byAgeToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.byAgeToolStripMenuItem1.Text = "ByAge";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // findUserToolStripMenuItem
            // 
            this.findUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.toolStripSeparator5,
            this.byScoreToolStripMenuItem,
            this.byAgeToolStripMenuItem});
            this.findUserToolStripMenuItem.Name = "findUserToolStripMenuItem";
            this.findUserToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.findUserToolStripMenuItem.Text = "FindUser";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.byNameToolStripMenuItem.Text = "ByName";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(120, 6);
            // 
            // byScoreToolStripMenuItem
            // 
            this.byScoreToolStripMenuItem.Name = "byScoreToolStripMenuItem";
            this.byScoreToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.byScoreToolStripMenuItem.Text = "ByScore";
            // 
            // byAgeToolStripMenuItem
            // 
            this.byAgeToolStripMenuItem.Name = "byAgeToolStripMenuItem";
            this.byAgeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.byAgeToolStripMenuItem.Text = "ByAge";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tmrInterval
            // 
            this.tmrInterval.Interval = 1000;
            this.tmrInterval.Tick += new System.EventHandler(this.tmrInterval_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.uc11);
            this.panelContainer.Controls.Add(this.uCstart1);
            this.panelContainer.Controls.Add(this.uCaddPlayer1);
            this.panelContainer.Controls.Add(this.uCchangeUsername1);
            this.panelContainer.Location = new System.Drawing.Point(0, 24);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 427);
            this.panelContainer.TabIndex = 1;
            // 
            // uc11
            // 
            this.uc11.Location = new System.Drawing.Point(286, 341);
            this.uc11.Name = "uc11";
            this.uc11.Size = new System.Drawing.Size(800, 427);
            this.uc11.TabIndex = 3;
            // 
            // uCstart1
            // 
            this.uCstart1.Location = new System.Drawing.Point(232, 275);
            this.uCstart1.Name = "uCstart1";
            this.uCstart1.Size = new System.Drawing.Size(800, 427);
            this.uCstart1.TabIndex = 2;
            // 
            // uCaddPlayer1
            // 
            this.uCaddPlayer1.Location = new System.Drawing.Point(270, 170);
            this.uCaddPlayer1.Name = "uCaddPlayer1";
            this.uCaddPlayer1.Size = new System.Drawing.Size(800, 427);
            this.uCaddPlayer1.TabIndex = 1;
            // 
            // uCchangeUsername1
            // 
            this.uCchangeUsername1.Location = new System.Drawing.Point(232, 341);
            this.uCchangeUsername1.Name = "uCchangeUsername1";
            this.uCchangeUsername1.Size = new System.Drawing.Size(800, 427);
            this.uCchangeUsername1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(357, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 21);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUsernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byScoreToolStripMenuItem;
        private System.Windows.Forms.Timer tmrInterval;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel panelContainer;
        private UCchangeUsername uCchangeUsername1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byAgeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byAgeToolStripMenuItem;
        private UCstart uCstart1;
        private UCaddPlayer uCaddPlayer1;
        private Uc1 uc11;
        private System.Windows.Forms.Button btnBack;
    }
}

