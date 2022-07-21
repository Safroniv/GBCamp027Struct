using MySmallCRM.Models;
using MySmallCRM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySmallCRM.Services
{
    //private readonly PersonRepository _repository;
    public class PersonService
    {
        private PersonRepository _repository;

        public PersonService (PersonRepository repository)
        {
            _repository = repository;
        }
        public bool CreateNewPerson(string name, string surname)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                return false;
            }

            Person person = new Person();
            person.Name = name;
            person.SurName = surname;

            _repository.Create(person);
            return true;
        }
        public List<Person> GetAllPresons()
        {
            return _repository.GetAll();
        }
    }

}
