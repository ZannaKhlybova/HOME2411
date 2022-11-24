// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все целые числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void ShowNumbers(int n)
{
 if (n>1)
 {
   Console.Write(n+" ");
    ShowNumbers(n-1);
 }
 if (n<1)
 {
    Console.Write(n+" ");
    ShowNumbers(n+1);
 }
if (n==1)
     Console.Write(n+ " ");
 } 
Console.Write("Введите число ?");
int a = Convert.ToInt32(Console.ReadLine());
ShowNumbers(a);

//Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*int SumNat(int m,int n)
{
    if(n-m>=0) return n+SumNat(m,n-1);
    else return 0;
}
Console.Write("Введите M ?");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N ?");
int b = Convert.ToInt32(Console.ReadLine());
    if(a>b) Console.Write(SumNat(b,a));
    else Console.Write(SumNat(a,b));
 */   
//Задача 68: Напишите программу вычисления функции Аккермана
// с помощью  рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
/*int Accerman(int m,int n)
{
    if (m == 0) return n + 1;
    if (n == 0 &&  m >0) return Accerman(m - 1, 1);
    if (m>0 && n>0) return Accerman(m-1,Accerman(m,n-1));
return 0;              
}
Console.Write("Введите m ?");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n ?");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(Accerman(a,b));*/