using PirateOutLaws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleProject
{
    public class UIManager
    {


        

        // 타이틀 씬
        public void DrawTitleScene()
        {



            for (int j = 0; j < 25; j++)
            {
                Console.SetCursorPosition(3, j);
                if (j == 0)
                {
                    Console.WriteLine("┌───────────────────────────────────────────────────┐");
                }
                else if (j == 24)
                {
                    Console.WriteLine("└───────────────────────────────────────────────────┘");
                }
                else
                {
                    Console.WriteLine("│                                                   │");
                }

                Console.SetCursorPosition(23, 10);
                Console.WriteLine("PIRATE OUTLAWS");
                Console.SetCursorPosition(23, 15);
                Console.WriteLine("Tab to Start..");


            }
            Console.SetCursorPosition(40, 15);
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Tab)
                {
                    break;
                }
            }
           

        }

        // 플레이어 능력치 창
        public void DrawStatUI(string name, int hp, int maxHp, int actionPoint)
        {
            for(int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(2, i);
                if (i == 0)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────┐");
                }
                else if (i == 1)
                {
                    Console.WriteLine("│ 직업 : {0}                                            │", name);
                }
                else if (i == 2)
                {
                    Console.WriteLine("│ 체력 : {0} / {1}                              탄약 : {2} │", hp, maxHp, actionPoint);
                }
                else if (i == 3)
                {
                    Console.WriteLine("├────────────────────────────────────────────────────────┤");

                }
            }
        }

        // 메인 씬
        public void DrawMainScene()
        {
            for (int j = 4; j < 25; j++)
            {
                Console.SetCursorPosition(2, j);
                if(j == 3)
                {
                    Console.WriteLine("├────────────────────────────────────────────────────────┤");

                }
                else if (j == 24)
                {
                    Console.SetCursorPosition(2, j);

                    Console.WriteLine("└────────────────────────────────────────────────────────┘");
                }
                else
                {
                    Console.WriteLine("│                                                        │");
                }

                
            }
        }

        public void DrawBattleScene()
        {
            Console.WriteLine("==========================================");
            for (int j = 4; j < 20; j++)
            {
                Console.SetCursorPosition(2, j);
                if (j == 3)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────┐");

                }
           
                else if (j == 19)
                {
                    Console.SetCursorPosition(2, j);

                    Console.WriteLine("└────────────────────────────────────────────────────────┘");
                }
                else
                {
                    Console.WriteLine("│                                                        │");
                }

                
            }
        }

        // 덱 UI
        public void DrawDeckUi()
        {
            for (int j = 0; j < 25; j++)
            {
                Console.SetCursorPosition(60, j);
                if (j == 0)
                {
                    Console.WriteLine("┌──────────────────┐");
                }
                else if (j == 1)
                {
                    Console.SetCursorPosition(60, j);
                    Console.WriteLine("│    카드 덱 목록  │");
                }

                else if (j == 24)
                {
                    Console.WriteLine("└──────────────────┘");
                }
                else
                {
                    Console.WriteLine($"│                  │");
                    PrintMyDeck();
                }


            }
        }

        // 퀘스트 로그 출력
        public void PrintQuestLog(QuestManager qm, int questIndex)
        {


            for (int j = 0; j < qm.questList[questIndex].dialog.Count; j++)
            {
                Console.SetCursorPosition(5, 5 + j);
                Console.WriteLine("{0}", qm.questList[questIndex].dialog[j]);

            }
        }

        // 현재 덱 목록 출력
        public void PrintMyDeck()
        {
            DeckManager myDeck = new DeckManager();
            myDeck.InitMyDeck();
            for(int i = 0; i < myDeck.MyDeck.Count;i++)
            {
                Console.SetCursorPosition(65, 3 + i);
                Console.WriteLine("{0}", myDeck.MyDeck[i].Name);

            }
        }
        

        // 손패 출력
        public void PrintMyHand(List<Card> myHand_)
        {
            for(int i = 0; i < myHand_.Count; i++)
            {
                for (int j = 16; j < 24; j++)
                {
                    Console.SetCursorPosition(4 + (10 * (i)), j );
                    if (j == 16)
                    {
                        Console.WriteLine("┌── [{0}]──┐", i + 1);
                    }
                    else if (j == 23)
                    {
                        Console.WriteLine("└────────┘");
                    }
                    else if( j == 17)
                    {
                        Console.SetCursorPosition(4 + (10 * (i)), j);
                        Console.WriteLine("│ {0}[{1}]│", myHand_[i].Name, myHand_[i].ActionCost);
                    }
                    else if(j == 20)
                    {
                        Console.SetCursorPosition(4 + (10 * (i)), j);
                        Console.WriteLine("│    {0}   │", myHand_[i].Value);
                    }
                    else
                    {
                        Console.WriteLine("│        │");
                                               
                    }
                }
            }         
        }

        //입력 창 출력
        public void DrawInputLog()
        {
            for (int i = 25; i < 29; i++)
            {
                Console.SetCursorPosition(2, i);
                if (i == 25)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────┐");
                }
                else if (i == 28)
                {
                    Console.WriteLine("└────────────────────────────────────────────────────────┘");
                }
                else
                {
                    Console.WriteLine("│                                                        │");
                }
            }
        }
    }
}
