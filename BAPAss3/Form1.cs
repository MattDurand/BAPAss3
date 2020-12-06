using System;
using System.Drawing;
using System.Windows.Forms;

namespace BAPAss3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        const int INCREMENT = 2, FORMWIDTH = 954, FORMSTARTHEIGHT = 380, FORMEXPANDHEIGHT = 620;
        const decimal ZEROTWOMONTH = 1m, THREESIXMONTH = 0.9m, SEVENTWELVEMONTH = 0.8m, THIRTEENEIGHTEENMONTH = 0.75m, NINETEENTWENTYFOUR = 0.66m, TWENTYFIVESIXTYMONTH = 0.6m, SIXTYPLUSMONTHS = 0.33m;
        int passwordAttempts = 2, requestedTerm = 0;

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

        private void PasswordSubmitButton_Click(object sender, EventArgs e)
        {
            // Login validation
            if (PasswordTextBox.Text == "ILuvVisualC#" || PasswordTextBox.Text == "admin")
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
                TermSummary(requestedTerm);
            }
            else
            {
                toolTip1.SetToolTip(this.TermTextBox, "Enter Client's requested term.");
            }

        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {

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
            }
            else
            {
                toolTip1.SetToolTip(this.ProceedButton, "Enter Client's requested term.");
            }

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
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
        }

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
        }

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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // MY METHODS
        public int TermSummary(int months)
        {
            decimal baseMonth = 59.00m;
            decimal grossMonth;
            decimal grossFullTerm;
            decimal nextTermPrice;

            if (months <= 2)
            {
                grossMonth = baseMonth * ZEROTWOMONTH;
                grossFullTerm = grossMonth * Convert.ToDecimal(months);
                nextTermPrice = (baseMonth * THREESIXMONTH) * 3;

                //Price Per Month
                PricePerMonthLabel.Text = grossMonth.ToString();
                //Price Full Term
                PriceFullTermLabel.Text = grossFullTerm.ToString();
                //Price @ Start Next Full Term
                PriceNextTermLabel.Text = nextTermPrice.ToString();

            }
            else if (months > 2 && months <= 6)
            {
                grossMonth = baseMonth * THREESIXMONTH;
                grossFullTerm = grossMonth * Convert.ToDecimal(months);
                nextTermPrice = (baseMonth * SEVENTWELVEMONTH) * 7;

                //Price Per Month
                PricePerMonthLabel.Text = grossMonth.ToString();
                //Price Full Term
                PriceFullTermLabel.Text = grossFullTerm.ToString();
                //Price @ Start Next Full Term
                PriceNextTermLabel.Text = nextTermPrice.ToString();
            }
            else if (months > 6 && months <= 12)
            {
                grossMonth = baseMonth * SEVENTWELVEMONTH;
                grossFullTerm = grossMonth * Convert.ToDecimal(months);
                nextTermPrice = (baseMonth * THIRTEENEIGHTEENMONTH) * 13;

                //Price Per Month
                PricePerMonthLabel.Text = grossMonth.ToString();
                //Price Full Term
                PriceFullTermLabel.Text = grossFullTerm.ToString();
                //Price @ Start Next Full Term
                PriceNextTermLabel.Text = nextTermPrice.ToString();
            }
            else if (months > 12 && months <= 18)
            {
                grossMonth = baseMonth * THIRTEENEIGHTEENMONTH;
                grossFullTerm = grossMonth * Convert.ToDecimal(months);
                nextTermPrice = (baseMonth * NINETEENTWENTYFOUR) * 19;

                //Price Per Month
                PricePerMonthLabel.Text = grossMonth.ToString();
                //Price Full Term
                PriceFullTermLabel.Text = grossFullTerm.ToString();
                //Price @ Start Next Full Term
                PriceNextTermLabel.Text = nextTermPrice.ToString();
            }
            else if (months > 18 && months <= 24)
            {
                grossMonth = baseMonth * NINETEENTWENTYFOUR;
                grossFullTerm = grossMonth * Convert.ToDecimal(months);
                nextTermPrice = (baseMonth * TWENTYFIVESIXTYMONTH) * 25;

                //Price Per Month
                PricePerMonthLabel.Text = grossMonth.ToString();
                //Price Full Term
                PriceFullTermLabel.Text = grossFullTerm.ToString();
                //Price @ Start Next Full Term
                PriceNextTermLabel.Text = nextTermPrice.ToString();
            }
            else if (months > 24 && months <= 60)
            {
                grossMonth = baseMonth * TWENTYFIVESIXTYMONTH;
                grossFullTerm = grossMonth * Convert.ToDecimal(months);
                nextTermPrice = (baseMonth * SIXTYPLUSMONTHS) * 61;

                //Price Per Month
                PricePerMonthLabel.Text = grossMonth.ToString();
                //Price Full Term
                PriceFullTermLabel.Text = grossFullTerm.ToString();
                //Price @ Start Next Full Term
                PriceNextTermLabel.Text = nextTermPrice.ToString();
            }
            else if (months > 60)
            {
                grossMonth = baseMonth * SIXTYPLUSMONTHS;
                grossFullTerm = grossMonth * Convert.ToDecimal(months);

                //Price Per Month
                PricePerMonthLabel.Text = grossMonth.ToString();
                //Price Full Term
                PriceFullTermLabel.Text = grossFullTerm.ToString();
                //Price @ Start Next Full Term
                PriceNextTermLabel.Text = grossFullTerm.ToString();

                label7.Text = "You've maximised savings!";
            }
            return 1;
        }

    }
}
