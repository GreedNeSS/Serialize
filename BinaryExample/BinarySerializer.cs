using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinaryExample
{
    internal class BinarySerializer
    {
        public static void SaveAsBynaryFormat(object objGraph, string filename)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                try
                {
                    binaryFormatter.Serialize(fs, objGraph);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Saved obj in binary format");
            }
        }

        public static object LoadFromBinaryFile(string filename)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = File.OpenRead(filename))
            {
                try
                {
                    object obj = binaryFormatter.Deserialize(fs);
                    Console.WriteLine("Saved obj in binary format");
                    return obj;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}
