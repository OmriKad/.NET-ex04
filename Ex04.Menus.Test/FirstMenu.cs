namespace Ex04.Menus.Test
{
    public class FirstMenu : Menus.Interfaces.IMenuItemListener
    {
        private Functions m_Functions;

        public void ActivateFunction(string i_FunctionName)
        {
            if (m_Functions == null)
            {
                m_Functions = new Functions();
            }

            switch(i_FunctionName)
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


    }
}
