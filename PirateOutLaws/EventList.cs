using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateOutLaws
{
    public class EventList
    {
        public List<Event> eventList;
        public List<string> dialog;
        public Dictionary<int, Event> eventDic;

        public void Init()
        {
            // 인트로 퀘스트
            Event introQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 보물을 찾기 위한 여정을 떠납니다.");
            dialog.Add("흥미로운 모험 또는 불필요한 싸움을");
            dialog.Add("만날 수 있습니다.");
            dialog.Add("행운이 따라준다면 여정의 끝에");
            dialog.Add("도달할 수 있을 것 입니다.");
            dialog.Add("행운을 빕니다.");
            introQuest.Init(dialog, false,0);

            // 일반 퀘스트 Test 
            Event monkeyQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 원숭이 무리를 발견 했습니다.");
            dialog.Add("원숭이 무리의 대장이 당신을 경계하면서 쳐다봅니다.");
            dialog.Add("원숭이 대장이 공격해서 체력이 감소 하였습니다.");
            dialog.Add("체력이 10 감소합니다.");

            monkeyQuest.Init(dialog, false, 1);

            // 호드 배틀 퀘스트 Test
            Event hodeQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 늦은 밤 불빛을 발견했습니다.");
            dialog.Add("불빛을 따라가니 사람들의 무리가 보입니다.");
            dialog.Add("친절해 보이는 사람들은 아닌 것 같습니다.");
            dialog.Add("전투를 시작합니다.");
            hodeQuest.Init(dialog, true,2);

            // 여관 퀘스트 Test
            Event innQuest = new Event();
            dialog = new List<string>();
            dialog.Add("버려진 집을 발견했습니다.");
            dialog.Add("하룻밤을 보내기에는 충분해 보입니다.");
            dialog.Add("현재 체력이 40 증가했습니다.");
            innQuest.Init(dialog, false, 3);

            // 보물 퀘스트 Test
            Event treasureQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 해변가를 걷고 있습니다.");
            dialog.Add("해변가 바닥에서 X자 표시를 발견했습니다.");
            dialog.Add("X자 표시를 파냈더니 카드 한장을 얻습니다.");
            treasureQuest.Init(dialog, false, 4);

            // 짐승 무리 배틀 퀘스트 Test
            Event beastQuest = new Event();
            dialog = new List<string>();
            dialog.Add("늑대 무리들을 발견했습니다.");
            dialog.Add("당신은 도망가지 못했습니다.");
            dialog.Add("전투를 시작합니다.");
            beastQuest.Init(dialog, true, 5);

            // 독이 든 물 퀘스트
            Event poisonQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 물 웅덩이를 발견 했습니다.");
            dialog.Add("당신은 목이 말라 물을 한모금 마셨습니다.");
            dialog.Add("물은 썩은 물이 였습니다.");
            dialog.Add("체력이 20 감소합니다.");
            poisonQuest.Init(dialog, true, 6);

            // 폐허 퀘스트
            Event ruinQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 폐허가 된 마을을 발견했습니다.");
            dialog.Add("폐허가 된 마을에서 괴물들을 만났습니다.");
            dialog.Add("전투를 시작합니다.");
            ruinQuest.Init(dialog, true, 7);

            // 사냥 퀘스트
            Event huntQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 부상을 입은 야생 동물을 발견했습니다.");
            dialog.Add("집중한 당신은 손쉽게 야생 동물을 사냥했습니다.");
            dialog.Add("최대 체력과 현재 체력이 20씩 증가합니다.");
            huntQuest.Init(dialog, false, 8);

            // 저주 퀘스트
            Event curseQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 의미심장한 석상을 발견했습니다.");
            dialog.Add("자세하게 조사하다가 석상의 일부분이 부서졌습니다.");
            dialog.Add("석상의 저주를 받아 덱에서 카드 한장을 잃습니다.");
            curseQuest.Init(dialog, false, 9);

            // 저주 받은 총 퀘스트
            Event cursedGunQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 암시장을 발견했습니다.");
            dialog.Add("의심스러운 상인이 당신을 바라봅니다.");
            dialog.Add("상인은 당신에게 총을 건네며,");
            dialog.Add("이 총은 당신을 위한 것이라 말합니다.");
            dialog.Add("당신은 총을 받고 불긴함을 느낍니다.");
            cursedGunQuest.Init(dialog, false, 10);




            // 보스 퀘스트
            Event bossQuest = new Event();
            dialog = new List<string>();
            dialog.Add("당신은 여정의 끝에 도달했습니다.");
            dialog.Add("보물을 얻기 위해서는 주인을 처치해야 합니다.");
            dialog.Add("단단히 준비하십시오.");
            dialog.Add("전투를 시작합니다.");
            bossQuest.Init(dialog, true, 10);



            eventDic = new Dictionary<int, Event>();

            eventDic.Add(0, introQuest);
            eventDic.Add(1, monkeyQuest);
            eventDic.Add(2, hodeQuest);
            eventDic.Add(3, innQuest);
            eventDic.Add(4, treasureQuest);
            eventDic.Add(5, beastQuest);
            eventDic.Add(6, poisonQuest);
            eventDic.Add(7, ruinQuest);
            eventDic.Add(8, huntQuest);
            eventDic.Add(9, curseQuest);
            eventDic.Add(10, cursedGunQuest);
            eventDic.Add(11, bossQuest);



            eventList = new List<Event>();

            for(int i = 1; i < eventDic.Count; i++)
            {
                eventList.Add(eventDic[i]);
                
            }
            
        }
    }
}
