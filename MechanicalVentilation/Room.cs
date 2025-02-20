namespace MechanicalVentilation
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float SurfaceM2 { get; set; }
        public float RoomHeight { get; set; }
        public float Cubage { get; set; }
        public float Exchanges { get; set; }
        public float DesignSupplyAirFlowRate { get; set; }
        public float DesignExhaustAirFlowRate { get; set; }
        public float AssumedSupplyAirFlowRate { get; set; }
        public float AssumedExhaustAirFlowRate { get; set; }
    }
}
