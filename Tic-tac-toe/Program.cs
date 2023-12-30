using System;
using System.Windows.Forms;
using Tic_tac_toe.Forms;
namespace Tic_tac_toe
{
    public class Program
    {
        [STAThreadAttribute()]
       public static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartingWindow());
            
        }
    }
}