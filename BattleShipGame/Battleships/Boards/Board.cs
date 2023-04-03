using BattleShipGame.Enum;

namespace BattleShipGame.Battleships.Boards
{
    public abstract class Board
    {
        public BoardType BoardName { get; set; }
        public List<Cell> Cells { get; set; }
    }
}
