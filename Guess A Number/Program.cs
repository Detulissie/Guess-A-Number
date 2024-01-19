/* This is additional practical project and it is not mandatory and it is not included in the final score. 
The main purpose is to use gained knowledge in different type of problems and to improve your portfolio and GitHub skills.
Today we will make the console game "Guess A Number". 
"Guess A Number" is a game, in which your opponent "the computer" chooses a random number between 1 and 100 and your task is to guess this number. 
After each number you enter, the computer will give you a hint of whether the number is greater or less than the number you */
Random random = new Random();
int number = random.Next(random.Next(1,101));
Console.WriteLine("Guess a number between 1-100");
while (true)
{
    int number2 = int.Parse(Console.ReadLine());
    if (number2 > number)
    {
        Console.WriteLine("Too Low");
    }
    else if (number >  number2)
    {
        Console.WriteLine("Too High");
    }
    else Console.WriteLine("You guess the number!");
}

