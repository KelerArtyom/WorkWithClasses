using _20._01_WorkWithClasses;

Cars[] speed = new Cars[5];
Random rand = new Random();

for (int i = 0; i < speed.Length; i++)
{
    speed[i] = new Cars(rand.Next(200), rand.Next(200), rand.Next(200));
    Console.WriteLine(speed[i]);
}

