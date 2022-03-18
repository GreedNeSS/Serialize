// See https://aka.ms/new-console-template for more information
using XMLExample;

Console.WriteLine("***** XML Serialize *****");

Person person = new Person
{
    Name = "Ruslan",
    Age = 30,
    Company = new Company { Title = "Microsoft" },
    Id = 32581
};

string filename = "Person.xml";
XMLFornater.SaveAsXMLFormat(typeof(Person), person, filename);

Person? loadedPerson = XMLFornater.LoadFromXMLFormat<Person>(filename);
Console.WriteLine(loadedPerson);