using System;
using System.Runtime.Serialization.Json;
using System.IO;
namespace SerializeJson
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Create a Person object and define valuues
			Person p = new Person();
			p.name = "John";
			p.age = 42;

			// Create a memory stream.
			MemoryStream stream = new MemoryStream();

			// Serialize object of type Person.
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

			// Write object to stream.
			serializer.WriteObject(stream, p);

			// Position stream to 0.
			stream.Position = 0;

			// Create a stream reader.
			StreamReader streamReader = new StreamReader(stream);

			// Output JSON data to console.
			Console.WriteLine (streamReader.ReadToEnd());
		}
	}
}
