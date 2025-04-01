using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXT_RPG.Scenes
{
    public class TitleScene : Scene // TitleScene 은 Scene 을 상속 받는다
    {
        

        public override void Next()
        // 투두 주석 : 아직 해결되지 않은 작업이나 구현해야 할 부분을 나타내는 주석 태그  
        // 석으로 TODO와 함께 어떤 작업이 필요한지 간단히 설명하고 나중에 찾기 쉽고도록 남겨둡니다.
        // 이렇게 해두면 나중에 작업할 때 놓치지 않고 처리할 수 있습니다
        {
            // TODO : 다음 씬으로 전환 구현 필요
        }

        public override void Render() // 타이틀 씬 표현
        {
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("▒§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§▒");
            Console.WriteLine("▒♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣▒");
            Console.WriteLine("▒▒▒♣♣♣♣※※  Wild Jungle  ※※♣♣♣♣▒▒▒");
            Console.WriteLine("▒▒▒♣♣♣♣※※    Survive    ※※♣♣♣♣▒▒▒");
            Console.WriteLine("▒♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣▒");
            Console.WriteLine("▒§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§▒");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine();
        }

        public override void Result()
        {
            
        }

        public override void Choice() // 타이틀 화면 선택지
        {
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 게임 종료");
        }

        public override void Wait()
        {
            
        }
    }
}
