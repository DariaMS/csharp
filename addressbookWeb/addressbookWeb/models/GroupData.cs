using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupData :IEquatable<GroupData>
    {
        private string name;
        private string header = "";
        private string footer = "";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Header
        {
            get { return header; }
            set { header = value; }
        }

        public string Footer
        {
            get { return footer; }
            set { footer = value; }
        }

        //public string Header { get; set; }

        public GroupData(string name)
        {
            this.name = name;
        }

            public GroupData(string name, string header, string footer)
        {
            this.name = name;
            this.header = header;
            this.footer = footer;
        }

        public bool Equals(GroupData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name;
        }

        //equal elements have equal hashcodes
        //equal hashcodes do not mean equal elements
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
