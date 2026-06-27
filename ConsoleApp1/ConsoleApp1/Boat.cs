using TransportChallenge;

namespace TransportChallenge
{
    public class Boat : Vehicle, ITransport
    {
        public override string Move() => "Sailing on the water.";
    }
}
