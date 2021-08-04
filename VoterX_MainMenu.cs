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
using System.IO;
using System.Data.OleDb;
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

        // Database Writing Accounts
        string fullSentence;
        string extractedText = "";
        string accountGmail;
        string accountGmailPassword;
        string accountRamblerRu;
        string accountRamblerRuPassword;
        int colonRepeat = 0;
        int readedDigit;

        // Database
        OleDbConnection oleDbConnection;

        // Random Data
        Random random = new Random();
        string[] randomNames = { "John", "Elric", "Alessandro", "Giovanni", "Girolamo", "Kapsberger", "Roberto", "Marcin", "Sergey", "Francesco", "Francisco", "Tarrega", "Lopez", "Coltrane", "Luigi", "Stefano", "Gabriel", "Astrix", "Kopberg", "Sven", "Swarx", "Benjamin", "Juho", "Eino", "Jouko", "Vilho", "Ville", "Eicca", "Johnny", "Ernie", "Fluke", "Mort", "Robbie", "Andrey", "Artem", "Artemskovich", "Alphonse", "Armstrong", "Ivan", "Ivar", "Bjornson", "Selvik", "Gundry", "Bjarne", "Camila", "Isabella", "Ignacio", "Rosales", "Fernando", "Joaquin", "Dante", "Rodriguez", "Manuel", "Felipe", "Gael", "Mikhail", "Maxim", "Kiril", "Vladimirovich", "Andriy", "Aleksander", "Apostol", "Avelovich", "Bogdan", "Leon", "Paul", "Finn", "Jonah", "Wang", "Teng", "Li", "Jei", "Zhang", "Bojing", "Changpu", "Chuanli", "Dingbang", "Komojikari", "Guang", "Huan", "Jinhai", "Manchu", "Armaan", "Arjun", "Aarav", "Aditya", "Rahul", "Rakesh", "Vivaan", "Fuji", "Haru", "Haruto", "Hiroto", "Kai", "Itsuki", "Kenji", "Yaketsuku", "Yakeru", "Homura", "Shimizu", "Tenmongaku", "Antantaru", "Fujin", "Raiden", "Ryujin", "Tsukiyomi", "Takemikazuchi", "Yuuto", "Temuleenev", "Ardhamonskiv" };
        string[] randomLastNames = { "Warbringer", "TrojanX", "Hoverman", "Deikmann", "Liebestraume", "Oboemann", "Profundo", "Sopranino", "Soprano", "Tenor", "Baritone", "Bass", "Buffo", "Schgeller", "Sirmann", "Mann", "Zweihander", "Plogat", "Execute", "Ash" };
        string[] randomNumbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        // Database Data
        string email;
        string emailPassword;

        public VoterX_MainMenu()
        {
            InitializeComponent();
        }

        private void VoterX_MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voterXDataSet.VoterX_AccountsTable' table. You can move, or remove it, as needed.
            this.voterX_AccountsTableTableAdapter.Fill(this.voterXDataSet.VoterX_AccountsTable);
            oleDbConnection = new OleDbConnection(Database.databaseString);
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

        // Register Accounts Label Hover
        private void RegisterAccounts_Label_MouseEnter(object sender, EventArgs e)
        {
            RegisterAccounts_Label.Image = Resources.VoterX_HoveredRegisterIcon;
            RegisterAccounts_Label.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void RegisterAccounts_Label_MouseLeave(object sender, EventArgs e)
        {
            RegisterAccounts_Label.Image = Resources.VoterX_NonHoveredRegisterIcon;
            RegisterAccounts_Label.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Vote A Coin Label Hover
        private void VoteACoin_Label_MouseEnter(object sender, EventArgs e)
        {
            VoteACoin_Label.Image = Resources.VoterX_HoveredVoteCoinIcon;
            VoteACoin_Label.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void VoteACoin_Label_MouseLeave(object sender, EventArgs e)
        {
            VoteACoin_Label.Image = Resources.VoterX_NonHoveredVoteCoinIcon;
            VoteACoin_Label.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Accounts Label Hover
        private void Accounts_Label_MouseEnter(object sender, EventArgs e)
        {
            Accounts_Label.Image = Resources.VoterX_HoveredAccountsIcon;
            Accounts_Label.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void Accounts_Label_MouseLeave(object sender, EventArgs e)
        {
            Accounts_Label.Image = Resources.VoterX_NonHoveredAccountsIcon;
            Accounts_Label.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Register Accounts Button Hover
        private void RegisterAccounts_Button_MouseEnter(object sender, EventArgs e)
        {
            RegisterAccounts_Button.Image = Resources.VoterX_HoveredStartIcon;
            RegisterAccounts_Button.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void RegisterAccounts_Button_MouseLeave(object sender, EventArgs e)
        {
            RegisterAccounts_Button.Image = Resources.VoterX_NonHoveredStartIcon;
            RegisterAccounts_Button.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Start Voting Button Hover
        private void StartVoting_Button_MouseEnter(object sender, EventArgs e)
        {
            StartVoting_Button.Image = Resources.VoterX_HoveredStartIcon;
            StartVoting_Button.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void StartVoting_Button_MouseLeave(object sender, EventArgs e)
        {
            StartVoting_Button.Image = Resources.VoterX_NonHoveredStartIcon;
            StartVoting_Button.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Insert Accounts Button Hover
        private void InsertAccounts_Button_MouseEnter(object sender, EventArgs e)
        {
            InsertAccounts_Button.Image = Resources.VoterX_HoveredDatabaseIcon;
            InsertAccounts_Button.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void InsertAccounts_Button_MouseLeave(object sender, EventArgs e)
        {
            InsertAccounts_Button.Image = Resources.VoterX_NonHoveredDatabaseIcon;
            InsertAccounts_Button.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // |-| BACKEND |-|
        // Sets The WindowState To Minimized
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Exits From Application
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Registration Process
        private void RegisterAccounts_Button_Click(object sender, EventArgs e)
        {
            RegisterCoinSniper();
        }

        // Database Account Insertion 
        private void InsertAccounts_Button_Click(object sender, EventArgs e)
        {
            // Sets The OpenFileDialog Settings
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select The Accounts Text File";
            openFileDialog.Filter = "Text File | *.txt";

            // Opens OpenFileDialog 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Gets The FilePath
                string filePath = openFileDialog.FileName;

                // Reads The File And Assigns The Sentences To AccountTextData
                string[] accountTextData = File.ReadAllLines(filePath);

                for (int i = 0; i < accountTextData.Length; i++)
                {
                    // Takes A Account Sentence From Array To Extract Data
                    fullSentence = accountTextData[i];

                    // Sentence Extracting
                    for (int index = 0; index < fullSentence.Length; index++)
                    {
                        // Increase ReadedDigit Number Every Loop
                        readedDigit++;

                        if (fullSentence[index].ToString() != ":")
                        {
                            extractedText = extractedText + fullSentence[index].ToString();

                            if (readedDigit == fullSentence.Length)
                            {
                                // Every New Sentence Makes It 0
                                readedDigit = 0;
                                colonRepeat = 0;

                                accountRamblerRuPassword = extractedText;
                                extractedText = "";

                                //  OLEDB
                                oleDbConnection.Open();
                                OleDbCommand insertAccountCommand = new OleDbCommand("Insert Into VoterX_AccountsTable (Account_Gmail, Account_GmailPassword, Account_RambleRu, Account_RambleRuPassword) Values (@p1, @p2, @p3, @p4)", oleDbConnection);
                                insertAccountCommand.Parameters.AddWithValue("@p1", accountGmail);
                                insertAccountCommand.Parameters.AddWithValue("@p2", accountGmailPassword);
                                insertAccountCommand.Parameters.AddWithValue("@p3", accountRamblerRu);
                                insertAccountCommand.Parameters.AddWithValue("@p4", accountRamblerRuPassword);
                                insertAccountCommand.ExecuteNonQuery();
                                oleDbConnection.Close();

                                accountGmail = "";
                                accountGmailPassword = "";
                                accountRamblerRu = "";
                                accountRamblerRuPassword = "";
                            }
                        }
                        else
                        {
                            colonRepeat++;

                            if (colonRepeat == 1)
                            {
                                accountGmail = extractedText;
                                extractedText = "";
                            }
                            else if (colonRepeat == 2)
                            {
                                accountGmailPassword = extractedText;
                                extractedText = "";
                            }
                            else if (colonRepeat == 3)
                            {
                                accountRamblerRu = extractedText;
                                extractedText = "";
                            }
                        }
                    }
                }
            }
        }

        // |-| METHODS |-|
        // Register Method
        private void RegisterCoinSniper()
        {
            int totalAccounts = 0;

            oleDbConnection.Open();
            OleDbCommand totalAccountCommand = new OleDbCommand("Select Count(*) From VoterX_AccountsTable Where Account_Registered = false", oleDbConnection);
            OleDbDataReader totalAccountReader = totalAccountCommand.ExecuteReader();

            while (totalAccountReader.Read())
            {
                totalAccounts = (int)totalAccountReader[0];
            }
            totalAccountReader.Close();
            oleDbConnection.Close();

            for (int i = 1; i < totalAccounts; i++)
            {
                // Reads Email & Password
                oleDbConnection.Open();
                OleDbCommand readEmailCommand = new OleDbCommand("Select Account_Gmail, Account_GmailPassword From VoterX_AccountsTable Where Account_ID = @p1", oleDbConnection);
                readEmailCommand.Parameters.AddWithValue("@p1", i);
                OleDbDataReader emailReader = readEmailCommand.ExecuteReader();

                while (emailReader.Read())
                {
                    email = emailReader[0].ToString();
                    emailPassword = emailReader[1].ToString();
                }
                emailReader.Close();
                oleDbConnection.Close();

                // Updates Registered Accounts
                oleDbConnection.Open();
                OleDbCommand registerBitCommand = new OleDbCommand("Update VoterX_AccountsTable Set Account_Registered = true Where Account_Gmail = @p1 And Account_GmailPassword = @p2", oleDbConnection);
                registerBitCommand.Parameters.AddWithValue("@p1", email);
                registerBitCommand.Parameters.AddWithValue("@p2", emailPassword);
                registerBitCommand.ExecuteNonQuery();
                oleDbConnection.Close();

                // Sets The FirefoxDriver Option
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
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[1]/div/input").SendKeys(randomNames[random.Next(0, randomNames.Length - 1)] + randomLastNames[random.Next(0, randomLastNames.Length - 1)] + randomNumbers[random.Next(0, randomNumbers.Length - 1)]);
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[2]/div/input").SendKeys(email);
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[3]/div/input").SendKeys(emailPassword);
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[4]/div/input").SendKeys(emailPassword);
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[6]/div/label").Click();
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[7]/div/input").Click();
                Thread.Sleep(1500);

                // Goes To Mail For Verification Link
                firefoxDriver.Navigate().GoToUrl("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1628095646&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3d66ef082d-9382-52c4-98a0-7168729b0378&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015");
                Thread.Sleep(1500);

                // Email Login 
                firefoxDriver.FindElementByXPath("//*[@id='i0116']").SendKeys(email);
                firefoxDriver.FindElementByXPath("//*[@id='idSIButton9']").Click();
                Thread.Sleep(500);

                // Password Login
                firefoxDriver.FindElementByXPath("//*[@id='i0118']").SendKeys(emailPassword);
                firefoxDriver.FindElementByXPath("//*[@id='idSIButton9']").Click();
                Thread.Sleep(1500);

                // Mails
                firefoxDriver.FindElementByXPath("/html/body/div[2]/div/div[1]/div/div[1]/div[2]/div/div/div/div/div[1]/div[2]/div/div/div/div/div[1]/div/div[2]/div/input").SendKeys("CoinSniper");
                firefoxDriver.FindElementByXPath("/html/body/div[2]/div/div[1]/div/div[1]/div[2]/div/div/div/div/div[1]/div[2]/div/div/div/div/div[1]/button/span/i").Click();
                Thread.Sleep(1000);
                firefoxDriver.FindElementByXPath("//*[@id='5060efdf - 2b61 - 4ce2 - 1f77 - 590348f151fd']/div/div/div/div/div[1]").Click();
                firefoxDriver.FindElementByXPath("//*[@id=':qq']/div[1]/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/span/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td/a").Click();

                // Firefox Driver Shutdown
                firefoxDriver.Close();
            }
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
