using System;

namespace Colors
{
	public class ForCLI
	{
		public ForCLI ()
		{
		}
		public void Default ()
		{
			Console.ForegroundColor = ConsoleColor.Gray; 
		}

		public void Prompt()
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;	
		}
		public void Command ()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;	
		}
		public void Result()
		{
			Console.ForegroundColor = ConsoleColor.White;	
		}
	}
}

