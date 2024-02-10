using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "mücahid";
person1.LastName = "okyay";
person1.DateOfBirthYear = 2000;
person1.NationalIdentity = 12345678910;



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);