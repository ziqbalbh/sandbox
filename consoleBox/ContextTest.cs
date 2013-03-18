using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBox
{
    class ContextTest
    {
        public void CreateDatabaseTest()
        {
            using (var context = new BoxContext())
            {
                PersonItem person = new PersonItem();

                person.FirstName = "Zafar";
                person.LastName = "Iqbal";

                EmailItem email = new EmailItem();
                email.Address = "ziqbalbh" + "@" + "gmail.com";
                email.Label = "Personal";

                person.Emails.Add(email);

                context.PersonItems.Add(person);

                context.SaveChanges();
            }
        }
    }
}
