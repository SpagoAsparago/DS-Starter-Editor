namespace DS_Starter_Editor
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
            this.GameSelectButton = new System.Windows.Forms.Button();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.Start1Label = new System.Windows.Forms.Label();
            this.Starter2Label = new System.Windows.Forms.Label();
            this.Starter3Label = new System.Windows.Forms.Label();
            this.Slot1Label = new System.Windows.Forms.Label();
            this.Slot2Label = new System.Windows.Forms.Label();
            this.Slot3Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameSelectButton
            // 
            this.GameSelectButton.Location = new System.Drawing.Point(13, 13);
            this.GameSelectButton.Name = "GameSelectButton";
            this.GameSelectButton.Size = new System.Drawing.Size(87, 23);
            this.GameSelectButton.TabIndex = 0;
            this.GameSelectButton.Text = "Select a game";
            this.GameSelectButton.UseVisualStyleBackColor = true;
            this.GameSelectButton.Click += new System.EventHandler(this.GameSelectButton_Click);
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(129, 13);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(118, 23);
            this.SelectFolderButton.TabIndex = 1;
            this.SelectFolderButton.Text = "Select game folder";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(15, 263);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(96, 13);
            this.ProgressLabel.TabIndex = 3;
            this.ProgressLabel.Text = "Game not selected";
            // 
            // Start1Label
            // 
            this.Start1Label.AutoSize = true;
            this.Start1Label.Location = new System.Drawing.Point(12, 84);
            this.Start1Label.Name = "Start1Label";
            this.Start1Label.Size = new System.Drawing.Size(47, 13);
            this.Start1Label.TabIndex = 4;
            this.Start1Label.Text = "Starter 1";
            // 
            // Starter2Label
            // 
            this.Starter2Label.AutoSize = true;
            this.Starter2Label.BackColor = System.Drawing.SystemColors.Control;
            this.Starter2Label.Location = new System.Drawing.Point(167, 84);
            this.Starter2Label.Name = "Starter2Label";
            this.Starter2Label.Size = new System.Drawing.Size(47, 13);
            this.Starter2Label.TabIndex = 5;
            this.Starter2Label.Text = "Starter 2";
            // 
            // Starter3Label
            // 
            this.Starter3Label.AutoSize = true;
            this.Starter3Label.Location = new System.Drawing.Point(314, 84);
            this.Starter3Label.Name = "Starter3Label";
            this.Starter3Label.Size = new System.Drawing.Size(47, 13);
            this.Starter3Label.TabIndex = 6;
            this.Starter3Label.Text = "Starter 3";
            // 
            // Slot1Label
            // 
            this.Slot1Label.AutoSize = true;
            this.Slot1Label.Location = new System.Drawing.Point(15, 126);
            this.Slot1Label.Name = "Slot1Label";
            this.Slot1Label.Size = new System.Drawing.Size(16, 13);
            this.Slot1Label.TabIndex = 7;
            this.Slot1Label.Text = "---";
            // 
            // Slot2Label
            // 
            this.Slot2Label.AutoSize = true;
            this.Slot2Label.Location = new System.Drawing.Point(167, 126);
            this.Slot2Label.Name = "Slot2Label";
            this.Slot2Label.Size = new System.Drawing.Size(16, 13);
            this.Slot2Label.TabIndex = 8;
            this.Slot2Label.Text = "---";
            // 
            // Slot3Label
            // 
            this.Slot3Label.AutoSize = true;
            this.Slot3Label.Location = new System.Drawing.Point(314, 126);
            this.Slot3Label.Name = "Slot3Label";
            this.Slot3Label.Size = new System.Drawing.Size(16, 13);
            this.Slot3Label.TabIndex = 9;
            this.Slot3Label.Text = "---";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(317, 156);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(18, 206);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(177, 23);
            this.ChangeButton.TabIndex = 13;
            this.ChangeButton.Text = "Apply changes";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(469, 20);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 14;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(469, 63);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 23);
            this.HelpButton.TabIndex = 15;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(15, 296);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(0, 13);
            this.SelectionLabel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Slot3Label);
            this.Controls.Add(this.Slot2Label);
            this.Controls.Add(this.Slot1Label);
            this.Controls.Add(this.Starter3Label);
            this.Controls.Add(this.Starter2Label);
            this.Controls.Add(this.Start1Label);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.GameSelectButton);
            this.Name = "Form1";
            this.Text = "DS Starter Editor 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameSelectButton;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label Start1Label;
        private System.Windows.Forms.Label Starter2Label;
        private System.Windows.Forms.Label Starter3Label;
        private System.Windows.Forms.Label Slot1Label;
        private System.Windows.Forms.Label Slot2Label;
        private System.Windows.Forms.Label Slot3Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button AboutButton;
        private new System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label SelectionLabel;
    }
}

