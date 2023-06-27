using ConsoleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateOutLaws
{
    public class Quest
    {

        public List<string> dialog;
        public bool isBattle;

        public int Value { get; set; }
        public void Init(List<string> dialog_, bool isBattle_)
        {

            this.dialog = dialog_;
            this.isBattle = isBattle_;
        }
        public void Init(List<string> dialog_, bool isBattle_, int value)
        {

            this.dialog = dialog_;
            this.isBattle = isBattle_;
            this.Value = value;
        }
     

    }
}
