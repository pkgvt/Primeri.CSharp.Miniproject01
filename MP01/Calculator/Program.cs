using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотека
		public UserInput.UInput uInput = new UserInput.UInput ();
		public Abaut.Me abaut = new Abaut.Me();

		public static void Main (string[] args)
		{
			

			MainClass _program = new MainClass ();


			// Форматиране на програмата 
			Console.Title = _program.abaut.shortName + ", " + _program.abaut.version;
			//Стартиране на програмата

			_program.uInput.sayHello ();
			_program.uInput.getUserCommands ();

		}
	}
}
