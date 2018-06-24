# C-_Tutorial

## C# 튜토리얼 시작 : 2018-06-23

## .Net Freamwork

### 최근 : http://jeong-pro.tistory.com/category/C%23

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
```
### 형변환 하기
1. (int)a
2. (pi).ToString()
3. int.Parse("32")
4. float.Parse("3.14")
