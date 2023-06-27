using ConsoleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateOutLaws
{
    public class Event
    {

        public List<string> dialog;
        public bool isBattle;
        public int key;
        public void Init(List<string> dialog_, bool isBattle_, int key_)
        {

            this.dialog = dialog_;
            this.isBattle = isBattle_;
            this.key = key_;
        }
      
     

    }
}
