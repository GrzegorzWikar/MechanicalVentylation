namespace MechanicalVentilation
{
    public partial class MainPage : ContentPage
    {
        public List<Floor> Floors { get; set; } = new List<Floor>();

        public MainPage()
        {
            InitializeComponent();

            Floors.Add(new Floor("Piwnica", new List<Room>
            {
                new Room
                {
                    Id=1,
                    Name = "Kotlownia",
                    SurfaceM2 = 2.5f,
                    RoomHeight = 3,
                    Cubage = 2.5f * 3,
                    Exchanges = 1,
                    DesignSupplyAirFlowRate = 2.5f * 3 *1,
                    DesignExhaustAirFlowRate = 2.5f * 3 *1,
                    AssumedSupplyAirFlowRate = 0,
                    AssumedExhaustAirFlowRate= 0
                },
                 new Room
                 {
                    Id=2,
                    Name = "Korytaz",
                    SurfaceM2 = 1,
                    RoomHeight = 3,
                    Cubage = 1 * 3,
                    Exchanges = 1,
                    DesignSupplyAirFlowRate = 1 * 3 *1,
                    DesignExhaustAirFlowRate = 1 * 3 *1,
                    AssumedSupplyAirFlowRate = 0,
                    AssumedExhaustAirFlowRate= 0
                 }
            }));

            Floors.Add(new Floor("Parter", new List<Room>
            {
                new Room
                {
                    Id=1,
                    Name = "Korytaz",
                    SurfaceM2 = 1,
                    RoomHeight = 3,
                    Cubage = 1 * 3,
                    Exchanges = 1,
                    DesignSupplyAirFlowRate = 1 * 3 *1,
                    DesignExhaustAirFlowRate = 1 * 3 *1,
                    AssumedSupplyAirFlowRate = 0,
                    AssumedExhaustAirFlowRate= 0
                },
                new Room
                {
                    Id=1,
                    Name = "Kuchnia",
                    SurfaceM2 = 10,
                    RoomHeight = 3,
                    Cubage = 10 * 3,
                    Exchanges = 1,
                    DesignSupplyAirFlowRate = 10 * 3 *1,
                    DesignExhaustAirFlowRate = 10 * 3 *1,
                    AssumedSupplyAirFlowRate = 0,
                    AssumedExhaustAirFlowRate= 0
                }
            }));

            BindingContext = this;
        }
    }
}
