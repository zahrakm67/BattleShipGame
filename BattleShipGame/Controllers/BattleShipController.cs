using BattleShipGame.Battleships.Boards;
using BattleShipGame.Battleships.Game;
using BattleShipGame.Enum;
using Microsoft.AspNetCore.Mvc;

namespace BattleShipGame.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
   // [ApiExplorerSettings(GroupName = "BattleShipV1")]
    public class BattleShipController : ControllerBase
    {
       
        public Game battleShipGame;
        private readonly ILogger<BattleShipController> _logger;

        public BattleShipController(ILogger<BattleShipController> logger)
        {
            _logger = logger;
            battleShipGame=new Game();
        }

       
        [HttpGet("Init")]
        public ActionResult Init()
        {
            battleShipGame.firstPlayer.CreateBoard();
           var result= battleShipGame.firstPlayer.PlaceShips();
            return Ok(result);

        }

        [HttpPost("Fire")]
        public ActionResult Fire([FromQuery] int row, [FromQuery] int column)
        {
            battleShipGame.firstPlayer.CreateBoard();
            battleShipGame.firstPlayer.PlaceShips();
            var coords = new Coordinates(row, column);
            var result = battleShipGame.firstPlayer.ProcessShot(coords);
            return Ok(((ShotType)result).ToString());
        }
    }
}