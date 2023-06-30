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
        // 0 - 근접 1 - 원거리 2 - 범위 3 - 회복 4 - 행동력 5 - 드로우
        public int TypeIndex { get; set; }

        public string TypeName { get; set; }

        public void Init(string name, int actionCost, int value, int targetIndex,string typeName)
        {
            this.Name = name;
            this.ActionCost = actionCost;
            this.Value = value;
            this.TypeIndex = targetIndex;
            this.TypeName = typeName;
        }

    }
}
