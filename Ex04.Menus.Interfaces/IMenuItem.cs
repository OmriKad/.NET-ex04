namespace Ex04.Menus.Interfaces
{
    public interface IMenuItem
    {
        string Title { get; set; }
        bool IsActionItem { get; set; }
        void Execute();
    }
}
