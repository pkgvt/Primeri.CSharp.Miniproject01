using System;

namespace Calculations
{
	public class Formula04
	{
		Colors.ForCLI _cl = new Colors.ForCLI ();


		//Формула за страничен ъгъл
		public Formula04 ()
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
						_cl.Default (); Console.Write ("Обема на страничния ъгъл е");
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
				double h=0; Double.TryParse ( _param[2],out h);
				double L=0; Double.TryParse ( _param[3],out L);


				_result = (a*h/2)*L;
				return true;

			}catch{
			}

			_result = 0;
			return false;
		}

		private void help ()
		{
			_cl.Result ();
			Console.Write ("[съгъл]");
			_cl.Default ();
			Console.WriteLine ("- страничен ъгъл");

			_cl.Command ();
			Console.Write ("параметри: ");
			_cl.Default ();
			Console.WriteLine ("a, h и L\n");

			_cl.Command ();
			Console.Write ("a и h");
			_cl.Default ();
			Console.WriteLine (" - ширина и височина");

			_cl.Command ();
			Console.Write ("L");
			_cl.Default ();
			Console.WriteLine (" - дължина\n");
		}
	}
}

