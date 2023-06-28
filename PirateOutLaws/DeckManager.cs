using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class DeckManager
    {
        public List<Card> CardDeck { get; set; }
        public List<Card> MyDeck { get; set; }
        public List<Card> MyHand { get; set; }
        public List<Card> DiscardDeck { get; set; }
        public List<Card> WinSelectCard { get; set; }

        // 전체 카드 덱 
        public void InitCardDeck()
        {
            Card slash = new Card();
            slash.Init("베기", 0, 8, 0,"근접　");
            Card nanta = new Card();
            nanta.Init("난타", 0, 9, 0,"근접　");
            Card shot = new Card();
            shot.Init("사격", 1, 10, 1,"원거리");
            Card accuShot = new Card();
            accuShot.Init("속사", 2, 17,1,"원거리");
            Card wholeShot = new Card();
            wholeShot.Init("난사", 3, 20,2,"범위　");
            Card windstorm = new Card();
            windstorm.Init("광풍", 0, 9, 0,"근접　");
            Card allin = new Card();
            allin.Init("올인", 0, 15, 0, "근접　");
            Card quickShot = new Card();
            quickShot.Init("큇샷",0, 9, 1, "원거리");


            CardDeck = new List<Card>
            {
                slash,
                nanta,
                shot,
                accuShot,
                wholeShot,
                windstorm,
                allin,
                quickShot

            };

        }
        // 플레이어 초기 덱
        public void InitMyDeck()
        {
            MyDeck = new List<Card>();

            for (int i = 0; i < 2; i++)
            {
                Card fist = new Card();
                fist.Init("주먹", 0, 6, 0,"근접　");
                MyDeck.Add(fist);
            }

            for (int i = 0; i < 2; i++)
            {
                Card slash = new Card();
                slash.Init("베기", 0, 8, 0, "근접　");
                MyDeck.Add(slash);

            }

            for (int i = 0; i < 2; i++)
            {
                Card shot = new Card();
                shot.Init("사격", 1, 10, 1,"원거리");
                MyDeck.Add(shot);

            }


            Card food = new Card();
            food.Init("식량", 1, 30, 3,"회복　");
            MyDeck.Add(food);


        }

        public void InitMyHand()
        {
            MyHand = new List<Card>();
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randIndex = rand.Next(1, MyDeck.Count);
                MyHand.Add(MyDeck[randIndex - 1]);
                MyDeck.RemoveAt(randIndex - 1);
            }
        }

        public void InitDiscardDeck()
        {
            DiscardDeck = new List<Card>();
        }

        public void InitWinSelectCard(List<Card> cardDeck)
        {
            Random rand = new Random();

            WinSelectCard = new List<Card>();
            for(int i = 0; i < 3; i++)
            {
                int randNum = rand.Next(0, cardDeck.Count);
                WinSelectCard.Add(cardDeck[randNum]);

            }
        }


        public void ChooseWinCard(List<Card> WinSelectCard, List<Card> myDeck)
        {

            while(true)
            {
                Console.SetCursorPosition(18, 26);
                Console.WriteLine("사용할 카드를 선택하세요.");
                Console.CursorVisible = true;
                Console.SetCursorPosition(18, 27);
                int.TryParse(Console.ReadLine(), out int num);
                if (num <= WinSelectCard.Count && num > 0)
                {
                    myDeck.Add(WinSelectCard[num - 1]);
                    Console.Clear();
                    break;

                }
            }
          
        }
    }
}
