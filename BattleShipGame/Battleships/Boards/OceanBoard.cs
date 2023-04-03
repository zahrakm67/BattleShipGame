using BattleShipGame.Enum;

namespace BattleShipGame.Battleships.Boards
{
    public class OceanBoard : Board
    {
        public OceanBoard()
        {
            BoardName = BoardType.OceanBoard;
            Cells = new List<Cell>();
        }
    }
}