namespace MechanicalVentilation
{
    public class Floor : List<Room>
    {
        public string Name { get; private set; }

        public Floor(string name, List<Room> rooms) : base(rooms)
        {
            Name = name;
        }
    }
}
