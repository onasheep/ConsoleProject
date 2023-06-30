using PirateOutLaws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleProject
{
    public class GamePlay
    {

        DeckManager deckManager;

        UIManager uiManager;

        Player player;

        BattleSystem bS;

        List<Enemy> enemyList;

        EventList eL;

        EventManager eM;

        Relic relic;

        // 전투 패배 체크
        bool isLose = false;
        // 전투 승리 체크
        bool isEnd = false;
        // 인트로 이벤트 체크
        bool isFirstEvent = true;
        // 보스전 까지 체크
        int eventCount = 0;
        int bossEventCount = 9;


        Random rand;

        public void Init()
        {
            // 덱 초기화
            deckManager = new DeckManager();
            deckManager.InitCardDeck();
            deckManager.InitMyDeck();

            deckManager.InitDiscardDeck();

            // ui 초기화
            uiManager = new UIManager();

            // 플레이어 초기화
            player = new Player();


            //퀘스트 매니저 초기화
            eM = new EventManager();
            eM.Init();
            // 퀘스트 리스트 초기화
            eL = new EventList();
            eL.Init();

            // 배틀 시스템 초기화
            bS = new BattleSystem();

            rand = new Random();

            // 유물 시스템 초기화
           

        }       //Init()

        public void Play()
        {
            Init();




            uiManager.DrawTitleScene();
            uiManager.DrawMainScene();

            while (true)
            {
                if(isEnd)
                {
                    break;
                }
                Console.CursorVisible = false;



                // 마지막 보스 이벤트 제외 - 1
                //int randNum = rand.Next(0, eL.eventList.Count - 1);

                // Test 
                int randNum = 8;


                // 이벤트 출력시 +1
                eventCount += 1;
                // 첫 이벤트만 강제 출력
                
                if (isFirstEvent)
                {
                    eM.IntroQuest();
                    isFirstEvent = false;
                }
                                                
                uiManager.DrawStatUI(player.Name, player.CurHp, player.MaxHp, player.ActionPoint);
                uiManager.DrawDeckUi(deckManager.MyDeck);
                uiManager.DrawInputLog();


                // 메인 씬 입력 부분
                Console.SetCursorPosition(5, 27);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {

                    case ConsoleKey.Spacebar:
                        uiManager.DrawMainScene();
                        QuestCheck(eL.eventList[randNum].key);
                        eL.eventList.RemoveAt(randNum);


                        break;
                    default:
                        break;
                }

                //uiManager.DrawInputLog();


                // 패배시 게임 끝
                if (isLose)
                {
                    break;
                }
                Console.CursorVisible = false;

                
            }

        }       //Play()
      

        

        public void QuestCheck(int eventKey)
        {
            if(eventCount >= bossEventCount)
            {
                // 강제로 10번 으로
                eventKey = 20;
            }
            switch (eventKey)
            {
                case 1:
                    eM.MokeyQuest(player);
                    break;
                case 2:
                    eM.HodeQeust();
                    Thread.Sleep(1500);

                    // 출력부 컨트롤
                    // 적 초기화
                    Enemy thief = new Enemy();
                    Enemy samllThied = new Enemy();
                    enemyList = new List<Enemy>();
                    thief.Init("도적", 10, 50, 50); // 5 - >임시 조정 대미지 1000
                    samllThied.Init("민첩한 도적", 14, 30, 30);
                    enemyList.Add(thief);
                    enemyList.Add(samllThied);
                    
                    OnBattle(enemyList);
                    break;
                case 3:
                    eM.InnQuest(player);
                    break;
                case 4:
                    eM.TreasureQuest(deckManager.CardDeck, deckManager.MyDeck);
                    int randNum = rand.Next(0, deckManager.CardDeck.Count);
                    deckManager.MyDeck.Add(deckManager.CardDeck[randNum]);
                    break;
                case 5:
                    eM.BeastQuest();
                    // 적 초기화
                    Thread.Sleep(1500);

                    Enemy wolf = new Enemy();
                    Enemy wolf1 = new Enemy();
                    enemyList = new List<Enemy>();
                    wolf.Init("늑대", 15, 30, 30); // 8 - > 임시 조정 대미지 1000
                    wolf1.Init("늑대", 12, 30, 30);
                    enemyList.Add(wolf);
                    enemyList.Add(wolf1);
                    OnBattle(enemyList);

                    break;
                case 6:
                    eM.PoinsonQeust(player);
                    break;
                case 7:
                    eM.RuinQuest();
                    // 적 초기화
                    Thread.Sleep(1500);

                    Enemy zombie = new Enemy();
                    Enemy ghost1 = new Enemy();
                    enemyList = new List<Enemy>();
                    zombie.Init("좀비", 20, 60, 60); // 10 - >임시 조정 대미지 1000
                    ghost1.Init("원혼", 25, 20, 50);
                    enemyList.Add(zombie);
                    enemyList.Add(ghost1);

                    OnBattle(enemyList);

                    break;
                case 8:
                    eM.HuntQuest(player);
                    break;
                case 9:
                    eM.CurseQuest(deckManager.MyDeck);
                    break;
                case 10:
                    eM.CursedGunQuest(player);
                    uiManager.DrawStatUI(player.Name, player.CurHp, player.MaxHp, player.ActionPoint);
                    break;
                case 20:
                    eM.BossQuest();

                    Thread.Sleep(1500);

                    Enemy boss = new Enemy();
                    enemyList = new List<Enemy>();
                    boss.Init("검은수염", 50, 100, 100);
                    enemyList.Add(boss);

                    OnBattle(enemyList);
                    break;
            }
        }       // QeustCheck()


        public void OnBattle(List<Enemy> enemyList)
        {
            deckManager.InitMyHand();

            while (true)
            {

                uiManager.DrawBattleScene();
                uiManager.PrintBattleIcon(enemyList);
                uiManager.DrawStatUI(player.Name, player.CurHp, player.MaxHp, player.ActionPoint);
                uiManager.DrawInputLog();
                uiManager.DrawDeckUi(deckManager.MyDeck);
                uiManager.PrintMyHand(deckManager.MyHand);


                bS.Battle(deckManager.MyHand, deckManager.DiscardDeck,deckManager.MyDeck, player, enemyList);

                if(player.CurHp == 0)
                {
                    player.CurHp = 0;
                    Console.Clear();
                    uiManager.DrawLoseGame();
                    isLose = true;
                    return;
                }
                else if (!enemyList.Any() )
                {
                    Console.Clear();
                    //uiManager.DrawInputLog();

                    // 보스 전 종료 후 카드 선택 스킵 코드
                    if (eventCount >= bossEventCount)
                    {
                        isEnd = true;
                        break;
                    }


                    // 카드 덱에서 승리 카드 리스트로 3개 넣기
                    deckManager.InitWinSelectCard(deckManager.CardDeck);

                    uiManager.DrawWinBattleScene();
                    // 승리 카드 3개 출력
                    uiManager.PrintWinCard(deckManager.WinSelectCard);
                    // 승리 카드 한장 획득
                    deckManager.ChooseWinCard(deckManager.WinSelectCard, deckManager.MyDeck);

                    // 내 손패를 내 덱으로 보냄
                    foreach (Card card in deckManager.MyHand)
                    {
                        deckManager.MyDeck.Add(card);

                    }
                    // 내 버림패를 내 덱으로 보냄
                    foreach (Card card in deckManager.DiscardDeck)
                    {
                        deckManager.MyDeck.Add(card);
                    }
                    // 버림패 손패 초기화
                    deckManager.DiscardDeck.Clear();
                    deckManager.MyHand.Clear();
                    uiManager.DrawMainScene();

                    // 탄약 풀 충전
                    player.ActionPoint = player.MaxActionPoint; 
                    break;
                }

            
                
            }

            if (isEnd) 
            {
                Console.Clear();
                uiManager.DrawEpilog();
                Thread.Sleep(3000);
                Console.Clear();
                uiManager.DrawGameEnding();
                Thread.Sleep(3000);
            }
        }

    

        // 추후 추가 할 수 있는 퀘스트 선택지. ( Y / N 입력 후 선택지 )
        //case ConsoleKey.Y:
        //    Console.SetCursorPosition(5, 26);
        //    if (questManager.questList[questIndex].isBattle)
        //    {                          
        //        uiManager.PrintMyHand(deckManager.MyHand);
        //        Battle();
        //    }
        //    if(questIndex < maxQuestIndex )
        //    questIndex += 1;
        //    break;
        //case ConsoleKey.N:
        //    Console.SetCursorPosition(5, 26);
        //    uiManager.PrintInput("N");
        //    if (questIndex < maxQuestIndex)
        //        questIndex += 1;
        //    break;
    }
}
