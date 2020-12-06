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
        private decimal CalculateDiscount(int duration)
        {
            if (duration > 2 && duration <= 6)
                return 0.1m;
            else if (duration <= 12)
                return 0.2m;
            else if (duration <= 18)
                return 0.25m;
            else if (duration <= 24)
                return 0.3333m;
            else if (duration <= 60)
                return 0.40m;
            else if (duration > 60)
                return 0.6666m;
            else
                return 0;
        }
        public int TermSummary(int duration)
        {
            const decimal BASECOST = 59m;

            int nextDiscountBracket;
            decimal grossMonth, grossFullTerm, nextTermPrice;

            if (duration > 2 && duration <= 6)
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
                nextDiscountBracket = 64;
            else
                nextDiscountBracket = 2;

            grossMonth = BASECOST * (1 - this.CalculateDiscount(duration));
            grossFullTerm = grossMonth * duration;
            nextTermPrice = BASECOST * nextDiscountBracket * (1 - this.CalculateDiscount(nextDiscountBracket));

            // Update labels
            PricePerMonthLabel.Text = grossMonth.ToString();
            PriceFullTermLabel.Text = grossFullTerm.ToString();
            PriceNextTermLabel.Text = nextTermPrice.ToString();

            return 1;
        }

    }
}
