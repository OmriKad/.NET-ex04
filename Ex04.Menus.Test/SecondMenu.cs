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
            versionMenuItem.Clicked += actionItemWasClicked;
            MenuItem lowerCaseMenuItem = new MenuItem { Title = "Count Lowercase Letters", IsActionItem = true };
            lowerCaseMenuItem.Clicked += actionItemWasClicked;
            MenuItem dateMenuItem = new MenuItem { Title = "Show Current Date", IsActionItem = true };
            dateMenuItem.Clicked += actionItemWasClicked;
            MenuItem timeMenuItem = new MenuItem { Title = "Show Current Time", IsActionItem = true };
            timeMenuItem.Clicked += actionItemWasClicked;
            lettersAndVersionSubMenu.AddSubMenu(versionMenuItem);
            lettersAndVersionSubMenu.AddSubMenu(lowerCaseMenuItem);
            dateTimeSubMenu.AddSubMenu(dateMenuItem);
            dateTimeSubMenu.AddSubMenu(timeMenuItem);
            m_MainMenu = new MainMenu();
            m_MainMenu.SetEntryMenu(mainMenuItem);
            m_MainMenu.Show();
        }

        private void actionItemWasClicked(MenuItem i_Invoker)
        {
            switch (i_Invoker.Title)
            {
                case "Show Version":
                    r_Functions.ShowVersion();
                    break;
                case "Count Lowercase Letters":
                    r_Functions.CountLowerLetters();
                    break;
                case "Show Current Date":
                    r_Functions.ShowCurrentDate();
                    break;
                case "Show Current Time":
                    r_Functions.ShowCurrentTime();
                    break;
                default:
                    throw new System.ArgumentException("Invalid function name");
            }
        }
    }
}