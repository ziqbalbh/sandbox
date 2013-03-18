using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBox
{
    public class PersonItem
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }

        public virtual ICollection<EmailItem> Emails { get; set; }

        public PersonItem() { this.Emails = new List<EmailItem>(); }
    }
}
