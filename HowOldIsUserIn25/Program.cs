Console.Write("Please enter your age: ");
string? age = Console.ReadLine();
bool isValidAge = int.TryParse(age,out int intAge);

if (isValidAge)
{
    AddAndSubtractAge(intAge);
}
else
{
    checkEntryOfAge(isValidAge, intAge);
}
    
void checkEntryOfAge(bool isValidAge, int intAge)
{
    while (isValidAge != true)
    {
        Console.WriteLine("Do not spell numbers, only use digits");
        age = Console.ReadLine();
        isValidAge = int.TryParse(age, out intAge);
        if (isValidAge == true)
        {
            if (intAge >= 60 && intAge <= 150)
            {
                Console.WriteLine("You're old!");
                AddAndSubtractAge(intAge);
            }
            else if (intAge < 60)
            {
                Console.WriteLine();
                AddAndSubtractAge(intAge);
            }
            else
            {
                Console.WriteLine("No human is over 150. Please tell us your actual age.");
                isValidAge = false;
            }
        }
    }
}

void AddAndSubtractAge(int age)
{
    int ageInFuture = age + 25;
    int ageInPast = age - 25;
    Console.WriteLine("In 25 years, you will be " + ageInFuture + ". Your age 25 years ago is " + ageInPast);
}
