using MySmallCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySmallCRM.Repositories
{
    public class PersonRepository
    {
        private List<Person> _persons = new List<Person>();
        public List<Person> GetAll()
        {
            return _persons;
        }
        public void Create (Person person)
        {
            int newId = _persons.Count;
            person.Id = newId;
            _persons.Add(person);
        }
        public void Read (Person person)
        {

        }
        public void Update (Person person)
        {

        }
        public void Delete (int Id)
        {

        }
    }
}
