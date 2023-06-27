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

        public Player()
        {
            Name = "포수";
            MaxHp = 200;
            CurHp = MaxHp;
            ActionPoint = 3;
        }

        public void ChooseCard(List<Card> myHand, List<Card> discardDeck, Enemy enemy)
        {
            Console.SetCursorPosition(5, 26);
            Console.WriteLine("사용할 카드를 선택하세요.");
            Console.SetCursorPosition(5, 27);
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                discardDeck.Add(myHand[num - 1]);
                enemy.CurHp -= myHand[num - 1].Value;
                myHand.RemoveAt(num - 1);
            }
        }


    }
}
