using System;

namespace Exam
{
	class Program
	{
		static int Main(String[] args)
		{
			Console.WriteLine("Hello World");
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
		int point;
		
		public Player() {
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
		
		}
		public Exp_Check() {		//경험치 체크
			if(Exp.Max <= Exp.Value) {
				Level_Up();
			}
		}
		private Level_Up() {		//레벨 업
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
	
	class Monster	//몬스터
	{
		bar Hp;
		int level;
		int feed_Exp;
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
