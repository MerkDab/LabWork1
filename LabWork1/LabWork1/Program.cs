Console.WriteLine("Введите целое неотрицательное число:");
int someNum = Convert.ToInt32(Console.ReadLine());
someNum += 5;
someNum *= 2;
Console.WriteLine(someNum);
Random rnd = new Random();
int[] someMassiv = new int[someNum];
for (int i = 0; i < someMassiv.Length; i++)
{
    someMassiv[i] = rnd.Next(0, 100);
    Console.WriteLine(someMassiv[i]);
}
