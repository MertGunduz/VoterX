
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopPanelTopBorder_Panel = new System.Windows.Forms.Panel();
            this.TopPanelBottomBorder_Panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mid_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Mid_Panel.Controls.Add(this.panel1);
            this.Mid_Panel.Controls.Add(this.Selenium_Button);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(800, 450);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Selenium_Button
            // 
            this.Selenium_Button.Location = new System.Drawing.Point(327, 315);
            this.Selenium_Button.Name = "Selenium_Button";
            this.Selenium_Button.Size = new System.Drawing.Size(147, 42);
            this.Selenium_Button.TabIndex = 0;
            this.Selenium_Button.Text = "Go";
            this.Selenium_Button.UseVisualStyleBackColor = true;
            this.Selenium_Button.Click += new System.EventHandler(this.Selenium_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TopPanelBottomBorder_Panel);
            this.panel1.Controls.Add(this.TopPanelTopBorder_Panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 1;
            // 
            // TopPanelTopBorder_Panel
            // 
            this.TopPanelTopBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.TopPanelTopBorder_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelTopBorder_Panel.Location = new System.Drawing.Point(0, 0);
            this.TopPanelTopBorder_Panel.Name = "TopPanelTopBorder_Panel";
            this.TopPanelTopBorder_Panel.Size = new System.Drawing.Size(800, 2);
            this.TopPanelTopBorder_Panel.TabIndex = 0;
            // 
            // TopPanelBottomBorder_Panel
            // 
            this.TopPanelBottomBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.TopPanelBottomBorder_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TopPanelBottomBorder_Panel.Location = new System.Drawing.Point(0, 65);
            this.TopPanelBottomBorder_Panel.Name = "TopPanelBottomBorder_Panel";
            this.TopPanelBottomBorder_Panel.Size = new System.Drawing.Size(800, 2);
            this.TopPanelBottomBorder_Panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 63);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Button Selenium_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TopPanelTopBorder_Panel;
        private System.Windows.Forms.Panel TopPanelBottomBorder_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

