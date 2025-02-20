using CommunityToolkit.Mvvm.ComponentModel;

namespace MechanicalVentilation
{
    public partial class Room : ObservableObject
    {
        [ObservableProperty]
        int id;
        [ObservableProperty]
        string name;
        [ObservableProperty]
        float surfaceM2;
        [ObservableProperty]
        float roomHeight;
        [ObservableProperty]
        float cubage;
        [ObservableProperty]
        float exchanges;
        [ObservableProperty]
        float designSupplyAirFlowRate;
        [ObservableProperty]
        float designExhaustAirFlowRate;
        [ObservableProperty]
        float assumedSupplyAirFlowRate;
        [ObservableProperty]
        float assumedExhaustAirFlowRate;
    }
}
