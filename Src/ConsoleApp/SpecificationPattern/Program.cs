
using SpecificationPattern.CustomSpecifications;
using SpecificationPattern.Entites;

var persons = new List<Person>()
{
     new(id:1,firstName:"test", lastName:"f1", age:37, registerDate:DateTime.Now, cityId:1) ,
     new(id:2,firstName:"test1", lastName:"f5", age:14, registerDate:DateTime.Now.AddYears(-1), cityId:1) ,
     new(id:3,firstName:"t7", lastName:"f4", age:28, registerDate:DateTime.Now, cityId:2) ,
     new(id:4,firstName:"tt8", lastName:"fggg8", age:17, registerDate:DateTime.Now.AddYears(-2), cityId:4) ,

};

var personlegaage = new PersonLegalAgeSpecification();
foreach (var item in persons)
    if (personlegaage.IsSatisfiedBy(item))
        Console.WriteLine($"{item.Id} {item.FirstName} {item.Age}");



var b =
         persons
         .Where(d =>
                      new PersonCurrentRegisterDateSpecification()
                      .IsSatisfiedBy(d)
                    )
         .ToList();
Console.ReadLine();



