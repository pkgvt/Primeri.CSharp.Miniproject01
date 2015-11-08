using System;

namespace Calculations
{
	public class Formula03
	{
		private Colors.ForCLI _cl = new Colors.ForCLI ();
		public Formula03 ()
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
						_cl.Default (); Console.Write ("Обема на изпъкналия ъгъл е");
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


				_result = 2*a*b*h/3;
				return true;

			}catch{
			}

			_result = 0;
			return false;
		}

	private void help ()
	{
		_cl.Result ();	    Console.Write ("[иъгъл]");
		_cl.Default (); 	Console.WriteLine ("- изпъкнал ъгъл");

		_cl.Command (); 	Console.Write ("параметри: ");
		_cl.Default ();		Console.WriteLine ("a, b и h\n");

		_cl.Command ();      Console.Write ("a и b");
		_cl.Default ();      Console.WriteLine (" - ширина и дължина");

		_cl.Command ();      Console.Write ("h");
		_cl.Default ();		 Console.WriteLine (" - височина\n");
	}

	}
}

