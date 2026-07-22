char loopConfirm = 'Y';

while (loopConfirm == 'Y' || loopConfirm == 'y') 
{


Console.WriteLine("Hello and welcome to the Health Calculator\n");
System.Console.WriteLine("Please, put your informations below\n");

System.Console.WriteLine("Wich gender are you? (M/F)");

double weight;
char gender = Convert.ToChar(Console.ReadLine()!);
float height;
int age;
int bmr = 0;



Console.WriteLine("Please, put your weight in kg");
weight = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine($"Please, put your height in cm");
height = Convert.ToSingle(Console.ReadLine()!);
Console.WriteLine($"Please, put your age in years");
age = Convert.ToInt32(Console.ReadLine()!);

if (age < 0 || age > 140 || weight < 0 || weight > 800 || height < 0 || height > 350)
{
    Console.WriteLine("\nYou are not human, please take another calculator to your species\n");
    Console.WriteLine("\nDo you want to calculate again? (Y/N)");
    loopConfirm = Convert.ToChar(Console.ReadLine()!);
    continue;

}


if (gender == 'M' || gender == 'm')
{

   bmr = Convert.ToInt32((10 * weight) + (6.25 * height) - (5 * age) + 5);
}

else if (gender == 'F' || gender == 'f')
{

    bmr = Convert.ToInt32((10 * weight) + (6.25 * height) - (5 * age) - 161);
}

else
{ 
    
    Console.WriteLine("Invalid gender input. Please enter 'M' for male or 'F' for female.");
    return;

}




Console.WriteLine($"\nYour BMR (Basal Metabolic Rate) is {bmr} kcal per day\n");


Console.WriteLine("Wich of this stats you think you are? (1-5)\n 1.Sedentary (little or no exercise, desk job)\n 2.Lightly Active (light exercise 1 to 3 days/week)\n 3.Moderately Active (moderate exercise 3 to 5 days/week)\n 4.Very Active (heavy exercise 6 to 7 days/week)\n 5.Extremely Active (athlete or physical job + training)\n");

double[] stats = { 1.2, 1.375, 1.55, 1.725, 1.9 };

int option = Convert.ToInt32(Console.ReadLine());

double optionStats = stats[option - 1];

int tdee = (int)(bmr * optionStats); 

Console.WriteLine($"\nYour TDEE (Total Daily Energy Expenditure) is {tdee} kcal per day\n");

int [] defict = {300, 500, 700, 1000, 0, -300, -500, -700, -1000};

System.Console.WriteLine("\n Wich situation you want to be in? (1-9)\n 1. Mild weight loss (-300 kcal/day)\n 2. Moderate weight loss (500 kcal/day)\n 3. Aggressive weight loss (700 kcal/day)\n 4. Extreme weight loss (1000 kcal/day)\n 5. Maintain current weight\n 6. Mild weight gain (+300 kcal/day)\n 7. Moderate weight gain (+500 kcal/day)\n 8. Aggressive weight gain (+700 kcal/day)\n 9. Extreme weight gain (+1000 kcal/day)\n");

int optionDefict = Convert.ToInt32(Console.ReadLine());

int finalCalories = (int)(tdee - defict[optionDefict - 1]);

Console.WriteLine($"\nYour final calories to take your goal is {finalCalories} kcal per day\n");

if (finalCalories < bmr)
{
    Console.WriteLine("Warning: Your final calorie intake is below your BMR. This may not be safe for your health. Please consult with a healthcare professional before making significant changes to your diet.");
}

Console.WriteLine("\nGood lucky =)");

Console.WriteLine("\nDo you want to calculate again? (Y/N)");
loopConfirm = Convert.ToChar(Console.ReadLine()!);

}

Console.WriteLine("\nThank you for using the Health Calculator. Goodbye!");






