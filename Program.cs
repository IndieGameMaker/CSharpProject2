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

    //Base Class / Mother Class / 부모 클래스
    public class Enemy
    {
        //필드(Field) : 멤버(Member) m_Age, m_Level
        //접근제한자 데이터타입 변수명 = 초깃값
        //private string name = "No Name";
        private int hp = 100;
        private int speed = 10;

        //프로퍼티 정의 : 외부에서 접근가능함.
        // public string Name
        // {
        //     get { return this.name;}   //getter
        //     set {
        //         this.name = value;
        //     }   //setter
        // }
        //Auto Property
        public string Name {get;set;}

        public int Hp
        {
            get { return this.hp; }
            set {
                this.hp = value;
                if (this.hp <= 0)
                {
                    //적캐릭터의 사망로직 처리
                    EnemyDie();
                }
            }
        }

        public int Speed
        {
            get {return this.speed;}
            set {
                this.speed = value;
                Console.WriteLine($"Base Class : {Name}'s Speed Changed {this.speed}");
            }
        }

        //가상 메서드 - 상속을 허용
        public virtual void EnemyDie()
        {
            Console.WriteLine($"Base Class : {Name} is Die!!!");
        }
    }

    //클래스 상속
    //파생 클래스 (Abstract Class)
    public class Orc : Enemy
    {
        private int gemCount = 0;

        //생성자 Constructor
        public Orc()
        {
            base.Name = "Orc";
            base.Speed = 10;
            base.Hp = 500;            
        }

        //메서드 오버라이드 (상속: 부모 클래스의 로직을 포함해서 새로운 로직 추가할 수 있다.)
        public override void EnemyDie()
        {
            base.EnemyDie();
            //새로운 로직을 추가
            gemCount = 100;
            Console.WriteLine($"Gem Count = {gemCount}");
        }
    }

    public class Goblin : Enemy
    {
        //생성자
        public Goblin(string _Name, int _Hp, int _Speed)
        {
            base.Name = _Name;
            base.Speed = _Speed;
            base.Hp = _Hp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        /*             //오크 캐릭터 생성 및 초기화
            // Enemy enemy = new Enemy();
            // string enemyName = enemy.Name;
            // Console.WriteLine(enemyName); //No Name

            // enemy.Name = "Orc";
            // Console.WriteLine(enemy.Name);
            // enemy.Hp = 0;
            // enemy.Speed = 20;

            //고블린 캐릭터 생성 및 초기화
            // Enemy goblin = new Enemy();
            // goblin.Name = "Goblin";
            // goblin.Hp = 100;
            // goblin.Speed = 50; */

            Orc orc = new Orc();
            Console.WriteLine(orc.Name);
            orc.Hp = 0;

            Goblin goblin = new Goblin("Goblin", 50, 500);
        }
    }
}
