using System;
using System.Windows.Forms;

namespace Programming_Assignment4
{
    public partial class MainForm : Form
    {
        
        private EventManager eventManager;
        
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Function is preparing application for start, 
        /// clearing the inputs and setting start values for the results 
        /// and making sure the "add guest" box is locked.
        /// </summary>
        private void InitializeGUI()
        {
            Text = "Event Organizer By Aliaksandr Straltsou";
            groupAddGuest.Enabled = false;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMaxGuests.Clear();
            txtCostPerPerson.Clear();
            txtFeePerPerson.Clear();
            outLabelNumGuests.Text = "0";
            outLabelTotalCost.Text = "0.00";
            outLabelTotalFees.Text = "0.00";
            outLabelSurplusDeficit.Text = "0.00";
        }

   
        /// <summary>
        /// Function for creating a list which is firstly trying to parse the users inputs then
        /// after successfull parsing and validation creating a new list, unlocking "add guest" box and clearing the UI
        /// If inputs are invalid user will be noticed about the error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateList_Click(object sender, EventArgs e)
        {

            // Validating and parsing inputs
            if (int.TryParse(txtMaxGuests.Text, out int maxGuests) &&
                double.TryParse(txtCostPerPerson.Text, out double cost) &&
                double.TryParse(txtFeePerPerson.Text, out double fee))
            {
                
                eventManager = new EventManager(maxGuests)
                {
                    CostPerPerson = cost,
                    FeePerPerson = fee
                };

                // Pop-Up Message that confirms that the event is succesfully created
                MessageBox.Show($"Event created successfully for {maxGuests} guests.", "Success");


                // Activating the "add guest box" for adding new guests
                groupAddGuest.Enabled = true;

                // Updating the UI after submitting information
                txtMaxGuests.Clear();
                txtCostPerPerson.Clear();
                txtFeePerPerson.Clear();
            }
            else
            {
                // An error pop-up message indicating that inputs are not valid
                MessageBox.Show("Please enter valid values (numbers) for Max Guests, Cost, and Fee.", "Input Error");
            }
        }


        /// <summary>
        /// Function for adding a new guest to the list as soon as Add button is clicked and inputs are validated
        /// After successfull attemt the guest list and summary will be updated according to changes in event manager
        /// Input fields are also cleared after submitting the guest info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddGuest_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter both First Name and Last Name");
                return;
            }
            
            eventManager.SetFirstName(txtFirstName.Text);
            eventManager.SetLastName(txtLastName.Text);
            

            if (eventManager.AddNewGuest(eventManager.GetFirstName(), eventManager.GetLastName()))
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                UpdateGuestList();
                UpdateSummary();
            }
            else
            {
                MessageBox.Show("Guest list is full, remove registered guests or create another event!");
            }
        }

        /// <summary>
        /// Function for removing "marked" guest from the list as soon as Remove button in UI is clicked
        /// After successfull attemt the guest list and summary will be updated according to changes in event manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {
            ListBox lstGuests = this.Controls.Find("listGuestList", true).FirstOrDefault() as ListBox;
            if (lstGuests.SelectedIndex >= 0)
            {
                eventManager.RemoveGuest(lstGuests.SelectedIndex);
                UpdateGuestList();
                UpdateSummary();
            }
            else
            {
                MessageBox.Show("Please select a guest to remove");
            }
        }

        /// <summary>
        /// Function for getting current list from event manager
        /// </summary>
        private void UpdateGuestList()
        {
            lstGuests.Items.Clear();
            foreach (var guest in eventManager.GetGuestList())
            {
                lstGuests.Items.Add(guest);
            }
        }


        /// <summary>
        /// Function for updating results according to recent changes in event manager
        /// </summary>
        private void UpdateSummary()
        {
           
            int numOfGuests = eventManager.GetGuestCount();
            double surplusDeficit = eventManager.GetSurplusOrDeficit();
            double totalFees = eventManager.GetTotalFees();
            double totalCost = eventManager.GetTotalCost();

            outLabelNumGuests.Text = numOfGuests.ToString();
            outLabelTotalCost.Text = totalCost.ToString("N2");
            outLabelTotalFees.Text = totalFees.ToString("N2");
            outLabelSurplusDeficit.Text = surplusDeficit.ToString("N2");

        }
    }
}
