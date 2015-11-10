using System;

namespace UserInput
{
	public class UInput
	{
		public Abaut.Me abaut= new Abaut.Me ();
		Colors.ForCLI _c = new Colors.ForCLI ();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary ();


		public UInput ()
		{            
			
		}

		public void sayHello()
		{
			_c.Default ();
			Console.WriteLine ("Добре дошли в " + abaut.shortName + "\n"+ abaut.version + "\n" );
		} 

		public void getUserCommands ()
		{
			string _command=" ";
			do
			{
				//Взимане на команда
				_c.Prompt ();    Console.Write("$ ");
				_c.Command (); _command = Console.ReadLine ();

				//Проверка за налични команди
				if (_command.ToLower().Contains("яма"))       _calc.F01.calc (_command);
				if (_command.ToLower().Contains("въгъл"))     _calc.F02.calc (_command);
				if (_command.ToLower().Contains("иъгъл"))     _calc.F03.calc (_command);

				if (_command.ToLower().Contains("помощ") ||
					_command.ToLower()== "п" )     			 _calc.commands ();

				if (_command.ToLower()== "изчисти" ||
					_command.ToLower()== "и" )

				{
					Console.Clear ();
					_c.Default ();
					Console.WriteLine ("Добре дошли в " + abaut.shortName + "\n"+ abaut.version + "\n" );

				}

								 
			}
			while (_command.ToLower() !="изход");
		}
		 

			public void justTesting()
		{
				Console.WriteLine ("Стартиране на  UserInput.UInput.justTesting ()");

		}
	}
}

