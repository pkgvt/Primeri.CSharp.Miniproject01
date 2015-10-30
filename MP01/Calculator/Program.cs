using System;

namespace Calculator
{
	class MainClass
	{

		//Дефиниране на библиотеки
		public UserInput.UInput uInput = new UserInput.UInput (); 

		public static void Main (string[] args)


		{
			Console.WriteLine ("Hello World!");

			MainClass _program = new MainClass ();
			_program.uInput.justTesting ();
		}
	}
}
