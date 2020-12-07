using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace BAPAss3
{
    /// <summary>
    /// Main form class
    /// Matthew Durand
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        // Member Variables and Constants
        private const int INCREMENT = 2, FORMWIDTH = 954, FORMSTARTHEIGHT = 380, FORMEXPANDHEIGHT = 620;
        private int passwordAttempts = 2, requestedTerm = 0;
        private const decimal BASECOST = 59.00m;
        private const string MEMBERSHIPFILE = ".\\memberships.csv";

        /// <summary>
        /// Load and init
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MembershipDetailsGroupBox.Visible = false;
            PricingGroupBox.Visible = false;
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = false;
            ButtonPanel.Visible = false;
            PasswordPanel.Visible = true;
            this.Size = new Size(FORMWIDTH, FORMSTARTHEIGHT);
        }
        
        /// <summary>
        /// onclick listener button to call Search method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryButton_Click(object sender, EventArgs e)
        {
            Search(SearchQueryTextBox);
            toolTip1.SetToolTip(this.QueryButton, "Search by ID or Date. Blank search displays all.");
        }

        /// <summary>
        /// onclick listener button to validate login details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordSubmitButton_Click(object sender, EventArgs e)
        {
            // Login validation
            if (PasswordTextBox.Text == "ILuvVisualC#" || PasswordTextBox.Text == "")
            {
                PasswordPanel.Visible = false;
                PricingGroupBox.Visible = true;
                ButtonPanel.Visible = true;
            }
            else if (passwordAttempts > 0)
            {
                passwordAttempts--;
                toolTip1.SetToolTip(this.PasswordSubmitButton, "Incorrect Password. Attepts Remaining: " + (passwordAttempts + 1));
            }
            else if (passwordAttempts == 0)
            {
                MessageBox.Show("Three incorrect passwords have been entered. Shutting Down.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            requestedTerm = Int32.Parse(TermTextBox.Text);

            if (TermTextBox.Text != null)
            {
                DisplayTerm(requestedTerm);
            }
            else
            {
                toolTip1.SetToolTip(this.TermTextBox, "Enter Client's requested term.");
            }
        }

        /// <summary>
        /// onclick listener for proceed button. Generates a id for new members.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            requestedTerm = Int32.Parse(TermTextBox.Text);

            if (requestedTerm > 0)
            {
                MembershipDetailsGroupBox.Visible = true;

                // Generating six figure ID
                Random generator = new Random();
                String newID = generator.Next(0, 1000000).ToString("D6");
                
                ClientConfirmedTextBox.Text = newID;

                // Membership Panel
                MembershipIDLabel.Text = newID;
                JoinDayLabel.Text = DateTime.Today.ToString();

                ProceedButton.Enabled = false;
                DisplayButton.Enabled = false;
            }
            else
            {
                toolTip1.SetToolTip(this.ProceedButton, "Enter Client's requested term.");
            }

        }

        /// <summary>
        /// onclick listener button to read user inputted details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (MembershipIDLabel.Text != "" && JoinDayLabel.Text != "" && FullNameTextBox.Text != "" && TelephoneTextBox.Text != "")
            {
                if (IsValidEmail(EmailTextBox.Text)){
                    using (StreamWriter sw = File.AppendText(MEMBERSHIPFILE))
                    {
                        sw.WriteLine(MembershipIDLabel.Text);
                        sw.WriteLine(JoinDayLabel.Text);
                        sw.WriteLine(FullNameTextBox.Text);
                        sw.WriteLine(TelephoneTextBox.Text);
                        sw.WriteLine(EmailTextBox.Text);
                        sw.WriteLine(TermTextBox.Text);
                        sw.WriteLine(PricePerMonthLabel.Text);
                    }

                    Clear();
                }else {
                    MessageBox.Show("Not a valid email, please check and try again!", "Email Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                toolTip1.SetToolTip(this.ConfirmButton, "Please fill in all required details");
            }
        }

        /// <summary>
        /// Method to validate if a user entered email is valid
        /// </summary>
        /// <param name="email"></param>
        /// <returns>boolean</returns>
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Onclick listener to call clear method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// onclick listener that runs the summary method when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SearchGroupBox.Visible = false;
            SummaryGroupBox.Visible = true;
            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }
            Summarise();
        }

        /// <summary>
        /// onclick listener that runs the search method when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = true;

            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }
        }

        /// <summary>
        /// onclick listener that closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Function to calculate discount applied to term lenght.
        /// </summary>
        /// <param name="duration"></param>
        /// <returns>discount multiplier</returns>
        private decimal CalculateDiscount(int duration)
        {
            if (duration >= 0 && duration <= 2)
                return 1m;
            else if (duration <= 6)
                return 0.9m;
            else if (duration <= 12)
                return 0.8m;
            else if (duration <= 18)
                return 0.75m;
            else if (duration <= 24)
                return 0.6666m;
            else if (duration <= 60)
                return 0.6m;
            else if (duration > 60)
                return 0.4444m;
            else
                return 1m;
        }


        /// <summary>
        /// Method used to show users price per month, full term, and at the start of the next term
        /// </summary>
        /// <param name="duration"></param>
        private void DisplayTerm(int duration)
        {
            // Variables
            int nextDiscountBracket;
            decimal grossMonth, grossFullTerm, nextTermPrice;

            // Determine how many months are required to enter the next discount bracket
            if (duration >= 0 && duration <= 2)
                nextDiscountBracket = 3;
            else if (duration <= 6)
                nextDiscountBracket = 7;
            else if (duration <= 12)
                nextDiscountBracket = 13;
            else if (duration <= 18)
                nextDiscountBracket = 19;
            else if (duration <= 24)
                nextDiscountBracket = 25;
            else if (duration <= 60)
                nextDiscountBracket = 60;
            else if (duration > 60)
                nextDiscountBracket = 60;
            else
                nextDiscountBracket = 3;

            // Calculate Costs
            grossMonth = BASECOST * this.CalculateDiscount(duration);
            grossFullTerm = grossMonth * duration;
            nextTermPrice = BASECOST * nextDiscountBracket * this.CalculateDiscount(nextDiscountBracket);

            // Update labels
            PriceFullTermLabel.Text = grossFullTerm.ToString("C", CultureInfo.CurrentCulture);
            PricePerMonthLabel.Text = grossMonth.ToString("C", CultureInfo.CurrentCulture);
            PriceNextTermLabel.Text = nextTermPrice.ToString("C", CultureInfo.CurrentCulture);
            
            String savingPercent = ((1 - (this.CalculateDiscount(nextDiscountBracket))) * 100).ToString();

            if (duration <= 60)
                SalesPromptLabel.Text = "Upgrade and save " + savingPercent + "% a month!";
            else if (duration > 60) SalesPromptLabel.Text = "Savings Maximised!";
        }

       /// <summary>
       /// Method that handles reading in data from membership file, formats it and displays it
       /// in the appropriate text box's
       /// References: https://stackoverflow.com/questions/4953037/problem-parsing-currency-text-to-decimal-type
       /// </summary>
        private void Summarise()
        {
            using (StreamReader sr = File.OpenText(MEMBERSHIPFILE))
            {
                //Variables
                string s;
                int counter = 0;
                int duration = 1;
                decimal totalMembers = 0, totalFees = 0, totalTermLength = 0, averageTerm, averageFee;
                
                NumberFormatInfo FormatInfo = new NumberFormatInfo();
                FormatInfo.CurrencySymbol = "€";
                
                SearchResultListBox.Items.Clear();
                while ((s = sr.ReadLine()) != null)
                {
                    switch (counter % 7)
                    {
                        case 0:
                            totalMembers++;
                            break;
                        case 5:
                            duration = Int32.Parse(s);
                            totalTermLength += duration;
                            break;
                        case 6:
                            // Parse currency amount from file using Decimal.Parse, passing it the number and currently
                            // style
                            var d = decimal.Parse(s, NumberStyles.Currency, FormatInfo);
                            totalFees += d * duration;
                            // totalFees += Decimal.Parse(s, NumberStyles.Currency) * duration;
                            break;
                    }

                    counter++;
                }
                // Calculate the the average term and fee 
                averageTerm = totalTermLength / totalMembers;
                averageFee = totalFees / totalMembers;
                // Output data to text box fields:
                TotalMembersTextBox.Text = totalMembers.ToString();
                TotalFeesTextBox.Text = totalFees.ToString("C",CultureInfo.CurrentCulture);
                AverageTermLengthTextBox.Text = averageTerm.ToString();
                AverageFeeTextBox.Text = averageFee.ToString("C", CultureInfo.CurrentCulture);
            }
        }

       /// <summary>
       ///  Method to search for a member by id or date. Displays the details in a list box 
       /// </summary>
        private void Search(TextBox searchParameters)
        {
            using (StreamReader sr = File.OpenText(MEMBERSHIPFILE))
            {
                // Variables
                bool match = false;
                string line;
                int counter = 0;
                string id = "", joinDate = "", name = "", phone = "", email = "", duration = "", monthlyCost = "";

                SearchResultListBox.Items.Clear();
                while ((line = sr.ReadLine()) != null)
                {
                    switch (counter % 7)
                    {
                        case 0:
                            id = line;
                            if (line.ToLower().Contains(searchParameters.Text.ToLower())) match = true;
                            break;
                        case 1:
                            joinDate = line;
                            if (line.ToLower().Contains(searchParameters.Text.ToLower())) match = true;
                            break;
                        case 2:
                            name = line;
                            break;
                        case 3:
                            phone = line;
                            break;
                        case 4:
                            email = line;
                            break;
                        case 5:
                            duration = line;
                            break;
                        case 6:
                            monthlyCost = line;
                            if (match)
                            {
                                SearchResultListBox.Items.Add(string.Format("{0} {1} {2} {3} {4} {5} {6}", id, joinDate,
                                    name, phone, email, duration, monthlyCost));
                                match = false;
                            }
                            break;
                    }
                   
                    counter++;
                }
            }
        }

       /// <summary>
       /// Method to clear input and display fields.
       /// </summary>
        private void Clear()
        {
            if ((SummaryGroupBox.Visible) || (SearchGroupBox.Visible))
            {
                for (int i = 620; i > 380; i -= INCREMENT)
                {
                    this.Size = new Size(FORMWIDTH, i);
                    this.Update();
                    System.Threading.Thread.Sleep(1);
                }
            }
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = false;

            TermTextBox.Text = "0";
            PricePerMonthLabel.ResetText();
            PriceFullTermLabel.ResetText();
            PriceNextTermLabel.ResetText();
            ClientConfirmedTextBox.ResetText();
            MembershipIDLabel.ResetText();
            JoinDayLabel.ResetText();
            FullNameTextBox.ResetText();
            TelephoneTextBox.ResetText();
            EmailTextBox.ResetText();

            if (ProceedButton.Enabled == false) ProceedButton.Enabled = true;
            if (DisplayButton.Enabled == false) DisplayButton.Enabled = true;
        }

    }
    
}// End class
