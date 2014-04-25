using System;
using System.Runtime.Serialization;

namespace DeserializeJson
{
	[DataContract]
	internal class Person
	{
		[DataMember]
		internal string name;

		[DataMember]
		internal int age;
	}
}

