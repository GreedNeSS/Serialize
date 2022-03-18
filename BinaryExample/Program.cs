using BinaryExample;

Console.WriteLine("***** Binary Serializer *****");

Person person = new Person
{
    Name = "Ruslan",
    Age = 30,
    Id = 2314
};

string fileName = "Bynary.dat";

BinarySerializer.SaveAsBynaryFormat(person, fileName);

Person? loadedPerson = BinarySerializer.LoadFromBinaryFile(fileName) as Person;

Console.WriteLine(loadedPerson?.Name);