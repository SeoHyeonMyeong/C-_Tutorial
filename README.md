# C-_Tutorial

## C# 튜토리얼 시작 : 2018-06-23

## .Net Freamwork

### 최근 : https://blog.naver.com/einsbon/220973645616

### 시작 (Hello World)
```cs
using System;

namespace AA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("안녕 C#\n");
        }
    }
}
```
  
### 입력 받기
```cs
using System;

namespace AA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("당신의 이름을 입력하시오 : ");
            String name = Console.ReadLine();
            Console.WriteLine("당신의 이름은 " + name + "입니다.");
        }
    }
}
