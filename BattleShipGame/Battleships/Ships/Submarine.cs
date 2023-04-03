using BattleShipGame.Enum;

namespace BattleShipGame.Battleships.Ships
{
    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            BattleShipType = BattleShipType.Submarine;
            Size = 3;
            Hits = 0;
        }
    }
}
