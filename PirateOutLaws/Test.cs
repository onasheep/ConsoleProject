using ConsoleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PirateOutLaws
{
    public class Test
    {

        public void Test001()
        {
            UIManager ui = new UIManager();

          

            Thread.Sleep(2000);

            Console.Clear();

            ui.DrawGameEnding();
        }

    }
}
