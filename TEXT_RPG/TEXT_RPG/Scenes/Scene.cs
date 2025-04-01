using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXT_RPG.Scenes
{
    // Scene들이 다양한 상황을 연출하기 위해 각자의 Scene이 필요 abstract 추상 키워드 사용
    // abstract 키워드를 사용하면 불완전하여 파생 클래스에서 구현해야 하는 클래스 및 클래스 맴버 만들 수 있다
    // 여러개의 파생 클래스에서 공유할 기본 클래스의 공통적인 정의를 제공
    public abstract class Scene // 기본 Scene들 구현
    {
        // protected : 상속관계일 때 접근이 가능합니다
        protected ConsoleKey input;

        public abstract void Render(); // Scene 보여주다,세우다




        public abstract void Choice(); // 선택지 구현


        public void Input() // 입력은 어느 씬에서도 다 똑같이 쓸것이기때문에 부모 객체에서 구현
            // 입력 구현 // 입력을 받아줄 변수 구현 (콘솔키)
        {
            input = Console.ReadKey(true).Key;
        }


        public abstract void Result(); // 입력 결과 구현


        public abstract void Wait(); // 결과 기다리기


        public abstract void Next(); // 다음 결과 구현
        
    }
}
