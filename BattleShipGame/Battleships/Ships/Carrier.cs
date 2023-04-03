using BattleShipGame.Enum;


namespace BattleShipGame.Battleships.Ships
{
    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Carrier";
            BattleShipType = BattleShipType.Carrier;
            Size = 5;
            Hits = 0;
        }
    }
}
