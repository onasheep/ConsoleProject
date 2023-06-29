using ConsoleProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateOutLaws
{
    public class EventManager
    {
        public EventList qL;
        public Enemy enemy;
        public void Init()
        {
            qL = new EventList();
            qL.Init();
        }

        // 인트로 퀘스트
        public void IntroQuest()
        {
            for (int i = 0; i < qL.eventDic[0].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[0].dialog[i]);
            }

        }
        // 원숭이 퀘스트
        public void MokeyQuest(Player player_)
        {
            for (int i = 0; i < qL.eventDic[1].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[1].dialog[i]);
            }

            player_.CurHp -= 10;
        }
        // 무리 배틀 퀘스트
        public void HodeQeust()
        {
            for (int i = 0; i < qL.eventDic[2].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[2].dialog[i]);

            }
        }

        // 여관 퀘스트
        public void InnQuest(Player player_)
        {
            for (int i = 0; i < qL.eventDic[3].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[3].dialog[i]);

            }
            player_.CurHp += 40;
            if (player_.CurHp > player_.MaxHp)
            {
                player_.CurHp = player_.MaxHp;
            }
        }
        // 보물 퀘스트 (카드 한장 획득) 
        public void TreasureQuest(List<Card> cardDeck_,List<Card> myDeck_)
        {
            Random rand = new Random();
            int randNum = rand.Next(1, cardDeck_.Count);
            for (int i = 0; i < qL.eventDic[4].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[4].dialog[i]);
               
            }
            Console.SetCursorPosition(5, 5 + qL.eventDic[4].dialog.Count);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{cardDeck_[randNum - 1].Name,-1}　]카드를 얻었습니다.");
            Console.ResetColor();
            myDeck_.Add(cardDeck_[randNum - 1]);
                                                                                   
            
        }

        // 짐승 무리 배틀 퀘스트
        public void BeastQuest()
        {
            for (int i = 0; i < qL.eventDic[5].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[5].dialog[i]);
            }            
        }

        // 독 물 퀘스트
        public void PoinsonQeust(Player player_)
        {
            for (int i = 0; i < qL.eventDic[6].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[6].dialog[i]);
            }
            player_.CurHp -= 20;         
        }

        // 폐허 배틀 퀘스트
        public void RuinQuest()
        {
            for (int i = 0; i < qL.eventDic[7].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[7].dialog[i]);
            }
        }

        // 사냥 퀘스트
        public void HuntQuest(Player player_)
        {
            for(int i = 0; i < qL.eventDic[8].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[8].dialog[i]);
            }
            player_.CurHp += 20;
            player_.MaxHp += 20;
        }

        // 저주 퀘스트
        public void CurseQuest(List<Card> myDeck_)
        {
            Random rand = new Random();
            int randNum = rand.Next(1, myDeck_.Count);
            for (int i = 0; i < qL.eventDic[9].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[9].dialog[i]);
       
            }
            Console.SetCursorPosition(5, 5 + qL.eventDic[9].dialog.Count);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{myDeck_[randNum - 1].Name,-2}　]카드가 제거 되었습니다.");
            Console.ResetColor();
            myDeck_.RemoveAt(randNum - 1);
        }
        // 저주 받은 총 퀘스트
        public void CursedGunQuest(Player player_)
        {
            for(int i = 0; i < qL.eventDic[10].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[10].dialog[i]);
            
            }
            Console.SetCursorPosition(5, 5 + qL.eventDic[10].dialog.Count);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("최대 탄약이 1 증가합니다.");
            Console.ResetColor();
            Console.SetCursorPosition(5, 6 + qL.eventDic[10].dialog.Count);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("최대 체력이 10 감소합니다.");
            Console.ResetColor();

            
            player_.MaxHp -= 10;
            if(player_.MaxHp < player_.CurHp )
            {
                player_.CurHp = player_.MaxHp;
            }
            player_.MaxActionPoint += 1;
            player_.ActionPoint = player_.MaxActionPoint;
        
            
            
        }



        // 보스 퀘스트
        public void BossQuest()
        {
            for (int i = 0; i < qL.eventDic[10].dialog.Count; i++)
            {
                Console.SetCursorPosition(5, 5 + i);
                Console.WriteLine("{0}", qL.eventDic[10].dialog[i]);
            }
        }
    }
}
