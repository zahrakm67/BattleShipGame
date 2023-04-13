using BattleShipGame.Battleships.Boards;

namespace BattleShipGame.Battleships.Game
{
    public class Game
    {
        public Player Player { get; set; }


        public Game()
        {
            Player = new Player("Player");
        }


        public string Attack(Coordinates coordinates)
        {
            //Player 1 fires a shot and validates if the shot is hit/miss
            return Player.ProcessShot(coordinates).ToString();
        }
    }
}
