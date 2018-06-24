using System;

namespace Exam
{
	class Program
	{
		static int Main(String[] args)		// 메인함수
		{
			Console.WriteLine("Hello World");
			Player user1;
			Slime slime1;
			user1.
		}
	}
	
	
	class Player	// 플레이어
	{
		bar Hp;
		bar Mp;
		bar Exp;
		int level;
		int damage;
		int damage_increase;
		int Hp_increase;
		int Mp_increase;
		int point;
		int speed;
		char[] name;
		
		public Player() {	// 생성자
			Hp.Max = 50;
			Hp.Set();
			Mp.Max = 0;
			Mp.Set();
			Exp.Max = 100;
			Exp.Value = 0;
			level = 1;
			damage = 5;
			damage_increase = 1;
			point = 0;
			speed = 250;
			name = new char[] "유저";
		
		}
		
		public Exp_Check() {		// 경험치 체크
			if(Exp.Max <= Exp.Value) {
				Level_Up();
			}
		}
		
		private Level_Up() {		// 레벨 업
			Exp.Value -= Exp.Max;
			Exp.Max = level * level * 100;
			level ++;
			damage += damage_increase;
			Hp.Max += Hp_increase;
			Mp.Max += Mp_increase;
			Hp.Set();
			Mp.Set();
			point += 3;
		}
		
		public damaged(int num) {	// 피해를 입음
			Hp.Value -= num;
		}
		
		public Attack(Monster monster) {	// 공격 _ 대상은 몬스터
			monster.damaged(damage);
			Console.WriteLine(name + "\(이\)가 " + damage + "의 피해를 입혔습니다." );
		}		
		
		public Fight_Monster(Monster monster) {		// 몬스터와 싸움
			if(speed >= monster.speed){
				Attack(monster);
			}
		}
	}
	
	class Monster	// 몬스터
	{
		bar Hp;
		int level;
		int feed_Exp;
		int speed;
		int damage;
		char[] name;
		
		public Attack(Player user) {	// 공격 _ 대상은 플레이어
			user.damaged(damage);
			Console.WriteLine(name + "\(이\)가 " + damage + "의 피해를 입혔습니다." );
		}
		
		public damaged(int num) {	// 피해를 입음
			Hp.Value -= num;
		}
	}
	
	class Slime : Monster	// 슬라임
	{
		public Slime() {
			Hp.Max = 20;
			Hp.Set();
			level = 1;
			feed_Exp = 10;
			speed = 200;
			damage = 2;
			name = new char[] "슬라임";
	}
	
	struct bar		// 체력바, 마나바, 경험치바 등등
	{
		int Max;
		int Value;
		void Set() {
			Value = Max;
		}
	}
}
