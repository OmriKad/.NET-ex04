using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    public class SecondMenu
    {
        private readonly Functions r_Functions = new Functions();
        private MainMenu m_MainMenu;

        public void RunSecondMenu()
        {
            MenuItem mainMenuItem = new MenuItem { Title = "Events Main Menu" };
            MenuItem lettersAndVersionSubMenu = new MenuItem { Title = "Letters and Version" };
            MenuItem dateTimeSubMenu = new MenuItem { Title = "Show Current Date/Time" };
            mainMenuItem.AddSubMenu(lettersAndVersionSubMenu);
            mainMenuItem.AddSubMenu(dateTimeSubMenu);
            MenuItem versionMenuItem = new MenuItem { Title = "Show Version", IsActionItem = true };
            versionMenuItem.Clicked += r_Functions.ShowVersion;
            MenuItem lowerCaseMenuItem = new MenuItem { Title = "Count Lowercase Letters", IsActionItem = true };
            lowerCaseMenuItem.Clicked += r_Functions.CountLowerLetters;
            MenuItem dateMenuItem = new MenuItem { Title = "Show Current Date", IsActionItem = true };
            dateMenuItem.Clicked += r_Functions.ShowCurrentDate;
            MenuItem timeMenuItem = new MenuItem { Title = "Show Current Time", IsActionItem = true };
            timeMenuItem.Clicked += r_Functions.ShowCurrentTime;
            lettersAndVersionSubMenu.AddSubMenu(versionMenuItem);
            lettersAndVersionSubMenu.AddSubMenu(lowerCaseMenuItem);
            dateTimeSubMenu.AddSubMenu(dateMenuItem);
            dateTimeSubMenu.AddSubMenu(timeMenuItem);
            m_MainMenu = new MainMenu();
            m_MainMenu.SetEntryMenu(mainMenuItem);
            m_MainMenu.Show();
        }
    }
}