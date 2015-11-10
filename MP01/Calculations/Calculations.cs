using System;

namespace Calculations
{
	public class MainLibrary
	{
		//Дефиниции
		public Formula01 F01 = new Formula01 ();
		public Formula02 F02 = new Formula02 ();
		public Formula03 F03 = new Formula03 ();

		//Библиотеки

		private Colors.ForCLI _cl = new Colors.ForCLI ();

		public MainLibrary ()
		{
		}

		public void commands ()
		{
			_cl.Default (); Console.WriteLine("Налични команди\n");

			_cl.Command (); Console.Write ("[яма]");
			_cl.Default (); Console.WriteLine(" - пресмятане на строителна яма");

			_cl.Command (); Console.Write ("[въгъл]");
			_cl.Default (); Console.WriteLine(" - пресмятане на вдлъбнат ъгъл");

			_cl.Command (); Console.Write ("[иъгъл]");
			_cl.Default (); Console.WriteLine(" - пресмятане на изпъкнал ъгъл\n");

		}

	}

}



