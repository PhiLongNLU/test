using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // b1 = read data into file (.txt)

            // "string"
            string text;
            var fileStream = new FileStream(@"C:\Users\longp\source\repos\ConsoleApp1\ConsoleApp1\data.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
            RootObject deserialize = JsonConvert.DeserializeObject<RootObject>(text);

            // Convert object to JSON
            Console.WriteLine(deserialize.Search("1-19-1-").toString());
            // list<data>

            /* Student student = new Student();
              student.id = 1;
              student.name = "Test";
              string output = JsonConvert.SerializeObject(student);
              Console.WriteLine(output);
              Student deserialize = JsonConvert.DeserializeObject<Student>(output);
              Console.WriteLine(deserialize);*/

        }


    }
}
