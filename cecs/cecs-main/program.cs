using System;
using System.IO;
using Gtk;





namespace generator
{
    class Program
    {
        static void Main(string[] args)
        {

			string name;
			string footer = "//MSAPP//";
			int num;
			string file;

			Menu:
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine ("What do you want to do?");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("1) Export a name and a surname");
			Console.WriteLine ("2) Exit");
			num = int.Parse (Console.ReadLine ());
			Console.ForegroundColor = ConsoleColor.Cyan;
			if (num == 1) {
				Console.WriteLine ("Enter a name and a surname:");
				name = Console.ReadLine ();
				Console.WriteLine ("How would you like the exported file to be called?");
				file = Console.ReadLine();
				System.IO.File.WriteAllText (@file + ".txt", footer + "          " +
				"" + name);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine ("Exported!");

				goto Menu;

			} else if (num == 2) {
				Environment.Exit (0);
			}
			else if(num == 6041){
				goto secretProgram;
			}else {
				goto Menu;
			}
			goto Menu;

			secretProgram:
			goto secretProgram;


        }
    }
}
