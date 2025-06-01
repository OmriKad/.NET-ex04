using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItem
    {
        private string m_Title = "";
        private bool m_IsActionItem = false;
        private IMenuItemListener m_Listener = null;
        private readonly List<MenuItem> r_SubItems = new List<MenuItem>();
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public bool IsActionItem
        {
            get { return m_IsActionItem; }
            set { m_IsActionItem = value; }
        }

        public IMenuItemListener ActionListener
        {
            get { return m_Listener; }
            set { m_Listener = value; }
        }

        public void Execute()
        {
            if (m_Listener != null)
            {
                m_Listener.ActivateFunction(m_Title);
            }
            else
            {
                throw new InvalidOperationException("No listener is set for this menu item.");
            }
        }

        public void AddSubMenu(MenuItem i_SubMenu)
        {
            if (i_SubMenu == null)
            {
                throw new ArgumentNullException(nameof(i_SubMenu), "Submenu cannot be null.");
            }

            r_SubItems.Add(i_SubMenu);
        }

        public int GetNumOfSubItems()
        {
            if (r_SubItems == null)
            {
                throw new InvalidOperationException("SubItems list is not initialized.");
            }

            return r_SubItems.Count;
        }

        public MenuItem GetSubItem(int i_Index)
        {
            if (i_Index < 0 || i_Index >= r_SubItems.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(i_Index), "Index is out of range.");
            }

            return r_SubItems[i_Index];
        }
    }
}
