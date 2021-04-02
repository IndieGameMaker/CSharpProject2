#pragma warning disable CS0414

using System;

namespace CSharpProject2
{
    // 클래스
    // 함수(메서드), 변수의 집합

    /* 접근제한자, 접근지시자
        public 외부 클래스에서 접근 가능
        private 외부 클래스에서 접근 불가능
    */

    /* 객체지향 언어 특징(OOP)
        필드(Field)             : 내부적으로 사용하는 변수 (외부에서 접근 불가) : 데이터 은닉
        프로퍼티(Properties)     : 외부에서 접근 가능한 변수
        메서드(Method)          : 함수(Funtion)
        이벤트(Event)           : 특정 조건을 만족했을 때 호출되는 함수

        //이벤트 : 콜백펑션(Call Back Function)
    */

    public class Enemy
    {
        //필드(Field) : 멤버(Member) m_Age, m_Level
        //접근제한자 데이터타입 변수명 = 초깃값
        private string name = "No Name";
        private int hp = 100;
        private int speed = 10;

        //프로퍼티 정의 : 외부에서 접근가능함.
        public string Name
        {
            get { return this.name;}   //getter
            set {
                this.name = value;
            }   //setter
        }

        public int Hp
        {
            get { return this.hp; }
            set {
                this.hp = value;
                if (this.hp <= 0)
                {
                    //적캐릭터의 사망로직 처리
                    Console.WriteLine($"{this.name} is died !!!");
                }
            }
        }

        public int Speed
        {
            get {return this.speed;}
            set {
                this.speed = value;
                Console.WriteLine($"{this.name}'s Speed Changed {this.speed}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            string enemyName = enemy.Name;
            Console.WriteLine(enemyName);

            enemy.Name = "Orc";
            Console.WriteLine(enemy.Name);
            enemy.Hp = 0;
            enemy.Speed = 20;
        }
    }
}
