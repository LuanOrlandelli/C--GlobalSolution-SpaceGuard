namespace C_GlobalSolution_SpaceGuard.Structs;

public struct Coordenada
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public Coordenada(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public override string ToString()
    {
        return $"Latitude: {Latitude} | Longitude: {Longitude}";
    }
}