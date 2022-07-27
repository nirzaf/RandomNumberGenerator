// See https://aka.ms/new-console-template for more information

using RandomNumberGenerator;

for(int i=0; i<10; i++)
{
    Console.WriteLine("Request Number :  " + RandomRequestNumber.Generate());
}

Console.ReadLine();