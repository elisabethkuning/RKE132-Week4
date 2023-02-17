Random rnd = new Random();


//int myRandomNum = rnd.Next(0, 11); // genereeritakse väärtused 0-10
//Console.WriteLine($"My random number is: {myRandomNum}");

int myRandomNum;
int myRandomSum = 0;

for(int i = 0; i < 5; i++)
{
    myRandomNum = rnd.Next(0, 11); // genereeritakse väärtused 0-10
    myRandomSum = myRandomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Ramdom sum total: {myRandomSum}");
