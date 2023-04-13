using BattleShipGame.Battleships.Boards;
using BattleShipGame.Battleships.Game;
using BattleShipGame.Enum;
using Microsoft.AspNetCore.Mvc;

namespace BattleShipGame.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class BattleShipController : ControllerBase
    {
        public static Game battleShipGame { get; set; }
        private readonly ILogger<BattleShipController> _logger;

        public BattleShipController(ILogger<BattleShipController> logger)
        {
            _logger = logger;
            battleShipGame ??= new Game();
        }

        [HttpGet("Init")]
        public ActionResult Init()
        {
            battleShipGame.Player.CreateBoard();
            var result = battleShipGame.Player.PlaceShips();
            return Ok(result);
        }

        [HttpPost("Fire")]
        public ActionResult Fire([FromQuery] int row, [FromQuery] int column)
        {
            var coords = new Coordinates(row, column);
            var result = battleShipGame.Player.ProcessShot(coords);
            return Ok(((ShotType)result).ToString());
        }
    }
}