using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment4
{
    
    public class EventManager
    {

        private double costPerPerson; // cost per participant
        private double feePerPerson; // fees to be paid by the guest (revenue)
        private string[] guestList; // names of guests
        private int guestCount = 0; // number of guests
        private string firstName; // fields to store guests data
        private string lastName;

        /// <summary>
        /// Constructor:
        /// Called when an instance of this object is being created 
        /// using the keyword new
        /// </summary>
        /// <param name="maxGuests">Parameter is setting the size of the guest list</param>
        public EventManager(int maxGuests)
        {
            guestList = new string[maxGuests];
            guestCount = 0;
        }


        // Get & Set methods and properties
        public string GetFirstName() => firstName;
        public void SetFirstName(string name) => firstName = name;

        public string GetLastName() => lastName;
        public void SetLastName(string name) => lastName = name;

        public double CostPerPerson
        {
            get 
            { 
                return costPerPerson; 
            }

            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        public double FeePerPerson
        {
            get 
            { 
                return feePerPerson; 
            }

            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        /// <summary>
        /// Add New Guest function which is checking free spots left and if there 
        /// spots left saving the guest to the list with last namne in upper case first
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>
        /// Returns true if the guest is successfully added or false if the guest list is full
        /// </returns>
        public bool AddNewGuest(string firstName, string lastName)
        {
            if (guestCount >= guestList.Length) return false;

            string formattedName = $"{lastName.ToUpper()}, {firstName}";
            guestList[guestCount++] = formattedName;
            return true;
        }

        /// <summary>
        /// Method removing guest by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns> Returns true if the guest was successfully removed 
        /// or false if the index is out of range.
        /// </returns>
        public bool RemoveGuest(int index)
        {
            if (index < 0 || index >= guestCount) return false;

            for (int i = index; i < guestCount - 1; i++)
            {
                guestList[i] = guestList[i + 1];
            }

            guestList[--guestCount] = null;
            return true;
        }

        /// <summary>
        /// Method for getting all current guests
        /// </summary>
        /// <returns>
        /// Returns string array containing the names of all current guests
        /// </returns>
        public string[] GetGuestList()
        {
            string[] currentGuests = new string[guestCount];
            Array.Copy(guestList, currentGuests, guestCount);
            return currentGuests;
        }

        /// <summary>
        /// Function for getting current guest count
        /// </summary>
        /// <returns>
        /// An integer of the total number of guests currently registered
        /// </returns>
        public int GetGuestCount()
        {
            return guestCount;
        }


        /// <summary>
        /// Function for getting total cost of all registered guests
        /// </summary>
        /// <returns>
        /// The total cost of the event calculated as the number of guests multiplied by the cost per person
        /// </returns>
        public double GetTotalCost()
        {
            return guestCount * costPerPerson;
        }

        /// <summary>
        /// Function for getting total fees (revenue) paid by guests
        /// </summary>
        /// <returns>
        /// The total revenue from guest fees which is number of guests multiplied by the fee per person
        /// </returns>
        public double GetTotalFees()
        {
            return guestCount * feePerPerson;
        }

        /// <summary>
        /// Function for getting results either surplus or deficit for the current event
        /// </summary>
        /// <returns>
        /// Financial result as a surplus (profit) or a deficit (loss).
        /// </returns>
        public double GetSurplusOrDeficit()
        {
            return GetTotalFees() - GetTotalCost();
        }

    }

}
