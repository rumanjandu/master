using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Valid(string mFirstName)
        {
            if (mFirstName.Length < 1)
            {
                return "First Name cannot be blank";
            }
            if (mFirstName.Length > 50)
            {
                return "First Name cannot be more than 50 characters";
            }
            else
            {
                return "";
            }

        }
    }
}