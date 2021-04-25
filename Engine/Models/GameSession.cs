using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Models
{
    public class GameSession
    {
        public Character currentPlayer { get; set; }
        public Location currentLocation { get; set; }

        public GameSession()
        {
            currentPlayer = new Character();
            currentPlayer.Name = "Han Swolo";
            currentPlayer.CharacterClass = "Clawdithe";
            currentPlayer.HitPoints = 10;
            currentPlayer.ExperiencePoints = 0;
            currentPlayer.Gold = 10;

            currentLocation = new Location();
            currentLocation.Name = "Hideout";
            currentLocation.XCoordinate = 0;
            currentLocation.YCoordinate = -1;
            currentLocation.Description = "At least it is not drawing attention...";
            currentLocation.ImageName = "/Engine;component/Images/Locations/hideout.jpg";
        }
    }
}
