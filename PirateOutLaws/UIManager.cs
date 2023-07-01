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

            Console.OutputEncoding = Encoding.UTF8;
            for (int j = 0; j < 25; j++)
            {
                Console.SetCursorPosition(3, j);
                if (j == 0)
                {
                    Console.Write("┌───────────────────────────────────────────────────┐");
                }
               

                else if (j == 24)
                {
                    Console.Write("└───────────────────────────────────────────────────┘");
                }
                else
                {
                    Console.Write("│                                                   │");
                }
                Console.CursorVisible = false;

                PrintIntroAscii();
               
                Console.SetCursorPosition(23, 18);
                Console.Write("PIRATE OUTLAWS");
                Console.SetCursorPosition(23, 20);
                Console.Write("Tab to Start..");
                Console.ResetColor();


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

        public void PrintIntroAscii()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for(int j = 0; j < 15; j++)
            {
                Console.SetCursorPosition(14, j);
                if (j == 2)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠤⠴⠶⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ");
                }
                else if (j == 3)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣶⣾⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                }
                else if (j == 4)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠀⠂⠉⡇⠀⠀⠀⢰⣿⣿⣿⣿⣧⠀⠀⢀⣄⣀⠀⠀⠀⠀⠀⠀");

                }
                else if (j == 5)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⢠⣶⣶⣷⠀⠀⠀⠸⠟⠁⠀⡇⠀⠀⠀⠀⠀⢹⠀⠀⠀⠀⠀⠀");
                }
                else if (j == 6)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠘⠟⢹⣋⣀⡀⢀⣤⣶⣿⣿⣿⣿⣿⡿⠛⣠⣼⣿⡟⠀⠀⠀⠀");
                }
                else if (j == 7)
                {
                    Console.Write("⠀⠀⠀⠀⠀⣴⣾⣿⣿⣿⣿⢁⣾⣿⣿⣿⣿⣿⣿⡿⢁⣾⣿⣿⣿⠁⠀⠀⠀⠀");
                }
                else if (j == 8)
                {
                    Console.Write("⠀⠀⠀⠀⠸⣿⣿⣿⣿⣿⣿⢸⣿⣿⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⠿⠇⠀⠀⠀⠀");
                }
                else if (j == 9)
                {
                    Console.Write("⠀⠀⠀⠳⣤⣙⠟⠛⢻⠿⣿⠸⣿⣿⣿⣿⣿⣿⣿⣇⠘⠉⠀⢸⠀⢀⣠⠀⠀⠀");
                }
                else if (j == 10)
                {
                    Console.Write("⠀⠀⠀⠀⠈⠻⣷⣦⣼⠀⠀⠀⢻⣿⣿⠿⢿⡿⠿⣿⡄⠀⠀⣼⣷⣿⣿⠀⠀⠀");
                }
                else if (j == 11)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣶⣄⡈⠉⠀⠀⢸⡇⠀⠀⠉⠂⠀⣿⣿⣿⣧⠀⠀⠀");
                }
                else if (j == 12)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣷⣤⣀⣸⣧⣠⣤⣴⣶⣾⣿⣿⣿⡿⠀⠀⠀");
                }
                else if (j == 13)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀");
                }
                else if (j == 14)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠟⠛⠉⠀⠀⠀⠀");
                }
                else if (j == 15)
                {
                    Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                }
            }
            
        }

        // 플레이어 능력치 창
        public void DrawStatUI(Player player)
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
                    Console.WriteLine("│ 직업 : {0}                                            │", player.Name);
                }
                else if (i == 2)
                {
                    Console.WriteLine($"│ 체력 : {player.CurHp,-5} / {player.MaxHp}                      행동력 : {player.ActionPoint} / {player.MaxActionPoint} │");
                }
                else if (i == 3)
                {
                    Console.WriteLine("└────────────────────────────────────────────────────────┘");

                }
            }
        }

        // 메인 씬
        public void DrawMainScene(int eventCount_, int bossEventCount)
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

                    Console.WriteLine("└────────────────────────────────────────────────────────┘");
                }
                else
                {
                    Console.WriteLine("│                                                        │");
                }

                DrawInfo();
                DrawMapUi(eventCount_,bossEventCount);

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
                DrawInfo();

            }
        }



        #region Battle Effect
        // 원거리 근거리 공격시 화살표로 공격 여부 보여주기
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrowStart">내 캐릭터 앞 혹은 적 캐릭터 앞 화살표 시작지점</param>
        /// <param name="arrowEnd">화살표 도착 지점</param>
        public void Print_AttackArrow(int arrowStart,int arrowEnd, string Type)
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
                Console.Write("▷");
                
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

                Console.Write("◁");
            }
        }

  
        public void Print_RangeEffect(int enemyPos)
        {
            for(int i = 5; i < 9; i ++)
            {
                Console.SetCursorPosition(enemyPos, i);
                Console.Write("＊");
                Thread.Sleep(30);
            }
            Console.SetCursorPosition(enemyPos, 10);
            Console.Write("※");

        }

        public void Print_HealEffect()
        {
            for(int i = 8; i > 6; i--)
            {
                Console.SetCursorPosition(15, i);
                Console.WriteLine("+");
                Thread.Sleep(60);
            }
        }

        public void Print_GetActionPoint()
        {
            for(int i = 8; i > 6; i--)
            {
                Console.SetCursorPosition(15, i);
                Console.WriteLine("º");
                Thread.Sleep(60);
            }
        }


        // 데미지 혹은 회복 등 수치 출력
        public void PrintValue(int damage, int pos)
        {
            Console.SetCursorPosition(pos, 13);
            Console.Write($"{damage}");

        }

        #endregion


        #region Lose Scene
        // 패배 씬
        public void DrawLoseGame()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(2, 17);


            Console.WriteLine("                          당신은 죽었습니다.                  ".PadRight(10));


            PrintLostAscii();

        }


        public void PrintLostAscii()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int j = 0; j < 15; j++)
            {
                Console.SetCursorPosition(2, j);
                if (j == 2)
                {
                    Console.Write("    .o oOOOOOOOo                                            OOOo");
                }
                else if (j == 3)
                {
                    Console.Write("    Ob.OOOOOOOo  OOOo.      oOOo.                      .adOOOOOOO");
                }
                else if (j == 4)
                {
                    Console.Write("    OboO\"\"\"\"\"\"\"\"\"\"\"\".OOo. .oOOOOOo.    OOOo.oOOOOOo..\"\"\"\"\"\"\"\"\"'OO");

                }
                else if (j == 5)
                {
                    Console.Write("    OOP.oOOOOOOOOOOO \"POOOOOOOOOOOo.   `\"OOOOOOOOOP,OOOOOOOOOOOB'");
                }
                else if (j == 6)
                {
                    Console.Write("    `O'OOOO'     `OOOOo\"OOOOOOOOOOO` .adOOOOOOOOO\"oOOO'    `OOOOo");
                }
                else if (j == 7)
                {
                    Console.Write("    .OOOO'            `OOOOOOOOOOOOOOOOOOOOOOOOOO'            `OO");
                }
                else if (j == 8)
                {
                    Console.Write("    OOOOO                 '\"OOOOOOOOOOOOOOOO\"`                oOO");
                }
                else if (j == 9)
                {
                    Console.Write("   oOOOOOba.                .adOOOOOOOOOOba               .adOOOOo.");
                }
                else if (j == 10)
                {
                    Console.Write("  oOOOOOOOOOOOOOba.    .adOOOOOOOOOO@^OOOOOOOba.     .adOOOOOOOOOOOO");
                }
                else if (j == 11)
                {
                    Console.Write(" OOOOOOOOOOOOOOOOO.OOOOOOOOOOOOOO\"`  '\"OOOOOOOOOOOOO.OOOOOOOOOOOOOO");
                }
                else if (j == 12)
                {
                    Console.Write(" \"OOOO\"       \"YOoOOOOMOIONODOO\"`  .   '\"OOROAOPOEOOOoOY\"     \"OOO\"");
                }
                else if (j == 13)
                {
                    Console.Write("    Y           'OOOOOOOOOOOOOO: .oOOo. :OOOOOOOOOOO?'         :`");
                }
                else if (j == 14)
                {
                    Console.Write("    :            .oO%OOOOOOOOOOo.OOOOOO.oOOOOOOOOOOOO?         .");
                }
                else if (j == 15)
                {
                    Console.Write("    .            oOOP\"%OOOOOOOOoOOOOOOO?oOOOOO?OOOO\"OOo");
                }
                else if (j == 16)
                {
                    Console.Write("                 '%o  OOOO\"%OOOO%\"%OOOOO\"OOOOOO\"OOO':");
                }
                else if (j == 17)
                {
                    Console.Write("                      `$\"  `OOOO' `O\"Y ' `OOOO'  o             .");
                }

            }

        }
        #endregion

        public void DrawEpilog()
        {
            Console.CursorVisible = false;
            for (int i = 20; i < 23; i++)
            {
                Console.SetCursorPosition(2, i);
                if (i == 20)
                {
                    Console.WriteLine("    당신은 여정의 끝에서 보물을 얻어냈습니다.           ");
                }
                else if (i == 21)
                {
                    Console.WriteLine("    당신이 얻은 결과가 우연일수도 실력일 수도 있지만    ");
                }
                else if (i == 22)
                {
                    Console.WriteLine("    보물을 얻을 자격은 충분해 보입니다.                 ");
                }

                PrintEpilogAscii();

            }
        }

        public void PrintEpilogAscii()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 21; i++)
            {
                Console.SetCursorPosition(0, i);
                if (i == 0)
                {
                    Console.WriteLine("                            _.--.");

                }
                else if (i == 1)
                {
                    Console.WriteLine("                        _.-'_:-'||");

                }
                else if (i == 2)
                {
                    Console.WriteLine("                    _.-'_.-::::'||");
                }
                else if (i == 3)
                {
                    Console.WriteLine("               _.-:'_.-::::::'  ||");
                }
                else if (i == 4)
                {

                    Console.WriteLine("             .'`-.-:::::::'     ||");
                }
                else if (i == 5)
                {

                    Console.WriteLine("            /.'`;|:::::::'      ||_");
                }
                else if (i == 6)
                {

                    Console.WriteLine("           ||   ||::::::'     _.;._'-._");
                }
                else if (i == 7)
                {

                    Console.WriteLine("           ||   ||:::::'  _.-!oo @.!-._'-.");
                }
                else if (i == 8)
                {

                    Console.WriteLine("           \'.  ||:::::.-!()oo @!()@.-'_.|");
                }
                else if (i == 9)
                {

                    Console.WriteLine("            '.'-;|:.-'.&$@.& ()$%-'o.'\\U||");
                }
                else if (i == 10)
                {

                    Console.WriteLine("              `>'-.!@%()@'@_%-'_.-o _.|'||");
                }
                else if (i == 11)
                {

                    Console.WriteLine("               ||-._'-.@.-'_.-' _.-o  |'||");
                }
                else if (i == 12)
                {

                    Console.WriteLine("               ||=[ '-._.-\\U/.-'    o |'||");
                }
                else if (i == 13)
                {

                    Console.WriteLine("               || '-.]=|| |'|      o  |'||");
                }
                else if (i == 14)
                {

                    Console.WriteLine("               ||      || |'|        _| ';");
                }
                else if (i == 15)
                {

                    Console.WriteLine("               ||      || |'|    _.-'_.-'");
                }
                else if (i == 16)
                {

                    Console.WriteLine("               |'-._   || |'|_.-'_.-'");
                }
                else if (i == 17)
                {

                    Console.WriteLine("                '-._'-.|| |' `_.-'");
                }
                else if (i == 18)
                {

                    Console.WriteLine("                    '-.||_/.-'");
                }


            }
            Console.ResetColor();
        }

        public void PrintGameEndingAscii()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 6; i < 15; i++)
            {
                Console.SetCursorPosition(5, i);
                if (i == 6)
                {
                    Console.Write("  ████████████████████████████████████████████████████████████  ");
                }
                else if (i == 7)
                {
                    Console.Write("██                                                            ██");

                }
                else if (i == 8)
                {
                    Console.Write("██              ██████    ██      ██    ██████                ██");
                }
                else if (i == 9)
                {
                    Console.Write("██              ██        ████    ██    ██    ██              ██");
                }
                else if (i == 10)
                {

                    Console.Write("██              ██████    ██  ██  ██    ██    ██              ██");
                }
                else if (i == 11)
                {

                    Console.Write("██              ██        ██    ████    ██    ██              ██");
                }
                else if (i == 12)
                {

                    Console.Write("██              ██████    ██      ██    ██████                ██");
                }
                else if (i == 13)
                {

                    Console.Write("██                                                            ██");
                }
                else if (i == 14)
                {

                    Console.Write("  ████████████████████████████████████████████████████████████  ");
                }


            }
            Console.ResetColor();


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

        #region DrawInfo and InfoText
        public void DrawInfo()
        {
            for (int j = 0; j < 25; j++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(81, j);
                if (j == 0)
                {
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                }         
                else if (j == 24)
                {
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                }
                else
                {
                    Console.WriteLine("┃                                   ┃");
                }
                Console.ResetColor();

            }
            PrintInofText();
        }

        public void PrintInofText()
        {
            Console.SetCursorPosition(83, 1);
            Console.Write(" 도움말 ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(83, 2);
            Console.Write(" 스탯 창 설명");
            Console.ResetColor();
            Console.SetCursorPosition(83, 3);
            Console.Write(" 행동력:카드를 사용할 때마다 소모.");
            Console.SetCursorPosition(83, 4);
            Console.Write(" 체력:현재 체력과 최대 체력.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(83, 6);
            Console.Write(" 전투 창 설명");
            Console.ResetColor();
            Console.SetCursorPosition(83, 7);
            Console.Write(" 전투는 턴제로 진행됩니다.");
            Console.SetCursorPosition(83, 8);
            Console.Write(" 플레이어는 행동력을 소모하여");
            Console.SetCursorPosition(83, 9);
            Console.Write(" 카드를 사용할 수 있습니다.");
            Console.SetCursorPosition(83, 10);
            Console.Write(" 턴을 넘기면 적은 ");
            Console.SetCursorPosition(83, 11);
            Console.Write(" 플레이어를 공격합니다.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(83, 13);
            Console.Write(" 카드 타입 설명");
            Console.ResetColor();
            Console.SetCursorPosition(83, 14);
            Console.Write(" 근접 - 가장 앞의 적을 공격.");
            Console.SetCursorPosition(83, 15);
            Console.Write(" 원거리 - 가장 뒤의 적을 공격.");
            Console.SetCursorPosition(83, 16);
            Console.Write(" 뒤의 적이없다면 앞의 적을 공격.");
            Console.SetCursorPosition(83, 17);
            Console.Write(" 범위 - 모든 적을 공격.");
            Console.SetCursorPosition(83, 18);
            Console.Write(" 회복 - 체력 회복.");
            Console.SetCursorPosition(83, 19);
            Console.Write(" 보급 - 행동력 추가.");
            Console.SetCursorPosition(83, 20);
            Console.Write(" 드로우 - 카드를 뽑음.");

        }
        #endregion


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
            Console.SetCursorPosition(64, 3);
            Console.Write(" 이름   행동력");
            for (int i = 0; i < myDeck_.Count;i++)
            {
                
                
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
                        Console.WriteLine("┃{0,3}[{1,1}]┃", myHand_[i].Name, myHand_[i].ActionCost);
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
                    else if (j == 18)
                    {
                        Console.WriteLine("┃    {0,3} ┃", WinSelectCard[i].TypeName);

                    }
                    else if (j == 20)
                    {
                        Console.Write("┃    {0,3}    ┃", WinSelectCard[i].Value);
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

        public void DrawMapUi(int eventCount_,int bossEventCount)
        {
            for(int i = 25; i < 29; i++)
            {
                Console.SetCursorPosition(60, i);
                if (i == 25)
                {
                    Console.Write("┌──────────────────┐");
                }
                else if (i == 26)
                {
                    Console.Write("│     현재 여정    │");
                }
                else if (i == 27)
                {
                    Console.Write($"│      {eventCount_,-2} / {bossEventCount}     │");
                }
                else if (i == 28)
                {
                    Console.Write("└──────────────────┘");
                }
                else
                {
                    Console.WriteLine($"│                  │");
                }
            }
        }
      
    }
}
