using System;

namespace Calculations
{
	public class Formula02
	{
		Colors.ForCLI _cl = new Colors.ForCLI ();

		// Формула за вдлъбнат ъгъл
		public Formula02 ()
		{
		}

		public void calc (string _input)

		{
			try
			{
				string [] param = _input.Split (' ');

				if( param.Length > 1 && _input.ToLower().Contains(" -п"))
				{
					help ();
				}
				if( param.Length == 4)
				{
					double result =0;
					if(runCalculate (param, out result) )
					{
						_cl.Default (); Console.Write ("Обема на вдлъбнатия ъгъл е");
						_cl.Result ();  Console.Write (result.ToString("N2"));
						_cl.Default (); Console.WriteLine( "m3\n");

					}else{
						_cl.Default (); Console.WriteLine  ("Имате грешно въведени параметри.С параметъра '-п' можета\nда видите синтаксиса на командата\n");
					
					}

				}

			}catch{


		}
			}

		


		private bool runCalculate (string[] _param, out double _result)
		{
			try
			{
				double a=0; Double.TryParse ( _param[1],out a);
				double b=0; Double.TryParse ( _param[2],out b);
				double h=0; Double.TryParse ( _param[3],out h);


				_result = a*b*h/3;
				return true;

			}catch{
			}

			_result = 0;
			return false;
		}

		private void help ()
		{
			_cl.Result ();	    Console.Write ("[въгъл]");
			_cl.Default (); 	Console.WriteLine ("- вдлъбнат ъгъл");

			_cl.Command (); 	Console.Write ("параметри: ");
			_cl.Default ();		Console.WriteLine ("a, b и h\n");

			_cl.Command ();      Console.Write ("a и b");
			_cl.Default ();      Console.WriteLine (" - ширина и дължина");

			_cl.Command ();      Console.Write ("h");
			_cl.Default ();		 Console.WriteLine (" - височина\n");


		}
	}
}

