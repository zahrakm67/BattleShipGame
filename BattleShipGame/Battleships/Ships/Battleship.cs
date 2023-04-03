using BattleShipGame.Enum;

namespace BattleShipGame.Battleships.Ships
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            BattleShipType = BattleShipType.Battleship;
            Size = 4;
            Hits = 0;
        }
    }
}
