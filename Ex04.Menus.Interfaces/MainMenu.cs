using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private MenuItem m_EntryMenu;

        public void SetEntryMenu(MenuItem i_Item)
        {
            m_EntryMenu = i_Item;
        }

        public void Show()
        {
            if (m_EntryMenu == null)
            {
                throw new System.InvalidOperationException("Entry menu is not set.");
            }

            ShowMenus(m_EntryMenu, 0);
        }

        private void ShowMenus(MenuItem i_CurrentItem, int i_CurrentLevel)
        {
            while (true)
            {
                int numOfSubItems = i_CurrentItem.GetNumOfSubItems();
                Console.Clear();
                Console.WriteLine($"** {i_CurrentItem.Title} **");
                Console.WriteLine("-----------------------------");
                for (int i = 0; i < numOfSubItems; i++)
                {
                    Console.WriteLine($"{i + 1}. {i_CurrentItem.GetSubItem(i).Title}");
                }

                Console.WriteLine(i_CurrentLevel == 0 ? "0. Exit" : "0. Back");

                Console.Write($"\nSelect an option: (0-{numOfSubItems}): ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int selectedOption) || selectedOption < 0 || selectedOption > numOfSubItems)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                    continue;
                }

                if (selectedOption == 0)
                {
                    break;
                }

                MenuItem selectedItem = i_CurrentItem.GetSubItem(selectedOption - 1);

                if (selectedItem.IsActionItem)
                {
                    if (selectedItem.ActionListener == null)
                    {
                        Console.WriteLine("This menu item does not have an action listener assigned.");
                        Console.ReadKey();
                        continue;
                    }

                    Console.Clear();
                    selectedItem.Execute();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    ShowMenus(selectedItem, i_CurrentLevel + 1);
                }
            }
        }
    }
}
