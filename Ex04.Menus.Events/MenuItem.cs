using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string m_Title = "";
        private bool m_IsActionItem = false;
        public event Action Clicked = null;
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

        public void ExecuteAction()
        {
            if (IsActionItem)
            {
                OnClicked();
            }
            else
            {
                throw new InvalidOperationException("This menu item is not an action item.");
            }
        }

        protected virtual void OnClicked()
        {
            if (Clicked != null)
            {
                Clicked.Invoke();
            }
        }
    }
}