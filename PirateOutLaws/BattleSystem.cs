using ConsoleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PirateOutLaws
{
    public class BattleSystem
    {
        bool isFirstTurn = default;
        bool isMyTurn = default;
        


        UIManager uiManager;
     
        public void Init()
        {

            uiManager = new UIManager();
            isFirstTurn = true;
            isMyTurn = true;
        }

        // 행동력 추가하기( 폴리싱)
        public void Battle(List<Card> myHand, List<Card> discardDeck, List<Card> myDeck,Player player_, List<Enemy> enemyList_)
        { 
            // ui 초기화
            Init();




            while (true)
            {

                if(!enemyList_.Any())
                {
                    Console.Clear();
                    break;
                    
                }
                

                isMyTurn = true;


         
                // 첫 턴 드로우 생략
                if (!isFirstTurn)
                {
                    DrawCard(myDeck, myHand, discardDeck);
                    uiManager.PrintMyHand(myHand);


                    if (player_.ActionPoint != 3)
                    {
                        player_.ActionPoint += 1;
                    }
                    uiManager.DrawStatUI(player_.Name, player_.CurHp, player_.MaxHp, player_.ActionPoint);
                    uiManager.DrawDeckUi(myDeck);

                }



                // 내 덱이 0개가 되면 버림패를 덱으로 가져옴
                //if (!myDeck.Any())
                //{
                //    foreach (Card card in discardDeck)
                //    {
                //        myDeck.Add(card);
                //    }
                //    discardDeck.Clear();
                //    uiManager.DrawDeckUi(myDeck);

                //}
                // 플레이어 공격 
          
                while (isMyTurn)
                {


                    ChooseCard(myDeck, myHand, discardDeck, player_, enemyList_);
                    isFirstTurn = false;

                }

                // 적 공격
                for (int i = 0; i < enemyList_.Count; i++)
                {
                    
                    EnemyAttack(player_, enemyList_[i]);
                    if (i == 0)
                    {
                        Console.CursorVisible = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        uiManager.DrawAttackArrow(17, 34, "적");
                        Console.ResetColor();
                        Thread.Sleep(800);
                    }
                    else
                    {
                        Console.CursorVisible = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        uiManager.DrawAttackArrow(17, 47, "적");
                        Console.ResetColor();
                        Thread.Sleep(800);
                    }
                    Console.Clear();
                    uiManager.DrawBattleScene();
                    uiManager.PrintBattleIcon(enemyList_);
                    uiManager.DrawStatUI(player_.Name, player_.CurHp, player_.MaxHp, player_.ActionPoint);
                    uiManager.DrawInputLog();
                    uiManager.DrawDeckUi(myDeck);
                    uiManager.PrintMyHand(myHand);
                }

                if(player_.CurHp <= 0)
                {
                    player_.CurHp = 0;
                    break;
                }
            
            }

        }



        // 플레이어가 카드를 뽑아서 하는 행동들 
        public void ChooseCard(List<Card> myDeck,List<Card> myHand, List<Card> discardDeck, Player player_, List<Enemy> enemyList_)
        {
           

            while(true)
            {
                uiManager.DrawInputLog();
                Console.SetCursorPosition(5, 26);
                Console.WriteLine("사용할 카드를 선택하세요.(턴 넘기기 Enter)".PadRight(20, ' '));
                Console.CursorVisible = true;




                Console.SetCursorPosition(5, 27);
                string input = Console.ReadLine();
                int.TryParse(input, out int num);

               
                // 값을 못 넣었으니 Enter 입력 받은 경우 턴 넘기기
                if (num == 0)
                {
                    isMyTurn = false;
                    break;
                }
                // 패에 없는 카드 숫자르 선택할 때 다시 선택
                if(num > myHand.Count)
                {
                    continue;
                }

                // 탄약이 부족한 경우 경고문을 띄우고 다시 선택
                else if (myHand[num - 1].ActionCost > player_.ActionPoint)
                {
                    uiManager.DrawInputLog();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(5, 26);
                    Console.WriteLine("탄약이 부족합니다.".PadRight(20,' '));
                    Console.CursorVisible = false;
                    Console.ResetColor();
                    Thread.Sleep(800);
                    continue;
                }             
                // 카드 패를 맞게 골랐을 때 공격 로직
                else if (num <= myHand.Count && num > 0)
                {
                    discardDeck.Add(myHand[num - 1]);
                    switch (myHand[num - 1].TypeIndex)
                    {
                        // 근접 가장 앞쪽 적 공격
                        case 0:
                            enemyList_[0].CurHp -= myHand[num - 1].Value;
                            player_.ActionPoint -= myHand[num - 1].ActionCost;
                            myHand.RemoveAt(num - 1);

                            // 공격 대상에 따라 화살표 표시
                            Console.CursorVisible = false;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            uiManager.DrawAttackArrow(18,35, "플레이어");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            break;
                        // 원거리 가장 뒷쪽 적 공격, 뒤쪽 적이 죽은 경우 앞쪽 공격
                        case 1:
                            enemyList_[enemyList_.Count - 1].CurHp -= myHand[num - 1].Value;
                            player_.ActionPoint -= myHand[num - 1].ActionCost;
                            myHand.RemoveAt(num - 1);
                            // 공격 대상에 따라 화살표 표시
                            // 뒤에 적이 죽었을 떄 화살표 
                            if(enemyList_.Count == 1)
                            {
                                Console.CursorVisible = false;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                uiManager.DrawAttackArrow(18, 35, "플레이어");
                                Console.ResetColor();
                                Thread.Sleep(1000);
                            }
                            // 뒤에 적이 남아있을 떄 화살표
                            else
                            {
                                Console.CursorVisible = false;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                uiManager.DrawAttackArrow(18, 48, "플레이어");
                                Console.ResetColor();
                                Thread.Sleep(1000);
                            }                        
                            break;
                        // 범위 공격, 뒤쪽 적이 죽은 경우 앞쪽 한번 공격
                        case 2:
                            for (int i = 0; i < enemyList_.Count; i++)
                            {
                                enemyList_[i].CurHp -= myHand[num - 1].Value;
                            }
                            player_.ActionPoint -= myHand[num - 1].ActionCost;
                            myHand.RemoveAt(num - 1);
                            break;
                        // 회복 혹은 기타 이득 기
                        case 3:
                            player_.CurHp += myHand[num - 1].Value;
                            if (player_.CurHp > player_.MaxHp)
                            {
                                player_.CurHp = player_.MaxHp;
                            }
                            player_.ActionPoint -= myHand[num - 1].ActionCost;
                            myHand.RemoveAt(num - 1);
                            break;
                        case 4:
                            if(player_.ActionPoint < player_.MaxActionPoint)
                            {
                                player_.ActionPoint += myHand[num - 1].Value;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(5, 26);
                                Console.WriteLine("탄약이 넘쳐흘러 낭비했습니다.".PadRight(30, '　'));
                                Console.ResetColor();
                                Thread.Sleep(1000);

                            }
                            myHand.RemoveAt(num - 1);
                            break;
                        case 5:
                            player_.ActionPoint -= myHand[num - 1].ActionCost;
                            for(int i = 0; i < myHand[num - 1].Value; i++)
                            {                               
                                DrawCard(myDeck, myHand, discardDeck);
                            }
                            myHand.RemoveAt(num - 1);
                            break;
                    }
                }
                EnemyDieCheck(enemyList_);

                if (!enemyList_.Any())
                {
                    isMyTurn = false;

                    return;
                }

                uiManager.DrawBattleScene();
                uiManager.PrintBattleIcon(enemyList_);
                uiManager.DrawStatUI(player_.Name, player_.CurHp, player_.MaxHp, player_.ActionPoint);
                uiManager.DrawInputLog();
                uiManager.DrawDeckUi(myDeck);
                uiManager.PrintMyHand(myHand);

                
            }







        }

    

        public void DrawCard(List<Card> myDeck_, List<Card> myHand_,List<Card> discardDeck_)
        {
            Random rand = new Random();
            int drawNum = rand.Next(0, myDeck_.Count);

            // 내 덱이 없을 때 버림 덱을 내 덱으로 가져옴
            if (!myDeck_.Any())
            {
                foreach (Card card in discardDeck_)
                {
                    myDeck_.Add(card);
                }
                discardDeck_.Clear();
                uiManager.DrawDeckUi(myDeck_);

            }

            if (myHand_.Count >= 5)
            {
                uiManager.DrawInputLog();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(5, 26);
                Console.WriteLine("패가 가득 차서 드로우한 [{0,2} ]을(를) 버립니다.".PadRight(10, ' '), myDeck_[drawNum].Name);
                Console.CursorVisible = false;
                Console.ResetColor();
                Thread.Sleep(800);
                discardDeck_.Add(myDeck_[drawNum]);
                myDeck_.Remove(myDeck_[drawNum]);
                return;
            }
           
            myHand_.Add(myDeck_[drawNum]);
            myDeck_.Remove(myDeck_[drawNum]);
        }



        // 적이 공격하는건 함수 명 어떻게??
        public void EnemyAttack(Player player_, Enemy enemy_)
        {
            Random rand = new Random();
            int plus_Minus = rand.Next(0, 2); 

            int damageRange = rand.Next(0, 5);
            
            switch(plus_Minus)
            {
                // 대미지 증가
                case 0:
                    player_.CurHp -= (enemy_.Damage + damageRange );
                    break;
                // 대미지 감소
                case 1:
                    player_.CurHp -= (enemy_.Damage - damageRange);
                    break;
            }

        }

        public void EnemyDieCheck(List<Enemy> enemyList_)
        {
            for(int i = enemyList_.Count - 1; i >= 0 ; i--)
            {
                if (enemyList_[i].CurHp <= 0)
                {
                    enemyList_.Remove(enemyList_[i]);                    
                    Console.Clear();
               
                }

            }
          
        }
       
    }
}
