using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.ComponentTest.Classes;

namespace WpfApp.ComponentTest.Resources
{
    public class DataResourse
    {
        public List<PersonInfo> Persons { get; } = new List<PersonInfo>();
        public DataResourse()
        {
            var faker = new Faker();

            

            for (int i = 0; i < 25; i++) 
            {
                string firstName = faker.Name.FirstName();
                string lastName = faker.Name.LastName();
                Persons.Add(new PersonInfo { FirstName = firstName, LastName = lastName });
                          
            }
        }
            

    }
}
