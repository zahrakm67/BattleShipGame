using BattleShipGame.Enum;

namespace BattleShipGame.Battleships.Boards
{
    public class Cell
    {
        public BattleShipType BattleShipType { get; set; }
        public ShotType ShotType { get; set; }
        public Coordinates Coordinates { get; set; }
        public Cell(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            BattleShipType = BattleShipType.Empty;
        }

        public bool IsOccupied
        {
            get
            {
                return BattleShipType != BattleShipType.Empty;
            }
        }
    }
}
