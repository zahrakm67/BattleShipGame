using BattleShipGame.Enum;

namespace BattleShipGame.Battleships.Ships
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            BattleShipType = BattleShipType.Cruiser;
            Size = 3;
            Hits = 0;
        }
    }
}