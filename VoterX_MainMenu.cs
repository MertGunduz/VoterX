using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace VoterX
{
    public partial class VoterX_MainMenu : Form
    {
        // Selenium Web Driver
        FirefoxDriver firefoxDriver = new FirefoxDriver();
        FirefoxDriverService firefoxDriverService;

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
            FirefoxDriverService.CreateDefaultService(firefoxDriver.CurrentWindowHandle);
            firefoxDriver.Navigate().GoToUrl("https://hidester.com/proxy/");
        }

        private void Selenium_Button_Click(object sender, EventArgs e)
        {
            Vote();
        }
    }
}
