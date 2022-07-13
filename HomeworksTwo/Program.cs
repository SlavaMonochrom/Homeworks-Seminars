//принимает вход - трёхзначное, выход - вторaя цифра числа
 /*int cutNumber(int a)
{   
    if(a<1000)
        a = (a / 10) % 10;
    else a = -1;    
    return a;
}

Console.WriteLine("Input threedigit number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(cutNumber(x));  
*/



//выводит - третью цифру числа, если его нет - ошибку.
/*
int threeDigit(int num)
{  
    if (num <100) num = -1;
    else 
    { 
	  while(num>=1000)
        num = (num/10);
        num = (num%10);
    }
    return num;
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(threeDigit(number));  


//на вход (число) от юзера, на выход вых/не вых.

/*void weekend(int day)
{
    if(day ==6 || day ==7) Console.WriteLine("Weekend");
    else Console.WriteLine("Not Weekend");
}
Console.WriteLine("Input a day: ");
int today = Convert.ToInt32(Console.ReadLine());
weekend(today);*/
