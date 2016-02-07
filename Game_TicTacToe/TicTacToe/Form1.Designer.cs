namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.R1C1 = new System.Windows.Forms.Button();
            this.R1C2 = new System.Windows.Forms.Button();
            this.R1C3 = new System.Windows.Forms.Button();
            this.R2C1 = new System.Windows.Forms.Button();
            this.R2C2 = new System.Windows.Forms.Button();
            this.R2C3 = new System.Windows.Forms.Button();
            this.R3C1 = new System.Windows.Forms.Button();
            this.R3C2 = new System.Windows.Forms.Button();
            this.R3C3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(504, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // R1C1
            // 
            this.R1C1.BackColor = System.Drawing.Color.MistyRose;
            this.R1C1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1C1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.R1C1.Location = new System.Drawing.Point(34, 84);
            this.R1C1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(74, 82);
            this.R1C1.TabIndex = 1;
            this.R1C1.UseVisualStyleBackColor = false;
            this.R1C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // R1C2
            // 
            this.R1C2.BackColor = System.Drawing.Color.MistyRose;
            this.R1C2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1C2.Location = new System.Drawing.Point(115, 84);
            this.R1C2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(74, 82);
            this.R1C2.TabIndex = 2;
            this.R1C2.UseVisualStyleBackColor = false;
            this.R1C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // R1C3
            // 
            this.R1C3.BackColor = System.Drawing.Color.MistyRose;
            this.R1C3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.R1C3.Location = new System.Drawing.Point(196, 84);
            this.R1C3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(74, 82);
            this.R1C3.TabIndex = 3;
            this.R1C3.UseVisualStyleBackColor = false;
            this.R1C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // R2C1
            // 
            this.R2C1.BackColor = System.Drawing.Color.MistyRose;
            this.R2C1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.R2C1.Location = new System.Drawing.Point(34, 174);
            this.R2C1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(74, 82);
            this.R2C1.TabIndex = 4;
            this.R2C1.UseVisualStyleBackColor = false;
            this.R2C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // R2C2
            // 
            this.R2C2.BackColor = System.Drawing.Color.MistyRose;
            this.R2C2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.R2C2.Location = new System.Drawing.Point(115, 174);
            this.R2C2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(74, 82);
            this.R2C2.TabIndex = 5;
            this.R2C2.UseVisualStyleBackColor = false;
            this.R2C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // R2C3
            // 
            this.R2C3.BackColor = System.Drawing.Color.MistyRose;
            this.R2C3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.R2C3.Location = new System.Drawing.Point(196, 174);
            this.R2C3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(74, 82);
            this.R2C3.TabIndex = 6;
            this.R2C3.UseVisualStyleBackColor = false;
            this.R2C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // R3C1
            // 
            this.R3C1.BackColor = System.Drawing.Color.MistyRose;
            this.R3C1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.R3C1.Location = new System.Drawing.Point(34, 264);
            this.R3C1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(74, 82);
            this.R3C1.TabIndex = 7;
            this.R3C1.UseVisualStyleBackColor = false;
            this.R3C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // R3C2
            // 
            this.R3C2.BackColor = System.Drawing.Color.MistyRose;
            this.R3C2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.R3C2.Location = new System.Drawing.Point(115, 264);
            this.R3C2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(74, 82);
            this.R3C2.TabIndex = 8;
            this.R3C2.UseVisualStyleBackColor = false;
            this.R3C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // R3C3
            // 
            this.R3C3.BackColor = System.Drawing.Color.MistyRose;
            this.R3C3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.R3C3.Location = new System.Drawing.Point(196, 264);
            this.R3C3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(74, 82);
            this.R3C3.TabIndex = 9;
            this.R3C3.UseVisualStyleBackColor = false;
            this.R3C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 377);
            this.Controls.Add(this.R3C3);
            this.Controls.Add(this.R3C2);
            this.Controls.Add(this.R3C1);
            this.Controls.Add(this.R2C3);
            this.Controls.Add(this.R2C2);
            this.Controls.Add(this.R2C1);
            this.Controls.Add(this.R1C3);
            this.Controls.Add(this.R1C2);
            this.Controls.Add(this.R1C1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Coral;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button R1C1;
        private System.Windows.Forms.Button R1C2;
        private System.Windows.Forms.Button R1C3;
        private System.Windows.Forms.Button R2C1;
        private System.Windows.Forms.Button R2C2;
        private System.Windows.Forms.Button R2C3;
        private System.Windows.Forms.Button R3C1;
        private System.Windows.Forms.Button R3C2;
        private System.Windows.Forms.Button R3C3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

