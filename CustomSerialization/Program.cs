using CustomSerialization;
using System.Runtime.Serialization.Formatters.Binary;

Console.WriteLine("***** Custom Serialization *****\n");
string fileName1 = "String Data.dat";
string fileName2 = "Data.dat";


StringData data = new StringData();
BinaryFormatter binaryFormatter = new BinaryFormatter();

using (FileStream fs = new FileStream(fileName1, FileMode.Create))
{
    binaryFormatter.Serialize(fs, data);

    Console.WriteLine($"Saved {fileName1}");
}

BinaryFormatter formatter = new BinaryFormatter();

using (FileStream fs = File.OpenRead(fileName1))
{
    StringData loadData = (StringData)formatter.Deserialize(fs);

    Console.WriteLine($"Load {fileName1}");
    Console.WriteLine(loadData + "\n\n");
}

Data newData = new Data();

BinaryFormatter binaryFormatter2 = new BinaryFormatter();

using (FileStream fs = new FileStream(fileName2, FileMode.Create))
{
    binaryFormatter2.Serialize(fs, newData);

    Console.WriteLine($"Saved {fileName2}");
}

BinaryFormatter formatter2 = new BinaryFormatter();

using (FileStream fs2 = File.OpenRead(fileName2))
{
    Data loadData = (Data)formatter2.Deserialize(fs2);

    Console.WriteLine($"Load {fileName2}");
    Console.WriteLine(loadData);
}