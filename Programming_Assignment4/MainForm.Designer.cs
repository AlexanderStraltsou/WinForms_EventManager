namespace Programming_Assignment4
{
    partial class MainForm
    {
        
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtMaxGuests;
        private TextBox txtCostPerPerson;
        private TextBox txtFeePerPerson;
        private Label outLabelNumGuests;
        private Label outLabelTotalCost;
        private Label outLabelTotalFees;
        private Label outLabelSurplusDeficit;
        private ListBox lstGuests;
        private Button btnCreateList;
        private GroupBox groupAddGuest;


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 580);
            Text = "Event Organizer By Aliaksandr Straltsou";


            // Add New Event Box Area

            GroupBox groupNewEvent = new GroupBox
            {
                Text = "New Event",
                Location = new System.Drawing.Point(10, 15),
                Size = new System.Drawing.Size(250, 160)
            };

            Label lblMaxGuests = new Label
            {
                Text = "Max number of guests",
                Location = new System.Drawing.Point(10, 25)
            };
            this.txtMaxGuests = new TextBox
            {
                Location = new System.Drawing.Point(130, 25),
                Width = 100,
                Name = "txtMaxGuests"
            };

            Label lblCostPerPerson = new Label
            {
                Text = "Cost per person",
                Location = new System.Drawing.Point(10, 55)
            };
            this.txtCostPerPerson = new TextBox
            {
                Location = new System.Drawing.Point(130, 55),
                Width = 100,
                Name = "txtCostPerPerson"
            };

            Label lblFeePerPerson = new Label
            {
                Text = "Fee per person",
                Location = new System.Drawing.Point(10, 85)
            };
            this.txtFeePerPerson = new TextBox
            {
                Location = new System.Drawing.Point(130, 85),
                Width = 100,
                Name = "txtFeePerPerson"
            };

            Button btnCreateList = new Button
            {
                Text = "Create List",
                Location = new System.Drawing.Point(10, 115),
                Width = 220,
                Height = 30,
                Name = "btnCreateList"
            };

            btnCreateList.Click += btnCreateList_Click;

            groupNewEvent.Controls.Add(lblMaxGuests);
            groupNewEvent.Controls.Add(txtMaxGuests);
            groupNewEvent.Controls.Add(lblCostPerPerson);
            groupNewEvent.Controls.Add(txtCostPerPerson);
            groupNewEvent.Controls.Add(lblFeePerPerson);
            groupNewEvent.Controls.Add(txtFeePerPerson);
            groupNewEvent.Controls.Add(btnCreateList);
            this.Controls.Add(groupNewEvent);


            // Add New Guest Box Area
            this.groupAddGuest = new GroupBox
            {
                Text = "Add Guests",
                Location = new System.Drawing.Point(10, 180),
                Size = new System.Drawing.Size(250, 150),
                Name = "groupAddGuest",
                Enabled = false
            };

            Label lblFirstName = new Label
            {
                Text = "First Name",
                Location = new System.Drawing.Point(10, 40)
            };
            this.txtFirstName = new TextBox
            {
                Location = new System.Drawing.Point(110, 40),
                Width = 120,
                Name = "txtFirstName"
            };

            Label lblLastName = new Label
            {
                Text = "Last Name",
                Location = new System.Drawing.Point(10, 70)
            };
            this.txtLastName = new TextBox
            {
                Location = new System.Drawing.Point(110, 70),
                Width = 120,
                Name = "txtLastName"
            };

            Button btnAddGuest = new Button
            {
                Text = "Add Guest",
                Location = new System.Drawing.Point(10, 100),
                Width = 220,
                Height = 30,
                Name = "btnAddGuest"
            };

            groupAddGuest.Controls.Add(lblFirstName);
            groupAddGuest.Controls.Add(txtFirstName);
            groupAddGuest.Controls.Add(lblLastName);
            groupAddGuest.Controls.Add(txtLastName);
            groupAddGuest.Controls.Add(btnAddGuest);
            this.Controls.Add(groupAddGuest);

            btnAddGuest.Click += btnAddGuest_Click;


            // Summary Group Box Area
            GroupBox groupSummary = new GroupBox
            {
                Text = "Summary",
                Location = new System.Drawing.Point(10, 340),
                Size = new System.Drawing.Size(250, 150)
            };

            Label lblNumGuests = new Label
            {
                Text = "Number of guests",
                Location = new System.Drawing.Point(10, 30)
            };

            this.outLabelNumGuests = new Label
            {
                Location = new System.Drawing.Point(170, 30),
                Width = 80,
                
            };

            Label lblTotalCost = new Label
            {
                Text = "Total Cost",
                Location = new System.Drawing.Point(10, 60)
            };
            this.outLabelTotalCost = new Label
            {
                Location = new System.Drawing.Point(170, 60),
                Width = 80,

            };

            Label lblTotalFees = new Label
            {
                Text = "Total fees",
                Location = new System.Drawing.Point(10, 90)
            };
            this.outLabelTotalFees = new Label
            {
                Location = new System.Drawing.Point(170, 90),
                Width = 80,

            };

            Label lblSurplusDeficit = new Label
            {
                Text = "Surplus/deficit",
                Location = new System.Drawing.Point(10, 120),
                Width = 140
            };
            this.outLabelSurplusDeficit = new Label
            {
                Location = new System.Drawing.Point(170, 120),
                Width = 80,

            };

            groupSummary.Controls.Add(lblNumGuests);
            groupSummary.Controls.Add(outLabelNumGuests);
            groupSummary.Controls.Add(lblTotalCost);
            groupSummary.Controls.Add(outLabelTotalCost);
            groupSummary.Controls.Add(lblTotalFees);
            groupSummary.Controls.Add(outLabelTotalFees);
            groupSummary.Controls.Add(lblSurplusDeficit);
            groupSummary.Controls.Add(outLabelSurplusDeficit);
            this.Controls.Add(groupSummary);


            // Guest List Area
            Label lblGuestList = new Label
            {
                Text = "Guest List",
                Location = new System.Drawing.Point(270, 15)
            };
            this.Controls.Add(lblGuestList);


            this.lstGuests = new ListBox
            {
                Location = new System.Drawing.Point(270, 40),
                Size = new System.Drawing.Size(300, 455),
                Name = "listGuestList"
            };
            this.Controls.Add(lstGuests);


            Button btnRemoveGuest = new Button
            {
                Text = "Remove Guest",
                Location = new System.Drawing.Point(430, 500),
                Width = 140,
                Height = 30,
                Name = "btnRemoveGuest"
            };
            this.Controls.Add(btnRemoveGuest);

            btnRemoveGuest.Click += btnRemoveGuest_Click;
        }
        #endregion
    }
}
