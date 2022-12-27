namespace DS_Starter_Editor
{
    partial class GameSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSelection));
            this.CancelButton = new System.Windows.Forms.Button();
            this.PlatButton = new System.Windows.Forms.Button();
            this.HGSSButton = new System.Windows.Forms.Button();
            this.BWButton = new System.Windows.Forms.Button();
            this.BW2Button = new System.Windows.Forms.Button();
            this.PtToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HGSSToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BWToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BW2ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(89, 96);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PlatButton
            // 
            this.PlatButton.Image = ((System.Drawing.Image)(resources.GetObject("PlatButton.Image")));
            this.PlatButton.Location = new System.Drawing.Point(13, 13);
            this.PlatButton.Name = "PlatButton";
            this.PlatButton.Size = new System.Drawing.Size(40, 40);
            this.PlatButton.TabIndex = 1;
            this.PtToolTip.SetToolTip(this.PlatButton, "Platinum\r\n");
            this.PlatButton.UseVisualStyleBackColor = true;
            this.PlatButton.Click += new System.EventHandler(this.PlatButton_Click);
            // 
            // HGSSButton
            // 
            this.HGSSButton.Image = ((System.Drawing.Image)(resources.GetObject("HGSSButton.Image")));
            this.HGSSButton.Location = new System.Drawing.Point(78, 13);
            this.HGSSButton.Name = "HGSSButton";
            this.HGSSButton.Size = new System.Drawing.Size(40, 40);
            this.HGSSButton.TabIndex = 2;
            this.HGSSToolTip.SetToolTip(this.HGSSButton, "Heart Gold and Soul Silver");
            this.HGSSButton.UseVisualStyleBackColor = true;
            this.HGSSButton.Click += new System.EventHandler(this.HGSSButton_Click);
            // 
            // BWButton
            // 
            this.BWButton.Image = ((System.Drawing.Image)(resources.GetObject("BWButton.Image")));
            this.BWButton.Location = new System.Drawing.Point(144, 13);
            this.BWButton.Name = "BWButton";
            this.BWButton.Size = new System.Drawing.Size(40, 40);
            this.BWButton.TabIndex = 3;
            this.BWToolTip.SetToolTip(this.BWButton, "Black and White - not supported at the moment\r\n");
            this.BWButton.UseVisualStyleBackColor = true;
            this.BWButton.Click += new System.EventHandler(this.BWButton_Click);
            // 
            // BW2Button
            // 
            this.BW2Button.Image = ((System.Drawing.Image)(resources.GetObject("BW2Button.Image")));
            this.BW2Button.Location = new System.Drawing.Point(204, 13);
            this.BW2Button.Name = "BW2Button";
            this.BW2Button.Size = new System.Drawing.Size(40, 40);
            this.BW2Button.TabIndex = 4;
            this.BW2ToolTip.SetToolTip(this.BW2Button, "Black and White 2");
            this.BW2Button.UseVisualStyleBackColor = true;
            this.BW2Button.Click += new System.EventHandler(this.BW2Button_Click);
            // 
            // GameSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 131);
            this.Controls.Add(this.BW2Button);
            this.Controls.Add(this.BWButton);
            this.Controls.Add(this.HGSSButton);
            this.Controls.Add(this.PlatButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "GameSelection";
            this.Text = "Select a Game";
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button PlatButton;
        private System.Windows.Forms.Button HGSSButton;
        private System.Windows.Forms.Button BWButton;
        private System.Windows.Forms.Button BW2Button;
        private System.Windows.Forms.ToolTip PtToolTip;
        private System.Windows.Forms.ToolTip HGSSToolTip;
        private System.Windows.Forms.ToolTip BWToolTip;
        private System.Windows.Forms.ToolTip BW2ToolTip;
    }
}