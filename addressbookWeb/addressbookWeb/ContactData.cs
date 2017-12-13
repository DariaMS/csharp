namespace WebAddressbookTests
{
    internal class ContactData
    {
        private string firstname;
        private string lastname;
        private int dob;

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Dob { get; set; }

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