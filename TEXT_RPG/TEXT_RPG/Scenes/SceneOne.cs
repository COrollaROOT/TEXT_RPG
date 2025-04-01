using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXT_RPG.Scenes
{
    class SceneOne : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1. 몸부림 친다.");
            Console.WriteLine("2. 가만히 있는다.");
        }

        public override void Next()
        {
            throw new NotImplementedException();
        }

        public override void Render()
        {
            Console.WriteLine("타닥..타닥..타닥..틱.타닥..타닥..");
            Console.WriteLine("희미하게 모닥불이 타들어가는 소리가 들린다.\n 그 소리에 정신이 번쩍든다...");
            Console.WriteLine("'으...여기가 어디지...온 몸이 아파....'\n 눈을 떠 보려 했지만 눈이 두건 같은것에 가려 보이지 않는다.");
            Console.WriteLine("손발도 묶여 있는거 같다.그리고...\n 더 무서운 사실은 거꾸로 매달려 있다는 사실이다.");
            Console.WriteLine("거꾸로 매달려서 피가 몰리고 있는 머리로 가까스로 여기까지 온 경위를 곱씹어 본다.");
            Console.WriteLine("'이런 젠장 이렇게 될거라고 생각 못했는데...역시 이런곳 까지 오는게 아니였어...'");            
            Console.WriteLine("그 순간 멀리서 알아 들을수 없는 소리가 들린다.");
            Console.WriteLine("'이런 벌써 돌아온건가....어떻하지....'");
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void Wait()
        {
            throw new NotImplementedException();
        }
    }
}
