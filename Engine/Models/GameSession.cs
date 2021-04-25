using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Models
{
    class GameSession
    {
        Character currentPlayer { get; set; }
        GameSession()
        {
            currentPlayer = new Character();
            currentPlayer.Name = "Han Solo";
            currentPlayer.CharacterClass = "Clawdithe";
            currentPlayer.HitPoints = 10;
            currentPlayer.ExperiencePoints = 0;
            currentPlayer.Gold = 10;
        }
    }
}
