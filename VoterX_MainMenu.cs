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

        private void VoterX_MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Vote()
        {
            firefoxDriverService.HideCommandPromptWindow = true;
            firefoxDriver = new FirefoxDriver(firefoxDriverService);
            firefoxDriver.Navigate().GoToUrl("https://www.startpage.com/");
            Thread.Sleep(1000);
            firefoxDriver.FindElementByXPath("//*[@id='q']").SendKeys("CoinSniper: Today's Best");
            firefoxDriver.FindElementByXPath("//*[@id='search']/button[2]/div").Click();
            Thread.Sleep(2000);
            firefoxDriver.FindElementByXPath("/html/body/div[2]/div/div[2]/div[1]/div[2]/div[1]/div/section[2]/div[1]/div[1]/div[2]/a").Click();
            // Login Account 
            // Search Coin
            // Click Coin
            // Vote Coin
        }

        private void Selenium_Button_Click(object sender, EventArgs e)
        {
            Vote();
        }
    }
}
