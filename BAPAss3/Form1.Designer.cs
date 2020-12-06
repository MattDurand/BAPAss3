﻿namespace BAPAss3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordSubmitButton = new System.Windows.Forms.Button();
            this.PricingPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PricePerMonthLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.PriceFullTermLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceNextTermLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ClientConfirmedTextBox = new System.Windows.Forms.TextBox();
            this.QuotePanel = new System.Windows.Forms.Panel();
            this.MembershipDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.JoinDayLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MembershipIDLabel = new System.Windows.Forms.Label();
            this.PricingGroupBox = new System.Windows.Forms.GroupBox();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TermTextBox = new System.Windows.Forms.NumericUpDown();
            this.PasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricingPictureBox)).BeginInit();
            this.QuotePanel.SuspendLayout();
            this.MembershipDetailsGroupBox.SuspendLayout();
            this.PricingGroupBox.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TermTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanel.Controls.Add(this.label1);
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Controls.Add(this.PasswordSubmitButton);
            this.PasswordPanel.Location = new System.Drawing.Point(180, 43);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(541, 70);
            this.PasswordPanel.TabIndex = 0;
            this.PasswordPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter Your Password ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(244, 24);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(123, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordSubmitButton
            // 
            this.PasswordSubmitButton.Location = new System.Drawing.Point(411, 22);
            this.PasswordSubmitButton.Name = "PasswordSubmitButton";
            this.PasswordSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.PasswordSubmitButton.TabIndex = 0;
            this.PasswordSubmitButton.Text = "&Submit";
            this.PasswordSubmitButton.UseVisualStyleBackColor = true;
            this.PasswordSubmitButton.Click += new System.EventHandler(this.PasswordSubmitButton_Click);
            // 
            // PricingPictureBox
            // 
            this.PricingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PricingPictureBox.Image")));
            this.PricingPictureBox.Location = new System.Drawing.Point(12, 37);
            this.PricingPictureBox.Name = "PricingPictureBox";
            this.PricingPictureBox.Size = new System.Drawing.Size(212, 250);
            this.PricingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PricingPictureBox.TabIndex = 1;
            this.PricingPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Base Price €59";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Requested Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price Per Month";
            // 
            // PricePerMonthLabel
            // 
            this.PricePerMonthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PricePerMonthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PricePerMonthLabel.Location = new System.Drawing.Point(143, 11);
            this.PricePerMonthLabel.Name = "PricePerMonthLabel";
            this.PricePerMonthLabel.Size = new System.Drawing.Size(75, 22);
            this.PricePerMonthLabel.TabIndex = 7;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(390, 41);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 3;
            this.DisplayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.DisplayButton, "Press to display pricing details");
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(14, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Price Full Term";
            // 
            // PriceFullTermLabel
            // 
            this.PriceFullTermLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PriceFullTermLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceFullTermLabel.Location = new System.Drawing.Point(143, 54);
            this.PriceFullTermLabel.Name = "PriceFullTermLabel";
            this.PriceFullTermLabel.Size = new System.Drawing.Size(75, 22);
            this.PriceFullTermLabel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price @ Start Next Full Term";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceNextTermLabel
            // 
            this.PriceNextTermLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PriceNextTermLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceNextTermLabel.Location = new System.Drawing.Point(143, 93);
            this.PriceNextTermLabel.Name = "PriceNextTermLabel";
            this.PriceNextTermLabel.Size = new System.Drawing.Size(75, 22);
            this.PriceNextTermLabel.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(42, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Your Sales Prompt Here";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Client Confirmed Term";
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(390, 263);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 15;
            this.ProceedButton.Text = "&Proceed";
            this.toolTip1.SetToolTip(this.ProceedButton, "Press to proceed with processing membership");
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ClientConfirmedTextBox
            // 
            this.ClientConfirmedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientConfirmedTextBox.Location = new System.Drawing.Point(270, 265);
            this.ClientConfirmedTextBox.Name = "ClientConfirmedTextBox";
            this.ClientConfirmedTextBox.Size = new System.Drawing.Size(100, 22);
            this.ClientConfirmedTextBox.TabIndex = 16;
            this.ClientConfirmedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuotePanel
            // 
            this.QuotePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuotePanel.Controls.Add(this.PricePerMonthLabel);
            this.QuotePanel.Controls.Add(this.PriceFullTermLabel);
            this.QuotePanel.Controls.Add(this.PriceNextTermLabel);
            this.QuotePanel.Controls.Add(this.label7);
            this.QuotePanel.Controls.Add(this.label6);
            this.QuotePanel.Controls.Add(this.label);
            this.QuotePanel.Controls.Add(this.label4);
            this.QuotePanel.Location = new System.Drawing.Point(247, 76);
            this.QuotePanel.Name = "QuotePanel";
            this.QuotePanel.Size = new System.Drawing.Size(232, 154);
            this.QuotePanel.TabIndex = 17;
            // 
            // MembershipDetailsGroupBox
            // 
            this.MembershipDetailsGroupBox.Controls.Add(this.ConfirmButton);
            this.MembershipDetailsGroupBox.Controls.Add(this.label12);
            this.MembershipDetailsGroupBox.Controls.Add(this.JoinDayLabel);
            this.MembershipDetailsGroupBox.Controls.Add(this.EmailTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label11);
            this.MembershipDetailsGroupBox.Controls.Add(this.TelephoneTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label9);
            this.MembershipDetailsGroupBox.Controls.Add(this.FullNameTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label5);
            this.MembershipDetailsGroupBox.Controls.Add(this.label10);
            this.MembershipDetailsGroupBox.Controls.Add(this.MembershipIDLabel);
            this.MembershipDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipDetailsGroupBox.Location = new System.Drawing.Point(540, 12);
            this.MembershipDetailsGroupBox.Name = "MembershipDetailsGroupBox";
            this.MembershipDetailsGroupBox.Size = new System.Drawing.Size(369, 245);
            this.MembershipDetailsGroupBox.TabIndex = 4;
            this.MembershipDetailsGroupBox.TabStop = false;
            this.MembershipDetailsGroupBox.Text = "Member Details";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(156, 216);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 18;
            this.ConfirmButton.Text = "C&onfirm";
            this.toolTip1.SetToolTip(this.ConfirmButton, "Press to enter client details");
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(47, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Joining Date";
            // 
            // JoinDayLabel
            // 
            this.JoinDayLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.JoinDayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoinDayLabel.Location = new System.Drawing.Point(201, 65);
            this.JoinDayLabel.Name = "JoinDayLabel";
            this.JoinDayLabel.Size = new System.Drawing.Size(120, 22);
            this.JoinDayLabel.TabIndex = 21;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(201, 181);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '*';
            this.EmailTextBox.Size = new System.Drawing.Size(121, 20);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(47, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email Address";
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(201, 144);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.PasswordChar = '*';
            this.TelephoneTextBox.Size = new System.Drawing.Size(120, 20);
            this.TelephoneTextBox.TabIndex = 16;
            this.TelephoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(47, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telephone Number";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(201, 103);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.PasswordChar = '*';
            this.FullNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(47, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Full Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(47, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Membership ID";
            // 
            // MembershipIDLabel
            // 
            this.MembershipIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MembershipIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MembershipIDLabel.Location = new System.Drawing.Point(201, 31);
            this.MembershipIDLabel.Name = "MembershipIDLabel";
            this.MembershipIDLabel.Size = new System.Drawing.Size(120, 22);
            this.MembershipIDLabel.TabIndex = 14;
            // 
            // PricingGroupBox
            // 
            this.PricingGroupBox.Controls.Add(this.TermTextBox);
            this.PricingGroupBox.Controls.Add(this.DisplayButton);
            this.PricingGroupBox.Controls.Add(this.ProceedButton);
            this.PricingGroupBox.Controls.Add(this.label2);
            this.PricingGroupBox.Controls.Add(this.label3);
            this.PricingGroupBox.Controls.Add(this.ClientConfirmedTextBox);
            this.PricingGroupBox.Controls.Add(this.QuotePanel);
            this.PricingGroupBox.Controls.Add(this.label8);
            this.PricingGroupBox.Controls.Add(this.PricingPictureBox);
            this.PricingGroupBox.Location = new System.Drawing.Point(26, 12);
            this.PricingGroupBox.Name = "PricingGroupBox";
            this.PricingGroupBox.Size = new System.Drawing.Size(498, 314);
            this.PricingGroupBox.TabIndex = 18;
            this.PricingGroupBox.TabStop = false;
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(26, 340);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(498, 220);
            this.SummaryGroupBox.TabIndex = 19;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary Data";
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(540, 340);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(369, 220);
            this.SearchGroupBox.TabIndex = 20;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.SearchButton);
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Controls.Add(this.SummaryButton);
            this.ButtonPanel.Controls.Add(this.ClearButton);
            this.ButtonPanel.Location = new System.Drawing.Point(540, 275);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(369, 51);
            this.ButtonPanel.TabIndex = 21;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(187, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "S&earch";
            this.toolTip1.SetToolTip(this.SearchButton, "Press to bring up functionality to search records");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(272, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to exit application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(102, 16);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(75, 23);
            this.SummaryButton.TabIndex = 1;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Press to show summary of company sales ");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(17, 16);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.ClearButton, "Press to clear form");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // TermTextBox
            // 
            this.TermTextBox.Location = new System.Drawing.Point(270, 44);
            this.TermTextBox.Name = "TermTextBox";
            this.TermTextBox.Size = new System.Drawing.Size(100, 20);
            this.TermTextBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 581);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.PricingGroupBox);
            this.Controls.Add(this.MembershipDetailsGroupBox);
            this.Controls.Add(this.PasswordPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Welcome to Halo Fitness";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricingPictureBox)).EndInit();
            this.QuotePanel.ResumeLayout(false);
            this.QuotePanel.PerformLayout();
            this.MembershipDetailsGroupBox.ResumeLayout(false);
            this.MembershipDetailsGroupBox.PerformLayout();
            this.PricingGroupBox.ResumeLayout(false);
            this.PricingGroupBox.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TermTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button PasswordSubmitButton;
        private System.Windows.Forms.PictureBox PricingPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.TextBox ClientConfirmedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel QuotePanel;
        private System.Windows.Forms.Label PricePerMonthLabel;
        private System.Windows.Forms.Label PriceFullTermLabel;
        private System.Windows.Forms.Label PriceNextTermLabel;
        private System.Windows.Forms.GroupBox MembershipDetailsGroupBox;
        private System.Windows.Forms.Label MembershipIDLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label JoinDayLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox PricingGroupBox;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown TermTextBox;
    }
}

