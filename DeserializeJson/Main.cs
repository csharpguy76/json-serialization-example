using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml;

namespace DeserializeJson
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Create a stream to read JSON content from a text file.
			FileStream stream = new FileStream("Person.json", FileMode.Open);

			// Serialize object of type Person.
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

			// Position stream to 0.
			stream.Position = 0;

			// Deserialize JSON data from stream
			Person p = (Person)serializer.ReadObject(stream);

			// Output deserialized JSON data to console.
			Console.WriteLine("Deserialize results:");
			Console.WriteLine("name = {0}", p.name);
			Console.WriteLine("age = {0}", p.age);
		}
	}
}
