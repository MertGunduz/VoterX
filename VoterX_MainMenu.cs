using OpenQA.Selenium.Firefox;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
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
        SqlConnection sqlConnection;

        // Random Data
        Random random = new Random();
        string[] randomNames = { "John", "Elric", "Alessandro", "Giovanni", "Girolamo", "Kapsberger", "Roberto", "Marcin", "Sergey", "Francesco", "Francisco", "Tarrega", "Lopez", "Coltrane", "Luigi", "Stefano", "Gabriel", "Astrix", "Kopberg", "Sven", "Swarx", "Benjamin", "Juho", "Eino", "Jouko", "Vilho", "Ville", "Eicca", "Johnny", "Ernie", "Fluke", "Mort", "Robbie", "Andrey", "Artem", "Artemskovich", "Alphonse", "Armstrong", "Ivan", "Ivar", "Bjornson", "Selvik", "Gundry", "Bjarne", "Camila", "Isabella", "Ignacio", "Rosales", "Fernando", "Joaquin", "Dante", "Rodriguez", "Manuel", "Felipe", "Gael", "Mikhail", "Maxim", "Kiril", "Vladimirovich", "Andriy", "Aleksander", "Apostol", "Avelovich", "Bogdan", "Leon", "Paul", "Finn", "Jonah", "Wang", "Teng", "Li", "Jei", "Zhang", "Bojing", "Changpu", "Chuanli", "Dingbang", "Komojikari", "Guang", "Huan", "Jinhai", "Manchu", "Armaan", "Arjun", "Aarav", "Aditya", "Rahul", "Rakesh", "Vivaan", "Fuji", "Haru", "Haruto", "Hiroto", "Kai", "Itsuki", "Kenji", "Yaketsuku", "Yakeru", "Homura", "Shimizu", "Tenmongaku", "Antantaru", "Fujin", "Raiden", "Ryujin", "Tsukiyomi", "Takemikazuchi", "Yuuto", "Temuleenev", "Ardhamonskiv" };
        string[] randomLastNames = { "Desplat", "Greenwoods", "Atticus", "Abandons", "SRothe", "Mehldau", "Schmidt", "Dixieland", "Psyland", "Creole", "Adderley", "Strayhorn", "Hoverman", "Deikmann", "Liebestraume", "Oboemann", "Profundo", "Sopranino", "Soprano", "Tenor", "Baritone", "Bass", "Buffo", "Schgeller", "Sirmann", "Mann", "Zweihander", "Plogat", "Execute", "Ash", "Sandman", "Reverie", "Sentiment", "Hyman", "Helmut", "Nieberle", "Antti", "Sarpila", "Stochelo", "Thelonious" };
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
            // TODO: This line of code loads data into the 'voterX_AccountsTableDataSet.VoterX_AccountsTable' table. You can move, or remove it, as needed.
            this.voterX_AccountsTableTableAdapter.Fill(this.voterX_AccountsTableDataSet.VoterX_AccountsTable);
            sqlConnection = new SqlConnection(Database.databaseString);
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

        // TextBox Cleans
        private void VoteQuantity_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (VoteQuantity_TextBox.Text == "  Vote Quantity ->")
            {
                VoteQuantity_TextBox.Clear();
            }
        }

        private void CoinName_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CoinName_TextBox.Text == "  Coin Name ->")
            {
                CoinName_TextBox.Clear();
            }
        }

        private void AccountQuantity_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (AccountQuantity_TextBox.Text == "  Account Quantity ->")
            {
                AccountQuantity_TextBox.Clear();
            }
        }

        private void OperationSpeed_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (OperationSpeed_TextBox.Text == "  Registration Speed ->")
            {
                OperationSpeed_TextBox.Clear();
            }
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

        // Voting Process
        private void StartVoting_Button_Click(object sender, EventArgs e)
        {
            VoteCoinSniper();
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

                                //  MSSQL
                                sqlConnection.Open();
                                SqlCommand insertAccountCommand = new SqlCommand("Insert Into VoterX_AccountsTable (Account_Gmail, Account_GmailPassword, Account_RambleRu, Account_RambleRuPassword) Values (@p1, @p2, @p3, @p4)", sqlConnection);
                                insertAccountCommand.Parameters.AddWithValue("@p1", accountGmail);
                                insertAccountCommand.Parameters.AddWithValue("@p2", accountGmailPassword);
                                insertAccountCommand.Parameters.AddWithValue("@p3", accountRamblerRu);
                                insertAccountCommand.Parameters.AddWithValue("@p4", accountRamblerRuPassword);
                                insertAccountCommand.ExecuteNonQuery();
                                sqlConnection.Close();

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
            // Writes A Start Log
            RegisterOperationLog_RichTextBox.Clear();
            RegisterOperationLog_RichTextBox.Text += "|-------------------------------|\n";
            RegisterOperationLog_RichTextBox.Text += "| Operation Started |\n";
            RegisterOperationLog_RichTextBox.Text += "|-------------------------------|\n\n";

            int totalAccounts = 0;

            // Reads The Account Quantity
            sqlConnection.Open();
            SqlCommand totalAccountCommand = new SqlCommand("Select Count(*) From VoterX_AccountsTable Where Account_Registered = 0", sqlConnection);
            SqlDataReader totalAccountReader = totalAccountCommand.ExecuteReader();

            while (totalAccountReader.Read())
            {
                totalAccounts = (int)totalAccountReader[0];
            }
            totalAccountReader.Close();
            sqlConnection.Close();

            for (int i = 1; i < totalAccounts; i++)
            {
                // sqlConnection Email & Password
                sqlConnection.Open();
                SqlCommand readEmailCommand = new SqlCommand("Select Account_Gmail, Account_GmailPassword From VoterX_AccountsTable Where Account_ID = @p1", sqlConnection);
                readEmailCommand.Parameters.AddWithValue("@p1", i);
                SqlDataReader emailReader = readEmailCommand.ExecuteReader();

                while (emailReader.Read())
                {
                    email = emailReader[0].ToString();
                    emailPassword = emailReader[1].ToString();
                }
                emailReader.Close();
                sqlConnection.Close();

                RegisterOperationLog_RichTextBox.Text += $"Email -> {email} \n Password -> {emailPassword}\n\nData Readed\n\n";

                // Updates Registered Accounts
                sqlConnection.Open();
                SqlCommand registerBitCommand = new SqlCommand("Update VoterX_AccountsTable Set Account_Registered = 1 Where Account_Gmail = @p1 And Account_GmailPassword = @p2", sqlConnection);
                registerBitCommand.Parameters.AddWithValue("@p1", email);
                registerBitCommand.Parameters.AddWithValue("@p2", emailPassword);
                registerBitCommand.ExecuteNonQuery();
                sqlConnection.Close();

                RegisterOperationLog_RichTextBox.Text += "Registered Turned True\n\n";

                // Sets The FirefoxDriver Option
                firefoxDriverService.HideCommandPromptWindow = true;
                firefoxDriver = new FirefoxDriver(firefoxDriverService);

                RegisterOperationLog_RichTextBox.Text += "Firefox Driver Setted\n\n";

                // Goes For Proxy
                firefoxDriver.Navigate().GoToUrl("https://www.proxysite.com/");
                Thread.Sleep(2000);

                RegisterOperationLog_RichTextBox.Text += "Proxy Successful\n\n";

                // Selects The Server
                firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[2]/input").SendKeys("https://coinsniper.net/register");
                firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[1]/select").Click();
                firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[1]/select/option[14]").Click();
                firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[2]/button").Click();
                Thread.Sleep(2000);

                RegisterOperationLog_RichTextBox.Text += "Server Initialized\n\n";

                // Enters Register Informations
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[1]/div/input").SendKeys(randomNames[random.Next(0, randomNames.Length - 1)] + randomLastNames[random.Next(0, randomLastNames.Length - 1)] + randomNumbers[random.Next(0, randomNumbers.Length - 1)]);
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[2]/div/input").SendKeys(email);
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[3]/div/input").SendKeys(emailPassword);
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[4]/div/input").SendKeys(emailPassword);
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[6]/div/label").Click();
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[7]/div/input").Click();
                Thread.Sleep(1500);

                RegisterOperationLog_RichTextBox.Text += "Register Informations Entered\n\n";

                // Goes To Mail For Verification Link
                firefoxDriver.Navigate().GoToUrl("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1628095646&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3d66ef082d-9382-52c4-98a0-7168729b0378&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015");
                Thread.Sleep(1500);

                RegisterOperationLog_RichTextBox.Text += "Entered Mail For Verification \n\n";

                // Email Login 
                firefoxDriver.FindElementByXPath("//*[@id='i0116']").SendKeys(email); // Email
                firefoxDriver.FindElementByXPath("//*[@id='idSIButton9']").Click();
                Thread.Sleep(500);

                // Password Login
                firefoxDriver.FindElementByXPath("//*[@id='i0118']").SendKeys(emailPassword); // EmailPassword
                firefoxDriver.FindElementByXPath("//*[@id='idSIButton9']").Click();
                Thread.Sleep(500);

                RegisterOperationLog_RichTextBox.Text += "Signed In!\n\n";

                // Open Account Cookie
                firefoxDriver.FindElementByXPath("//*[@id='idBtn_Back']").Click();
                Thread.Sleep(2500);


                // Find CoinSniper Mail
                firefoxDriver.FindElementByXPath("/html/body/div[2]/div/div[1]/div/div[1]/div[2]/div/div/div/div/div[1]/div[2]/div/div/div").Click();
                firefoxDriver.FindElementByXPath("/html/body/div[2]/div/div[1]/div/div[1]/div[2]/div/div/div/div/div[1]/div[2]/div/div/div/div/div[1]/div/div[2]/div/input").SendKeys("CoinSniper");
                firefoxDriver.FindElementByXPath("/html/body/div[2]/div/div[1]/div/div[1]/div[2]/div/div/div/div/div[1]/div[2]/div/div/div/div/div[1]/button/span/i").Click();
                Thread.Sleep(1000);

                // Open CoinSniper Mail & Verify
                firefoxDriver.FindElementByClassName("_1y3FkDsOHuxLnfkzQ8Dx7o").Click();
                Thread.Sleep(400);
                firefoxDriver.FindElementByXPath("/html/body/div[2]/div/div[2]/div[2]/div[1]/div/div/div[3]/div[2]/div/div[2]/div/div/div/div/div[2]/div[1]/div/div/div[3]/div/div/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table[1]/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td/a").Click();
                Thread.Sleep(1000);

                RegisterOperationLog_RichTextBox.Text += "Registration Finished!\n\n";

                // Firefox Driver Shutdown
                firefoxDriver.Close();
                firefoxDriver.Quit();

                RegisterOperationLog_RichTextBox.Text += "Firefox Driver Shutted Down\n\n";
            }
        }

        // Login & Vote Method
        private void VoteCoinSniper()
        {
            // Reads Total Accounts
            int totalAccounts = 0;

            sqlConnection.Open();
            SqlCommand totalAccountCommand = new SqlCommand("Select Count(*) From VoterX_AccountsTable Where Account_Registered = false", sqlConnection);
            SqlDataReader totalAccountReader = totalAccountCommand.ExecuteReader();

            while (totalAccountReader.Read())
            {
                totalAccounts = (int)totalAccountReader[0];
            }
            totalAccountReader.Close();
            sqlConnection.Close();

            for (int i = 1; i < totalAccounts; i++)
            {
                // Reads Email & Password
                sqlConnection.Open();
                SqlCommand readEmailCommand = new SqlCommand("Select Account_Gmail, Account_GmailPassword From VoterX_AccountsTable Where Account_ID = @p1", sqlConnection);
                readEmailCommand.Parameters.AddWithValue("@p1", i);
                SqlDataReader emailReader = readEmailCommand.ExecuteReader();

                while (emailReader.Read())
                {
                    email = emailReader[0].ToString();
                    emailPassword = emailReader[1].ToString();
                }
                emailReader.Close();
                sqlConnection.Close();

                // Sets The Options of Gecko Driver
                firefoxDriverService.HideCommandPromptWindow = true;
                firefoxDriver = new FirefoxDriver(firefoxDriverService);

                // Goes For Proxy
                firefoxDriver.Navigate().GoToUrl("https://www.proxysite.com/");
                Thread.Sleep(2000);

                // Selects The Server
                firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[2]/input").SendKeys("https://coinsniper.net/login");
                firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[1]/select").Click();
                firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[1]/select/option[14]").Click();
                firefoxDriver.FindElementByXPath("/html/body/div[2]/main/div[1]/div/div[3]/form/div[2]/button").Click();
                Thread.Sleep(1000);

                // Logins To CoinSniper
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[1]/div/input").SendKeys(email); // Email
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[2]/div/input").SendKeys(emailPassword); // Email Password
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div/div/div/form/div[3]/div/input").Click();
                Thread.Sleep(1000);

                // Search Coin
                firefoxDriver.FindElementByXPath("/html/body/section[1]/div/nav/div[4]/div[1]/div[2]/div[1]/input").SendKeys(CoinName_TextBox.Text);

                // Click Coin
                firefoxDriver.FindElementByXPath("/html/body/section[1]/div/nav/div[4]/div[1]/div[2]/div[2]/a[1]").Click();
                Thread.Sleep(1000);

                // Recaptcha API SolverX Method


                // Vote Coin
                firefoxDriver.FindElementByXPath("/html/body/section[2]/div/div[2]/div/div[1]/div[6]/form/div/div[2]/button").Click();
                Thread.Sleep(1000);
                firefoxDriver.Close();
                firefoxDriver.Quit();
            }
        }
        private void SolverXCaptcha()
        {
            // SolverX
            // Firefox Driver Service
            FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();
            firefoxDriverService.HideCommandPromptWindow = true;

            // Firefox Driver
            FirefoxDriver firefoxDriver = new FirefoxDriver(firefoxDriverService);

            // Page URL
            string pageURL = "https://www.google.com/recaptcha/api2/demo";

            // API Key
            string apiKey = "YOUR API KEY";

            // DataSiteKey Captcha
            string dataSiteKey = "6Le-wvkSAAAAAPBMRTvw0Q4Muexq9bi0DJwx_mJ-";

            // Request String
            string firstRequest = $"https://2captcha.com/in.php?key={apiKey}&method=userrecaptcha&googlekey={dataSiteKey}&pageurl={pageURL}&json=1&invisible=1";

            // Server Response
            string responseFromServer;
            string responseFromServer2;

            // Goes To Website
            firefoxDriver.Navigate().GoToUrl(pageURL);

            // Web Request            
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(firstRequest);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }

            string operation = responseFromServer;
            int colonreapeat = 0;

            string jsonNumber = "";

            for (int i = 0; i < operation.Length; i++)
            {
                if (colonreapeat == 2)
                {
                    if (operation[i].ToString() != "}")
                    {
                        jsonNumber = jsonNumber + operation[i].ToString();
                    }
                }

                if (operation[i].ToString() == ":")
                {
                    colonreapeat++;
                }
            }

            string realJSONnumber = "";

            for (int i = 0; i < jsonNumber.Length; i++)
            {
                if (jsonNumber[i] != '"')
                {
                    realJSONnumber = realJSONnumber + jsonNumber[i];
                }
            }

            string secondRequest = $"https://2captcha.com/res.php?key={apiKey}&action=get&id={realJSONnumber}&json=1";
            // Close the response.
            response.Close();

            // Second Request 


            while (true)
            {
                // Create a request for the URL.
                WebRequest request2 = WebRequest.Create(secondRequest);
                // If required by the server, set the credentials.
                request2.Credentials = CredentialCache.DefaultCredentials;

                // Get the response.
                WebResponse response2 = request2.GetResponse();

                // Get the stream containing content returned by the server.
                // The using block ensures the stream is automatically closed.
                using (Stream dataStream = response2.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader2 = new StreamReader(dataStream);
                    // Read the content.
                    responseFromServer2 = reader2.ReadToEnd();
                    // Display the content.
                    Console.WriteLine(responseFromServer2);

                    if (responseFromServer2.Length > 100)
                    {
                        break;
                    }
                }

                // Close the response.
                response2.Close();

                System.Threading.Thread.Sleep(5000);
            }

            // Colon Repeater
            int colonRepeater2 = 0;

            // Real JSON FORMAT
            string realJSONFormat = "";

            for (int i = 0; i < responseFromServer2.Length; i++)
            {
                if (colonRepeater2 == 2)
                {
                    if (responseFromServer2[i] != '"' && responseFromServer2[i] != '}')
                    {
                        realJSONFormat = realJSONFormat + responseFromServer2[i].ToString();
                    }

                }

                if (responseFromServer2[i].ToString() == ":")
                {
                    colonRepeater2++;
                }
            }

            string writeToken = $"document.getElementById('g-recaptcha-response').innerHTML='{realJSONFormat}'";
            string submitJavascript = $"document.getElementById('recaptcha-demo-form').submit()";
            firefoxDriver.ExecuteScript(writeToken);
            System.Threading.Thread.Sleep(3000);
            firefoxDriver.ExecuteScript(submitJavascript);
            System.Threading.Thread.Sleep(3000);
        }
    }
}