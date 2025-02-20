using CommunityToolkit.Mvvm.ComponentModel;


namespace MechanicalVentilation
{
    [ObservableObject]
    public partial class Floor : List<Room>
    {
        [ObservableProperty]
        string name;

        public Floor(string Name, List<Room> rooms) : base(rooms)
        {
            name = Name;
        }
    }
}
