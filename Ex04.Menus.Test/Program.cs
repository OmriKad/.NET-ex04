using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            FirstMenu firstMenu = new FirstMenu();
            SecondMenu secondMenu = new SecondMenu();
            try
            {
                firstMenu.RunFirstMenu();
                secondMenu.RunSecondMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}