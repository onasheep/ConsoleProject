using ConsoleProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            int thread = 100;
            for (int i = 0; i < qL.eventDic[0].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);
                for (int j = 0; j < qL.eventDic[0].dialog[i].Length;j++)
                {
                    Console.Write(qL.eventDic[0].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if(Console.KeyAvailable)
                    {
                        thread = 0;
                        
                    }
                   
                }
              
            }
            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }
        // 원숭이 퀘스트
        public void MokeyQuest(Player player_)
        {
            int thread = 100;

            for (int i = 0; i < qL.eventDic[1].dialog.Count; i++)
            {
                if(i == qL.eventList[1].dialog.Count - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.SetCursorPosition(4, 5 + i * 2);
                for (int j = 0; j < qL.eventDic[1].dialog[i].Length;j++)
                {
                    
                    Console.Write(qL.eventDic[1].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }

                }
                Console.ResetColor();

            }
            player_.CurHp -= 10;

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }
        // 무리 배틀 퀘스트
        public void HodeQeust()
        {
            int thread = 100;
            for (int i = 0; i < qL.eventDic[2].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);
                for (int j = 0; j < qL.eventDic[2].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[2].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }

                }

            }

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }

        // 여관 퀘스트
        public void InnQuest(Player player_)
        {
            int thread = 100;

            for (int i = 0; i < qL.eventDic[3].dialog.Count; i++)
            {
                if (i == qL.eventList[3].dialog.Count - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.SetCursorPosition(4, 5 + i * 2);
                for (int j = 0; j < qL.eventDic[3].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[3].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }
                }
                Console.ResetColor();
            }
            player_.CurHp += 40;
            if (player_.CurHp > player_.MaxHp)
            {
                player_.CurHp = player_.MaxHp;
            }

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }
        // 보물 퀘스트 (카드 한장 획득) 
        public void TreasureQuest(List<Card> cardDeck_,List<Card> myDeck_)
        {
            int thread = 100;

            Random rand = new Random();
            int randNum = rand.Next(1, cardDeck_.Count);
            for (int i = 0; i < qL.eventDic[4].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);

                for (int j = 0; j < qL.eventDic[4].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[4].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }
                }

            }
            Console.SetCursorPosition(5, 5 + (qL.eventDic[4].dialog.Count) * 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[{0,5}   ]", cardDeck_[randNum - 1].Name);
            Console.Write("카드를 얻었습니다.");
            Console.ResetColor();

            myDeck_.Add(cardDeck_[randNum - 1]);

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }

        }

        // 짐승 무리 배틀 퀘스트
        public void BeastQuest()
        {
            int thread = 100;

            for (int i = 0; i < qL.eventDic[5].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);

                for (int j = 0; j < qL.eventDic[5].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[5].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }


                }

            }

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }

        // 독 물 퀘스트
        public void PoinsonQeust(Player player_)
        {
            int thread = 100;

            for (int i = 0; i < qL.eventDic[6].dialog.Count; i++)
            {
                
                if (i == qL.eventDic[6].dialog.Count - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.SetCursorPosition(4, 5 + i * 2);
                for (int j = 0; j < qL.eventDic[6].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[6].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }

                }
                Console.ResetColor();
            }
            player_.CurHp -= 20;

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }

        // 폐허 배틀 퀘스트
        public void RuinQuest()
        {
            int thread = 100;

            for (int i = 0; i < qL.eventDic[7].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);

                for (int j = 0; j < qL.eventDic[7].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[7].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }

                }

            }

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }

        // 사냥 퀘스트
        public void HuntQuest(Player player_)
        {
            int thread = 100;

            for (int i = 0; i < qL.eventDic[8].dialog.Count; i++)
            {
                if (i == qL.eventList[8].dialog.Count - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.SetCursorPosition(4, 5 + i * 2);
                for (int j = 0; j < qL.eventDic[8].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[8].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }

                }
                Console.ResetColor();
            }
            player_.CurHp += 20;
            player_.MaxHp += 20;

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }

        // 저주 퀘스트
        public void CurseQuest(List<Card> myDeck_)
        {
            int thread = 100;

            Random rand = new Random();
            int randNum = rand.Next(1, myDeck_.Count);
            for (int i = 0; i < qL.eventDic[9].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);

                for (int j = 0; j < qL.eventDic[9].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[9].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }

                }

            }
            Console.SetCursorPosition(5, 5 + (qL.eventDic[9].dialog.Count) * 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[{0,5}   ]", myDeck_[randNum - 1].Name);
            Console.Write("카드가 제거 되었습니다.");
            Console.ResetColor();

            myDeck_.RemoveAt(randNum - 1);

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }
        // 저주 받은 총 퀘스트
        public void CursedGunQuest(Player player_)
        {
            int thread = 100;

            for (int i = 0; i < qL.eventDic[10].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);

                for (int j = 0; j < qL.eventDic[10].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[10].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }

                }

            }
            Console.SetCursorPosition(5, 5 + (qL.eventDic[10].dialog.Count * 2));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("최대 행동력이 1 증가합니다.");
            Console.ResetColor();
            Console.SetCursorPosition(5, 5 + ((qL.eventDic[10].dialog.Count + 1) * 2));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("최대 체력이 20 감소합니다.");
            Console.ResetColor();

            
            player_.MaxHp -= 20;
            if(player_.MaxHp < player_.CurHp )
            {
                player_.CurHp = player_.MaxHp;
            }
            player_.MaxActionPoint += 1;
            player_.ActionPoint += 1;

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }

        }

        public void UnkownCardQuest(List<Card> myDeck_)
        {
            int thread = 100;

            Random rand = new Random();
            for (int i = 0; i < qL.eventDic[11].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);

                for (int j = 0; j < qL.eventDic[11].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[11].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }
                }

            }
            for(int i = 0; i < 2; i++)
            {
                int randNum = rand.Next(1, myDeck_.Count);
                Console.SetCursorPosition(5, 5 + (qL.eventDic[11].dialog.Count + i) * 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[{0,5}   ]", myDeck_[randNum - 1].Name);
                Console.Write("카드가 제거 되었습니다.");
                Console.ResetColor();
                myDeck_.RemoveAt(randNum - 1);
            }


            DeckManager deckmanager = new DeckManager();

            Console.SetCursorPosition(5, 5 + (qL.eventDic[11].dialog.Count + 2) * 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[{0,5}   ]", deckmanager.UnkownCard().Name);
            Console.Write("카드를 얻었습니다.");
            Console.ResetColor();

            myDeck_.Add(deckmanager.UnkownCard());


            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }

        }

        public void GambleQuest(List<Card> myDeck_, List<Card> cardDeck_)
        {
            int thread = 100;

            Random rand = new Random();
            for (int i = 0; i < qL.eventDic[12].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);

                for (int j = 0; j < qL.eventDic[12].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[12].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }
                }

            }
            for (int i = 0; i < 2; i++)
            {
                int randNum = rand.Next(1, myDeck_.Count);
                Console.SetCursorPosition(5, 5 + (qL.eventDic[12].dialog.Count + i) * 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[{0,5}   ]", myDeck_[randNum - 1].Name);
                Console.Write("카드가 제거 되었습니다.");
                Console.ResetColor();
                myDeck_.RemoveAt(randNum - 1);
            }

            for(int i = 0; i < 2; i++)
            {
                int randNum = rand.Next(1, myDeck_.Count);
                Console.SetCursorPosition(5, 5 + (qL.eventDic[12].dialog.Count + i + 2) * 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[{0,5}   ]", cardDeck_[randNum - 1].Name);
                Console.Write("카드를 얻었습니다.");
                Console.ResetColor();

                myDeck_.Add(cardDeck_[randNum - 1]);
            }

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }


        // 보스 퀘스트
        public void BossQuest()
        {
            int thread = 100;
            
            for (int i = 0; i < qL.eventDic[qL.eventDic.Count - 1].dialog.Count; i++)
            {
                Console.SetCursorPosition(4, 5 + i * 2);

                for (int j = 0; j < qL.eventDic[qL.eventDic.Count - 1].dialog[i].Length; j++)
                {
                    Console.Write(qL.eventDic[qL.eventDic.Count - 1].dialog[i][j]);
                    // 출력문 test
                    Thread.Sleep(thread);
                    if (Console.KeyAvailable)
                    {
                        thread = 0;

                    }

                }

            }

            ConsoleKeyInfo space = Console.ReadKey();
            while (space.Key != ConsoleKey.Spacebar)
            {

            }
        }
    }
}
