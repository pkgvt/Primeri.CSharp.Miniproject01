using System;

namespace Calculations
{
	public class Formula02
	{
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
						Console.Write ("Обема на вдлъбнатия ъгъл е");
						Console.Write (result.ToString("N2"));
						Console.WriteLine( "m3\n");

					}else{
						Console.WriteLine  ("Имате грешно въведени параметри.С параметъра '-п' можета\nда видите синтаксиса на командата\n");
					
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
			Console.Write ("[въгъл]");
			Console.WriteLine ("- вдлъбнат ъгъл");

			Console.Write ("параметри: ");
			Console.WriteLine ("a, b и h\n");

			Console.Write ("a и b");
			Console.WriteLine (" - ширина и дължина");

			Console.Write ("h");
			Console.WriteLine (" - височина\n");


		}
	}
}

