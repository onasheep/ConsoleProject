using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class Card
    {
        
        public string Name { get; set; }
        public int ActionCost { get; set; }
        public int Value { get; set; }
        // 0 - 근접 1 - 원거리 2 - 범위 3 - 회복
        public int TargetIndex { get; set; }

        public void Init(string name, int actionCost, int value, int targetIndex)
        {
            this.Name = name;
            this.ActionCost = actionCost;
            this.Value = value;
            this.TargetIndex = targetIndex;
        }

    }
}
