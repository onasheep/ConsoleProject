using PirateOutLaws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class Player
    {

        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int CurHp { get; set; }
        public int ActionPoint { get; set; }

        public int MaxActionPoint { get; set; }
        public Player()
        {
            Name = "포수";
            MaxHp = 250;
            CurHp = MaxHp;
            MaxActionPoint = 3;
            ActionPoint = MaxActionPoint;
        }

 

    }
}
