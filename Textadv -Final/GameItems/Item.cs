namespace Program.GameItems
{
    public abstract class Item
    {
        public string Name { get; }


        protected Item(string name)
        {
            Name = name;
        }
    }
}