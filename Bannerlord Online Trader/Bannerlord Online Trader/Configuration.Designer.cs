namespace Bannerlord_Online_Trader
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
            this.launcherPathLabel = new System.Windows.Forms.Label();
            this.launcherPathTextBox = new System.Windows.Forms.TextBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.pathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // launcherPathLabel
            // 
            this.launcherPathLabel.Location = new System.Drawing.Point(12, 9);
            this.launcherPathLabel.Name = "launcherPathLabel";
            this.launcherPathLabel.Size = new System.Drawing.Size(176, 23);
            this.launcherPathLabel.TabIndex = 0;
            this.launcherPathLabel.Text = "Bannerlord Online Launcher Path:";
            // 
            // launcherPathTextBox
            // 
            this.launcherPathTextBox.Location = new System.Drawing.Point(194, 9);
            this.launcherPathTextBox.Name = "launcherPathTextBox";
            this.launcherPathTextBox.Size = new System.Drawing.Size(379, 20);
            this.launcherPathTextBox.TabIndex = 1;
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(313, 363);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(119, 44);
            this.launchButton.TabIndex = 2;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(546, 9);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(27, 20);
            this.pathButton.TabIndex = 3;
            this.pathButton.Text = "...";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.launcherPathTextBox);
            this.Controls.Add(this.launcherPathLabel);
            this.Name = "Form1";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.configurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button pathButton;

        private System.Windows.Forms.Label launcherPathLabel;
        private System.Windows.Forms.TextBox launcherPathTextBox;

        #endregion
    }
}