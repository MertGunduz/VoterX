using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using VoterX.Properties;

namespace VoterX
{
    public partial class VoterX_MainMenu : Form
    {
        // Selenium Web Driver
        FirefoxDriver firefoxDriver;
        FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();

        public VoterX_MainMenu()
        {
            InitializeComponent();
        }

        // |-| USER INTERFACE |-|
        // Minimize Button Hover
        private void Minimize_Button_MouseEnter(object sender, EventArgs e)
        {
            Minimize_Button.Image = Resources.VoterX_HoveredMinimizeIcon;
        }

        private void Minimize_Button_MouseLeave(object sender, EventArgs e)
        {
            Minimize_Button.Image = Resources.VoterX_NonHoveredMinimizeIcon;
        }

        // Exit Button Hover
        private void Exit_Button_MouseEnter(object sender, EventArgs e)
        {
            Exit_Button.Image = Resources.VoterX_HoveredExitIcon;
        }

        private void Exit_Button_MouseLeave(object sender, EventArgs e)
        {
            Exit_Button.Image = Resources.VoterX_NonHoveredExitIcon;
        }

        // Top Header Label Hover
        private void TopHeader_Label_MouseEnter(object sender, EventArgs e)
        {
            TopLogo_PictureBox.Image = Resources.VoterX_HoveredVoteIcon;
            TopHeader_Label.ForeColor = Color.FromArgb(84, 206, 111);
            TopPanelTopBorder_Panel.BackColor = Color.FromArgb(84, 206, 111);
            TopPanelBottomBorder_Panel.BackColor = Color.FromArgb(84, 206, 111);
        }

        private void TopHeader_Label_MouseLeave(object sender, EventArgs e)
        {
            TopLogo_PictureBox.Image = Resources.VoterX_NonHoveredVoteIcon;
            TopHeader_Label.ForeColor = Color.FromArgb(64, 186, 91);
            TopPanelTopBorder_Panel.BackColor = Color.FromArgb(64, 186, 91);
            TopPanelBottomBorder_Panel.BackColor = Color.FromArgb(64, 186, 91);
        }

        // Top Logo PictureBox Hover
        private void TopLogo_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            TopLogo_PictureBox.Image = Resources.VoterX_HoveredVoteIcon;
            TopHeader_Label.ForeColor = Color.FromArgb(84, 206, 111);
            TopPanelTopBorder_Panel.BackColor = Color.FromArgb(84, 206, 111);
            TopPanelBottomBorder_Panel.BackColor = Color.FromArgb(84, 206, 111);
        }

        private void TopLogo_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            TopLogo_PictureBox.Image = Resources.VoterX_NonHoveredVoteIcon;
            TopHeader_Label.ForeColor = Color.FromArgb(64, 186, 91);
            TopPanelTopBorder_Panel.BackColor = Color.FromArgb(64, 186, 91);
            TopPanelBottomBorder_Panel.BackColor = Color.FromArgb(64, 186, 91);
        }

        // |-| METHODS |-|
        // Register Method
        private void RegisterCoinSniper()
        {
            firefoxDriverService.HideCommandPromptWindow = true;
            firefoxDriver = new FirefoxDriver(firefoxDriverService);
            // Goes For Proxy
            firefoxDriver.Navigate().GoToUrl("https://www.proxysite.com/");
            Thread.Sleep(2000);
            // Selects The Server
            firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[2]/input").SendKeys("https://coinsniper.net/register");
            firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[1]/select").Click();
            firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[1]/select/option[14]").Click();
            firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[2]/button").Click();
            Thread.Sleep(2000);
            // Enters Register Informations
            firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[1]/div/input").SendKeys("From Emails Database (Related Name)");
            firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[2]/div/input").SendKeys("From Emails Database (Related E-mail)");
            firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[3]/div/input").SendKeys("From Emails Database (Related Password)");
            firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[4]/div/input").SendKeys("From Emails Database Same Password");
            firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[6]/div/label").Click();
            firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[7]/div/input").Click();
            // EMAIL VERIFICATION
        }
       
        // Login & Vote Method
        private void VoteCoinSniper()
        {
            firefoxDriverService.HideCommandPromptWindow = true;
            firefoxDriver = new FirefoxDriver(firefoxDriverService);
            // Goes For Proxy
            firefoxDriver.Navigate().GoToUrl("https://www.proxysite.com/");
            Thread.Sleep(2000);
            // Selects The Server
            firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[2]/input").SendKeys("https://coinsniper.net/login");
            // Search Coin
            // Click Coin
        }
    }
}
