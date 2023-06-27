using PirateOutLaws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class GamePlay
    {

        DeckManager deckManager;

        UIManager uiManager;

        Player player;


        List<Enemy> enemyList;

        QuestManager questManager;

     
        int questIndex;
        int maxQuestIndex;
        public void Play()
        {

            Init();

            uiManager.DrawTitleScene();
                     


            while (true)
            {

                uiManager.DrawStatUI(player.Name, player.CurHp, player.MaxHp, player.ActionPoint);
                uiManager.DrawMainScene();
                uiManager.PrintQuestLog(questManager, questIndex);
                uiManager.DrawDeckUi();
                uiManager.DrawInputLog();

                // 메인 씬 입력 부분

                Console.SetCursorPosition(5, 26);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    // 추후 추가 할 수 있는 퀘스트 선택지.
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
                    case ConsoleKey.Spacebar:
                        if (questIndex < maxQuestIndex)
                        {
                            QuestCheck(questIndex);
                            questIndex += 1;
                        }                          
                        break;
                    default:
                        break;
                }


            }

        }
      

        public void Init()
        {
            // 덱 초기화
            deckManager = new DeckManager();
           
            deckManager.InitCardDeck();
            deckManager.InitMyDeck();
            deckManager.InitMyHand();
            deckManager.InitDiscardDeck();


            // ui 초기화
            uiManager = new UIManager();

            // 플레이어 초기화
            player = new Player();


            // 퀘스트 매니저 초기화
            questManager = new QuestManager();
            questManager.Init();
            questIndex = 0;
            // 퀘스트 리스트 마지막 까지만 증가할 수 있도록 추후 퀘스트 리스트 카운트로 변경
            maxQuestIndex = questManager.questList.Count - 1;

            // 적 초기화
            Enemy thief = new Enemy();
            Enemy sailor = new Enemy();

            enemyList = new List<Enemy>();
            thief.Init("도적",10, 50,50);
            sailor.Init("선원", 20, 70, 70);
            
            enemyList.Add(thief);
            enemyList.Add(sailor);


        }


        public void QuestCheck(int questIndex)
        {
            if (questManager.questList[questIndex].isBattle)
            {
                Console.SetCursorPosition(5, 26);
                ConsoleKeyInfo input = Console.ReadKey();
                if(input.Key == ConsoleKey.Spacebar)
                {
                    uiManager.DrawBattleScene();
                }
            }
            else
            {            
                player.CurHp += questManager.questList[questIndex].Value;
            }
        }
    }
}
