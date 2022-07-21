

using MySmallCRM.Models;
using MySmallCRM.Repositories;
using MySmallCRM.Services;

Console.WriteLine("MySmallPerson");
PersonRepository personRepository = new PersonRepository();
PersonService personService = new PersonService(personRepository);

personService.CreateNewPerson("Konstantin", "Vaskin");

if (personService.CreateNewPerson("Xasiliy", "Pupopkin") == true)
{
    List<Person> persons = personService.GetAllPresons();
    foreach (Person person in persons)
    {
        Console.WriteLine(person.Id + " " + person.Name + " " + person.SurName );
    }
}



/*
 * Model
 * Service
 * Repositories ->CRUD Create Read Update Delete
 * 
 */

