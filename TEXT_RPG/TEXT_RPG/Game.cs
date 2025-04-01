using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEXT_RPG.Scenes;

// static : 정적인, 고정된
// static 앞에 붙는 변수나 메서드는 어떤 객체에 소속되는 것이 아닌,
// 클래스에 고정되어 있는 변수나 메서드
// 처음부터 끝까지 사용할수 있는

// public : 공공의
// public 제어자는 해당 멤버를 모든 클래스에서 접근 가능하다.
// 해당 멤버가 외부에서 자주 사용되는 경우나, 외부에 노출되어도 문제가 없을 경우에 사용
namespace TEXT_RPG
{
    public static class Game
    {
        // 게임에 필요한 정보
        // private : 사적인
        // 외부에서 클래스 혹은 클래스 멤버로의 접근을 허용하지 않는다
        private static bool gameOver; // 게임이 무한히 작동 되지 않도로 변수 생성

        private static Dictionary<string, Scene> sceneDic; // 원하는 씬을 빨리 찾기위하여 디셔너리 쓴다
        private static Scene curScene; // 현재 진행중인 씬

        // 상황들




        // 게임에 필요한 기능
        public static void Start() // 게임 시작 기능
        // void : 빈 공간, 공허의
        // 함수명을 지을때 해당 함수가 리턴하는 값의 데이터타입을 함수명앞에 명시해야함
        // void를 앞에 붙여주면 해당함수는 리턴 값이 없다 라는걸 의미
        {
            // 게임 시작시 필요한 작업들

            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());

            // 처음 시작할 씬을 선정
            curScene = sceneDic["Title"];
        }

        public static void End() // 게임 종료 기능
        // 공공의 고정된 빈공간의 End 함수
        {
            // 게임 종료시 필요한 작업들
        }

        public static void Run() // 게임 동작 기능
        {
            // 게임 동작시 필요한 작업들
            while (gameOver == false) // 게임오버(gameOver)가 (같다 == )거짓(false)이면,
            // 게임오버 될때까지(true) 계속(반복 : while 반복문) 작동
            {

                Console.Clear(); // 콘솔창 지우고 다시 새창

                curScene.Render(); // 씬 보여주기
                curScene.Choice(); // 선택지
                curScene.Input(); // 입력받기
                curScene.Result(); // 결과 보여주기
                curScene.Wait(); // 기다리기
                curScene.Next(); // 다음 씬



            }
        }
    }
}
