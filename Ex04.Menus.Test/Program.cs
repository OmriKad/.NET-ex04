using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            FirstMenu firstMenu = new FirstMenu();

            try
            {
                firstMenu.RunFirstMenu();
                // Uncomment the following lines to run the second menu
                // SecondMenu secondMenu = new SecondMenu();
                // secondMenu.RunSecondMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
