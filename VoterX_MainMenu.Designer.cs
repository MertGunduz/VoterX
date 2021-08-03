
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterX_MainMenu));
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.WindowState_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.TopSeperator_Panel = new System.Windows.Forms.Panel();
            this.BottomSeperator_Panel = new System.Windows.Forms.Panel();
            this.TopHeader_Label = new System.Windows.Forms.Label();
            this.TopLogo_PictureBox = new System.Windows.Forms.PictureBox();
            this.TopPanelBottomBorder_Panel = new System.Windows.Forms.Panel();
            this.TopPanelTopBorder_Panel = new System.Windows.Forms.Panel();
            this.Mid_Panel.SuspendLayout();
            this.Top_Panel.SuspendLayout();
            this.WindowState_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Mid_Panel.Controls.Add(this.Top_Panel);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(800, 450);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Top_Panel.Controls.Add(this.WindowState_Panel);
            this.Top_Panel.Controls.Add(this.TopHeader_Label);
            this.Top_Panel.Controls.Add(this.TopLogo_PictureBox);
            this.Top_Panel.Controls.Add(this.TopPanelBottomBorder_Panel);
            this.Top_Panel.Controls.Add(this.TopPanelTopBorder_Panel);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(800, 54);
            this.Top_Panel.TabIndex = 1;
            // 
            // WindowState_Panel
            // 
            this.WindowState_Panel.Controls.Add(this.Minimize_Button);
            this.WindowState_Panel.Controls.Add(this.Exit_Button);
            this.WindowState_Panel.Controls.Add(this.TopSeperator_Panel);
            this.WindowState_Panel.Controls.Add(this.BottomSeperator_Panel);
            this.WindowState_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.WindowState_Panel.Location = new System.Drawing.Point(600, 2);
            this.WindowState_Panel.Name = "WindowState_Panel";
            this.WindowState_Panel.Size = new System.Drawing.Size(200, 50);
            this.WindowState_Panel.TabIndex = 4;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Minimize_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Minimize_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Image = global::VoterX.Properties.Resources.VoterX_NonHoveredMinimizeIcon;
            this.Minimize_Button.Location = new System.Drawing.Point(118, 10);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(41, 30);
            this.Minimize_Button.TabIndex = 7;
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.MouseEnter += new System.EventHandler(this.Minimize_Button_MouseEnter);
            this.Minimize_Button.MouseLeave += new System.EventHandler(this.Minimize_Button_MouseLeave);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Exit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Exit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Image = global::VoterX.Properties.Resources.VoterX_NonHoveredExitIcon;
            this.Exit_Button.Location = new System.Drawing.Point(159, 10);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(41, 30);
            this.Exit_Button.TabIndex = 6;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.MouseEnter += new System.EventHandler(this.Exit_Button_MouseEnter);
            this.Exit_Button.MouseLeave += new System.EventHandler(this.Exit_Button_MouseLeave);
            // 
            // TopSeperator_Panel
            // 
            this.TopSeperator_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSeperator_Panel.Location = new System.Drawing.Point(0, 0);
            this.TopSeperator_Panel.Name = "TopSeperator_Panel";
            this.TopSeperator_Panel.Size = new System.Drawing.Size(200, 10);
            this.TopSeperator_Panel.TabIndex = 1;
            // 
            // BottomSeperator_Panel
            // 
            this.BottomSeperator_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomSeperator_Panel.Location = new System.Drawing.Point(0, 40);
            this.BottomSeperator_Panel.Name = "BottomSeperator_Panel";
            this.BottomSeperator_Panel.Size = new System.Drawing.Size(200, 10);
            this.BottomSeperator_Panel.TabIndex = 0;
            // 
            // TopHeader_Label
            // 
            this.TopHeader_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopHeader_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopHeader_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.TopHeader_Label.Location = new System.Drawing.Point(36, 2);
            this.TopHeader_Label.Name = "TopHeader_Label";
            this.TopHeader_Label.Size = new System.Drawing.Size(62, 50);
            this.TopHeader_Label.TabIndex = 3;
            this.TopHeader_Label.Text = "VoterX";
            this.TopHeader_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopHeader_Label.MouseEnter += new System.EventHandler(this.TopHeader_Label_MouseEnter);
            this.TopHeader_Label.MouseLeave += new System.EventHandler(this.TopHeader_Label_MouseLeave);
            // 
            // TopLogo_PictureBox
            // 
            this.TopLogo_PictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopLogo_PictureBox.Image = global::VoterX.Properties.Resources.VoterX_NonHoveredVoteIcon;
            this.TopLogo_PictureBox.Location = new System.Drawing.Point(0, 2);
            this.TopLogo_PictureBox.Name = "TopLogo_PictureBox";
            this.TopLogo_PictureBox.Size = new System.Drawing.Size(36, 50);
            this.TopLogo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TopLogo_PictureBox.TabIndex = 2;
            this.TopLogo_PictureBox.TabStop = false;
            this.TopLogo_PictureBox.MouseEnter += new System.EventHandler(this.TopLogo_PictureBox_MouseEnter);
            this.TopLogo_PictureBox.MouseLeave += new System.EventHandler(this.TopLogo_PictureBox_MouseLeave);
            // 
            // TopPanelBottomBorder_Panel
            // 
            this.TopPanelBottomBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.TopPanelBottomBorder_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TopPanelBottomBorder_Panel.Location = new System.Drawing.Point(0, 52);
            this.TopPanelBottomBorder_Panel.Name = "TopPanelBottomBorder_Panel";
            this.TopPanelBottomBorder_Panel.Size = new System.Drawing.Size(800, 2);
            this.TopPanelBottomBorder_Panel.TabIndex = 1;
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
            // VoterX_MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoterX_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterX";
            this.Mid_Panel.ResumeLayout(false);
            this.Top_Panel.ResumeLayout(false);
            this.WindowState_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel TopPanelTopBorder_Panel;
        private System.Windows.Forms.Panel TopPanelBottomBorder_Panel;
        private System.Windows.Forms.PictureBox TopLogo_PictureBox;
        private System.Windows.Forms.Label TopHeader_Label;
        private System.Windows.Forms.Panel WindowState_Panel;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel TopSeperator_Panel;
        private System.Windows.Forms.Panel BottomSeperator_Panel;
    }
}

