using BattleShipGame.Battleships.Boards;
using BattleShipGame.Enum;
using System.ComponentModel.DataAnnotations;

namespace BattleShipGame.Battleships.Ships
{
    public abstract class Ship
    {
        [Required]
        [Display(Name = "Ship Name")]
        public string Name { get; set; }

        public BattleShipType BattleShipType { get; set; }

        public int Size { get; set; }

        public int Hits { get; set; }

        //public int IsMissed
        //{
        //    get
        //    {
        //        return Hits;
        //    }
        //}

        //public bool IsHitted
        //{
        //    get
        //    {
        //        return Hits >= Size;
        //    }
        //} 
        //public bool IsSanked
        //{
        //    get
        //    {
        //        return Hits == Size ;
        //    }
        //}

        public List<Coordinates> ShipCoordinates { get; set; }
    }
}

