string name = "Ewa";
string sex = "kobieta";
int age = 27;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name=="Ewa"&&age<30)
{
    Console.WriteLine("Ewa lat 33");
}
if (sex == "mężczyzna")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}