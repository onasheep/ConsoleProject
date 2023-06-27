using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateOutLaws
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int MaxHp { get; set; }
        public int CurHp { get; set; }

        public void Init(string name, int damage, int maxHp, int curHp)
        {
            this.Name = name;
            this.Damage = damage;
            this.MaxHp = maxHp;
            this.CurHp = maxHp;
        }

        public void Attack()
        {
           
        }

    }
}
