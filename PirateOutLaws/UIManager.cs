using PirateOutLaws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
                    Console.WriteLine($"│ 체력 : {hp,-5} / {maxHp}                             탄약 :{actionPoint,2}│");
                }
                else if (i == 3)
                {
                    Console.WriteLine("└────────────────────────────────────────────────────────┘");

                }
            }
        }

        // 메인 씬
        public void DrawMainScene()
        {
            for (int j = 4; j < 25; j++)
            {
                Console.SetCursorPosition(2, j);
                if(j == 4)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────┐");

                }
                else if (j == 24)
                {
                    //Console.SetCursorPosition(2, j);

                    Console.WriteLine("└────────────────────────────────────────────────────────┘");
                }
                else
                {
                    Console.WriteLine("│                                                        │");
                }

                
            }
        }


        // 배틀씬 
        public void DrawBattleScene()
        {
            Console.Clear();
            for (int j = 4; j < 25; j++)
            {
                Console.SetCursorPosition(2, j);
                if (j == 4)
                {
                    Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

                }
                else if(j == 5)
                {
                    Console.Write("┃                                                        ┃");
                }
                else if(j == 15)
                {
                    Console.Write("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");

                }
                else if (j == 24)
                {

                    Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                }
                else
                {
                    Console.Write("┃                                                        ┃");
                }

                
            }
        }
        // 공격시 화살표로 공격 여부 보여주기
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrowStart">내 캐릭터 앞 혹은 적 캐릭터 앞 화살표 시작지점</param>
        /// <param name="arrowEnd">화살표 도착 지점</param>
        public void DrawAttackArrow(int arrowStart,int arrowEnd, string Type)
        {
            if(Type == "플레이어")
            {
                for (int i = arrowStart; i < arrowEnd; i++)
                {
                    Console.SetCursorPosition(i, 10);
                    Console.Write("=");
                    Thread.Sleep(30);
                }
                Console.SetCursorPosition(arrowEnd, 10);
                Console.Write(">");

            }
            else if(Type == "적")
            {
                for (int i = arrowEnd - 1; i >= arrowStart; i--)
                {
                    Console.SetCursorPosition(i, 10);
                    Console.Write("=");
                    Thread.Sleep(30);
                }
                Console.SetCursorPosition(arrowStart - 1, 10);

                Console.Write("<");
            }



        }


        // 패배 씬
        public void DrawLoseGame()
        {
            for (int j = 4; j < 25; j++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(2, j);
                if (j == 4)
                {
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

                }
                else if( j == 20)
                {
                    Console.WriteLine("┃                    당신은 죽었습니다.                  ┃".PadRight(10));
                }
                else if (j == 24)
                {

                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                }
                else
                {
                    Console.WriteLine("┃                                                        ┃");
                }

            }
        }
        public void DrawWinBattleScene()
        {
            for (int j = 4; j < 25; j++)
            {
                Console.SetCursorPosition(2, j);
                if (j == 4)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────┐");

                }
                else if(j == 10)
                {
                    Console.WriteLine($"│                {"전투에서 승리하였습니다.".PadRight(5)}                │");

                }
                else if(j == 11)
                {
                    Console.WriteLine($"│                {"덱에 넣을 카드를 고르세요.".PadRight(5)}              │");

                }
                else if (j == 24)
                {

                    Console.WriteLine("└────────────────────────────────────────────────────────┘");
                }
                else
                {
                    Console.WriteLine("│                                                        │");
                }


            }
        }


        public void DrawEpilog()
        {
            for (int j = 4; j < 25; j++)
            {
                Console.SetCursorPosition(2, j);
                if (j == 4)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────┐");

                }
                else if (j == 10)
                {
                    Console.WriteLine("│                 당신은 여정의 끝에서 보물을 얻어냈습니다.    │");

                }
                else if (j == 11)
                {
                    Console.WriteLine("│                 당신이 얻은 결과가 우연일수도 실력일 수도 있지만     │");

                }
                else if( j == 12)
                {
                    Console.WriteLine("│                 보물을 얻을 자격은 충분해 보입니다.       │");
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
        public void DrawGameEnding()
        {
            for (int j = 4; j < 25; j++)
            {
                Console.SetCursorPosition(2, j);
                if (j == 4)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────┐");

                }
                else if (j == 10)
                {
                    Console.WriteLine("│                The End.                 │");

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
        // 덱 UI
        public void DrawDeckUi(List<Card> myDeck_)
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
                    PrintMyDeck(myDeck_);
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
                else if (i == 26)
                {
                    Console.WriteLine($"│  {"스페이스바를 눌러 진행하세요".PadRight(10)}                          │");
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


        // 현재 덱 목록 출력
        public void PrintMyDeck(List<Card> myDeck_)
        {
          ;
            for(int i = 0; i < myDeck_.Count;i++)
            {
                
                Console.SetCursorPosition(64, 3);
                Console.Write(" 이름  코스트");
                Console.SetCursorPosition(64, 5 + i);
                Console.Write($"{myDeck_[i].Name,-5} [{myDeck_[i].ActionCost}]");

            }
        }
        

        // 손패 출력
        public void PrintMyHand(List<Card> myHand_)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for(int i = 0; i < myHand_.Count; i++)
            {
                for (int j = 16; j < 24; j++)
                {
                    Console.SetCursorPosition(4 + (11 * (i)), j );
                    if (j == 16)
                    {
                        Console.WriteLine("┏━━━ [{0}]━━┓", i + 1);
                    }            
                    else if( j == 17)
                    {
                        Console.WriteLine("┃{0,2}[{1,1}]┃", myHand_[i].Name, myHand_[i].ActionCost);
                    }
                    else if (j == 18)
                    {
                        Console.WriteLine($"┃   {myHand_[i].TypeName,-3}┃");

                    }
                    else if(j == 20)
                    {
                        Console.WriteLine("┃   {0,3}   ┃", myHand_[i].Value);
                    }
                    else if (j == 23)
                    {
                        Console.WriteLine("┗━━━━━━━━━┛");
                    }
                    else
                    {
                        Console.WriteLine("┃         ┃");
                                               
                    }
                }
            }
            Console.ResetColor();
        }       // printMyHand()

        // 승리 카드 3개
        public void PrintWinCard(List<Card> WinSelectCard)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 15; j < 24; j++)
                {
                    Console.SetCursorPosition(12 + (13 * i) , j);
                    if (j == 15)
                    {
                        Console.Write("┏━━━━ [{0}]━━━┓".PadRight(10), i + 1);
                    }
                    else if (j == 16)
                    {
                        Console.Write($"┃{WinSelectCard[i].Name,4}[{WinSelectCard[i].ActionCost,-1}] ┃".PadRight(10));
                    }
                    else if (j == 19)
                    {
                        Console.Write($"┃ {WinSelectCard[i].Value,6}    ┃".PadRight(10));
                    }
                    else if (j == 23)
                    {
                        Console.Write("┗━━━━━━━━━━━┛".PadRight(10));
                    }                
                    
                    else
                    {

                        Console.Write("┃           ┃".PadRight(10));

                    }
                    //Console.SetCursorPosition(50, j );
                    //Console.WriteLine("a");

                }
            }
            Console.ResetColor();
        }       // PrintWinCard()

        // 퀘스트 로그 출력
        public void PrintQuestLog(EventList qm, int questIndex)
        {


            for (int j = 0; j < qm.eventList[questIndex].dialog.Count; j++)
            {
                Console.SetCursorPosition(5, 5 + j);
                Console.WriteLine("{0}", qm.eventList[questIndex].dialog[j]);

            }
        }
       
        public void PrintBattleIcon(List<Enemy> enemyList_)
        {
            //플레이어 아이콘
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("ⓟ");
            Console.ResetColor();



            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < enemyList_.Count; i++)
            {
                Console.SetCursorPosition(35 + (i * 13), 10);
                Console.Write("ⓔ");

            }
            Console.ResetColor();

            Console.SetCursorPosition(20, 6);
            for (int i = 0; i < enemyList_.Count; i++)
            {
                Console.SetCursorPosition(35 + (i * 13), 6);
                Console.Write($"{enemyList_[i].Name}");
            }


            Console.SetCursorPosition(20, 7);
            for (int i = 0; i < enemyList_.Count; i++)
            {
                Console.SetCursorPosition(35 + (i * 13), 7);

                Console.Write($"{enemyList_[i].CurHp} /{enemyList_[i].MaxHp}");
            }


           
        }

      
    }
}
