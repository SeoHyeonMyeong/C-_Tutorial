

import java.util.*;
import java.lang.*;
import java.io.*;


class HelloWorld
{
	public static void main (String[] args) throws java.lang.Exception
	{
		System.out.println("안녕 자바");
	}
	
}
class Player
{
	int Hp;
	int Hp_Max;
	int Mp;
	int Mp_Max;
	int Exp;
	int Exp_Max;
	int level;
	int damage;
	int damage_increase;
	int Hp_increase;
	int Mp_increase;
	int point;
	int speed;
	String name;
	
	public Player() {
		Hp_Max = 50;
		Hp = Hp_Max;
		Mp_Max = 0;
		Mp = Mp_Max;
		Exp_Max = 100;
		Exp = 0;
		level = 1;
		damage = 5;
		damage_increase = 1;
		Hp_increase = 10;
		Mp_increase = 0;
		point = 0;
		speed = 250;
		name = "유저";
	}
}
