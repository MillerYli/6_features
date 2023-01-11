using System;

namespace MyNamespace
{
	class MyClass
	{
		static void Main(string[] args)
		{
			User user= new User();

			user.Age = 23;

			Console.WriteLine(user.Age);
		}
	}
	

	class User
	{
		private int age;

		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if(value < 18)
				{
					Console.WriteLine("Возраст должен быть не менее 18 лет");
				}
				else
				{
					age = value;
				}
			}
		}
	} 
}
