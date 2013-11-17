using System; //Use system
using System.IO; //Use system's input + output
using Gtk; //use GTK Sharp





namespace generator //name of space 
{
    class Program //name of class
    {
        static void Main(string[] args) //no need to explain
        {

			string name; //text string called name
			string footer = "MSAPP"; //text string called footer containing "MSAPP"
			int num; //integer (number) called num
			string file; //text string called file

			Menu: //Open gateway
			Console.ForegroundColor = ConsoleColor.Cyan; //Change console text
			Console.WriteLine ("What do you want to do?"); //Console Question
			Console.ForegroundColor = ConsoleColor.Red; //Change console text
			Console.WriteLine ("1) Export a name and a surname"); //Option 1
			Console.WriteLine ("2) Exit"); //Option 2
			num = int.Parse (Console.ReadLine ()); //Turn the received string to integer and call it num
			Console.ForegroundColor = ConsoleColor.Cyan; //Change console color
			if (num == 1) { //If the integer num is 1:
				Console.WriteLine ("Enter a name and a surname:"); //Say this <<
				name = Console.ReadLine (); //Get user's input
				Console.WriteLine ("How would you like the exported file to be called?"); //Say that <<
				file = Console.ReadLine(); //Input again
				System.IO.File.WriteAllText (@file + ".txt", footer + "          " +
				"" + name); /*System input / output make a file and write all the tex provided in it, the text is filename, + '.txt.
				//+ footer + 10 spoaces + enter + name string*/
				Console.ForegroundColor = ConsoleColor.Green; //color
				Console.WriteLine ("Exported!"); //say <<

				goto Menu; //goto gateway Menu

			} else if (num == 2) { //or if num is 2
				Environment.Exit (0); //close the environment with error code 0
			}
			else if(num == 6041){ //if num is 6041
				goto secretProgram; //goto gateway secretProgram
			}else { //if non of them
				goto Menu; //go to gateway menu
			}
			goto Menu; //goto gateway menu

			secretProgram: //start of the gateway
			goto secretProgram; //to avoid '}' being problematic (see MonoDevelop) return to the gateway


        }
    }
}
