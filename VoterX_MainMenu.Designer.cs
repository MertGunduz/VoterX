
namespace VoterX
{
    partial class VoterX_MainMenu
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
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Selenium_Button = new System.Windows.Forms.Button();
            this.Mid_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.Controls.Add(this.Selenium_Button);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(800, 450);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Selenium_Button
            // 
            this.Selenium_Button.Location = new System.Drawing.Point(327, 204);
            this.Selenium_Button.Name = "Selenium_Button";
            this.Selenium_Button.Size = new System.Drawing.Size(147, 42);
            this.Selenium_Button.TabIndex = 0;
            this.Selenium_Button.Text = "Go";
            this.Selenium_Button.UseVisualStyleBackColor = true;
            this.Selenium_Button.Click += new System.EventHandler(this.Selenium_Button_Click);
            // 
            // VoterX_MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoterX_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VoterX_MainMenu_Load);
            this.Mid_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Button Selenium_Button;
    }
}

