using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateOutLaws
{
    public class QuestManager
    {
        public List<Quest> questList;
        public List<string> dialog;
        public Dictionary<string, List<Quest>> eventList;
        
        public void Init()
        {
            // 인트로 퀘스트
            Quest introQuest = new Quest();
            dialog = new List<string>();
            dialog.Add("당신은 보물을 찾기 위한 여정을 떠납니다.");
            dialog.Add("흥미로운 모험 또는 불필요한 싸움을 만날 수 있습니다.");
            dialog.Add("행운이 따라준다면 여정에 끝에 도달할 수 있을 것입니다.");
            dialog.Add("행운을 빕니다.");            
            introQuest.Init(dialog,false);

            // 일반 퀘스트 Test 
            Quest monkeyQuest = new Quest();
            dialog = new List<string>();
            dialog.Add("당신은 원숭이 무리를 발견 했습니다.");
            dialog.Add("원숭이 무리의 대장이 당신을 경계하면서 쳐다봅니다.");
            dialog.Add("원숭이 대장이 공격해서 체력이 감소 하였습니다.");
            monkeyQuest.Init(dialog, false, -20);

            // 호드 배틀 퀘스트 Test
            Quest hodeQuest = new Quest();
            dialog = new List<string>();
            dialog.Add("당신은 늦은 밤 불빛을 발견했습니다.");
            dialog.Add("불빛을 따라가니 사람들의 무리가 보입니다.");
            dialog.Add("친절해 보이는 사람들은 아닌 것 같습니다.");
            dialog.Add("전투를 시작합니다.");
            hodeQuest.Init(dialog,true);

            // 여관 퀘스트 Test
            Quest innQuest = new Quest();
            dialog = new List<string>();
            dialog.Add("버려진 집을 발견했습니다.");
            dialog.Add("하룻밤을 보내기에는 충분해 보입니다.");
            dialog.Add("체력이 10 상승했습니다.");
            innQuest.Init(dialog, false, 10);

            // 보물 퀘스트 Test
            Quest treasureQuest = new Quest();
            dialog = new List<string>();
            dialog.Add("바닥에 X자 표시를 발견했습니다.");
            dialog.Add("X자 표시를 파냈더니 카드 한장을 얻습니다.");            
            treasureQuest.Init(dialog, false, 0);

            // 짐승 무리 배틀 퀘스트 Test
            Quest beastQuest = new Quest();
            dialog = new List<string>();
            dialog.Add("들개 무리들을 발견했습니다.");
            dialog.Add("당신은 도망가지 못했습니다.");
            dialog.Add("전투를 시작합니다.");
            beastQuest.Init(dialog, true, 0);

            questList = new List<Quest>();

            questList.Add(introQuest);
            questList.Add(monkeyQuest);
            questList.Add(hodeQuest);
            questList.Add(innQuest);
            questList.Add(treasureQuest);
            questList.Add(beastQuest);




        }

    }
}
