using BattleShipGame.Enum;

namespace BattleShipGame.Battleships.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            BattleShipType = BattleShipType.Destroyer;
            Size = 2;
            Hits = 0;
        }
    }
}