namespace WebAddressbookTests
{
    internal class ContactData
    {
        private string firstname;
        private string lastname;
        private int dob;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public ContactData(string firstname, string lastname, int dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dob = dob;
        }


    }
}