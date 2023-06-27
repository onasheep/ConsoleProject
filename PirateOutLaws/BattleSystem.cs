using ConsoleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PirateOutLaws
{
    public class BattleSystem
    {
        bool isFirstTurn = true;
        bool isPick;
        bool isTurnEnd = false;
        UIManager uiManager;
     
        public void Init()
        {
            uiManager = new UIManager();
            
        }

        // 행동력 추가하기( 폴리싱)
        public void Battle(List<Card> myHand, List<Card> discardDeck, List<Card> myDeck,Player player_, List<Enemy> enemyList_)
        {
            Init();
            isPick = false;

            if (!isFirstTurn)
            {
                DrawCard(myDeck, myHand);
            }
            // 플레이어 공격 
            if (myDeck.Any())
            {
                while (!isPick) // !isPick
                {

                    ChooseCard(myHand, discardDeck, player_, enemyList_);
                    uiManager.DrawBattleScene(myDeck.Count, enemyList_);
                    uiManager.PrintMyHand(myHand);
                    uiManager.DrawBattleScene(myDeck.Count, enemyList_);
                    uiManager.DrawStatUI(player_.Name, player_.CurHp, player_.MaxHp, player_.ActionPoint);
                    uiManager.DrawInputLog();
                    uiManager.DrawDeckUi(myDeck);
                    uiManager.PrintMyHand(myHand);

                }
                Console.Clear();

                DrawCard(myDeck, myHand);
            }
            else
            {
                foreach(Card card in discardDeck)
                {
                    myDeck.Add(card);                    
                }
                discardDeck.Clear();

            }

            EnemyCheck(enemyList_);

            // 적 공격
            for (int i = 0; i < enemyList_.Count; i++)
            {
                EnemyAttack(player_, enemyList_[i]);

            }

        }



        // 플레이어가 카드를 뽑아서 하는 행동들 
        public void ChooseCard(List<Card> myHand, List<Card> discardDeck, Player player_, List<Enemy> enemyList_)
        {
            Console.SetCursorPosition(5, 26);
            Console.WriteLine("사용할 카드를 선택하세요.");
            Console.CursorVisible = true;

            Console.SetCursorPosition(5, 27);
            string input = Console.ReadLine();
            int.TryParse(input, out int num);


            if (num <= myHand.Count && num > 0)
            {
                discardDeck.Add(myHand[num - 1]);
                switch (myHand[num - 1].TargetIndex)
                {
                    // 근접 가장 앞쪽 적 공격
                    case 0:
                        enemyList_[0].CurHp -= myHand[num - 1].Value;
                        player_.ActionPoint -= myHand[num - 1].ActionCost;
                        myHand.RemoveAt(num - 1);
                        isPick = true;
                        break;
                    // 원거리 가장 뒷쪽 적 공격, 뒤쪽 적이 죽은 경우 앞쪽 공격
                    case 1:
                        enemyList_[enemyList_.Count - 1].CurHp -= myHand[num - 1].Value;
                        player_.ActionPoint -= myHand[num - 1].ActionCost;
                        myHand.RemoveAt(num - 1);
                        isPick = true;
                        break;
                    // 범위 공격, 뒤쪽 적이 죽은 경우 앞쪽 한번 공격
                    case 2:
                        for (int i = 0; i < enemyList_.Count; i++)
                        {
                            enemyList_[i].CurHp -= myHand[num - 1].Value;
                        }
                        player_.ActionPoint -= myHand[num - 1].ActionCost;
                        myHand.RemoveAt(num - 1);
                        isPick = true;
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
                        isPick = true;
                        break;
                }
            }
            
            
            
            

        }

        public void DrawCard(List<Card> myDeck_, List<Card> myHand_)
        {
            Random rand = new Random();
            int drawNum = rand.Next(0, myDeck_.Count);
            Console.WriteLine("{0}", myDeck_[drawNum].Name);

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

        public void EnemyCheck(List<Enemy> enemyList_)
        {
            for(int i = enemyList_.Count - 1; i >= 0 ; i--)
            {
                if (enemyList_[i].CurHp <= 0)
                {
                    enemyList_.Remove(enemyList_[i]);
                }

            }
            Console.Clear();
          
        }
       
    }
}
