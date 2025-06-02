using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class FirstMenu : IMenuItemListener
    {
        private Functions m_Functions;
        private MainMenu m_MainMenu;

        void IMenuItemListener.ActivateFunction(string i_FunctionName)
        {
            if (m_Functions == null)
            {
                m_Functions = new Functions();
            }

            switch (i_FunctionName)
            {
                case "Show Version":
                    m_Functions.ShowVersion();
                    break;
                case "Count Lowercase Letters":
                    m_Functions.CountLowerLetters();
                    break;
                case "Show Current Date":
                    m_Functions.ShowCurrentDate();
                    break;
                case "Show Current Time":
                    m_Functions.ShowCurrentTime();
                    break;
                default:
                    throw new System.ArgumentException("Invalid function name");
            }
        }

        public void RunFirstMenu()
        {
            MenuItem mainMenuItem = new MenuItem { Title = "Iterface Main Menu" };
            MenuItem versionMenuItem = new MenuItem { Title = "Show Version", IsActionItem = true, ActionListener = this };
            MenuItem dateMenuItem = new MenuItem { Title = "Show Current Date", IsActionItem = true, ActionListener = this };
            MenuItem timeMenuItem = new MenuItem { Title = "Show Current Time", IsActionItem = true, ActionListener = this };
            MenuItem lowerCaseMenuItem = new MenuItem { Title = "Count Lowercase Letters", IsActionItem = true, ActionListener = this };
            MenuItem lettersAndVersionSubMenu = new MenuItem { Title = "Letters and Version" };
            MenuItem dateTimeSubMenu = new MenuItem { Title = "Show Current Date/Time" };
            lettersAndVersionSubMenu.AddSubMenu(versionMenuItem);
            lettersAndVersionSubMenu.AddSubMenu(lowerCaseMenuItem);
            dateTimeSubMenu.AddSubMenu(dateMenuItem);
            dateTimeSubMenu.AddSubMenu(timeMenuItem);
            mainMenuItem.AddSubMenu(lettersAndVersionSubMenu);
            mainMenuItem.AddSubMenu(dateTimeSubMenu);
            m_MainMenu = new MainMenu();
            m_MainMenu.SetEntryMenu(mainMenuItem);
            m_MainMenu.Show();
        }
    }
}
