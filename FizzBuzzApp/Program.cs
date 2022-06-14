using FizzBuzzEmbedded;

string Instructions = "";

Instructions += "You will be asked to provide an upper bound value and the application will \r\n";
Instructions += "list the numbers from 1 to the upper bound number and convert the appropriate \r\n";
Instructions += "numbers to the words associated with those divisors. \r\n";

Console.Write(Instructions);
Console.Write("\r\n");
Console.Write("Press Enter to Continue.....");
Console.ReadLine();

//int i as integer
int? val;

//Get Upper Bound input
Console.Write("Enter upper bound: ");
val = Convert.ToInt32(Console.ReadLine());

//Fill pairsList
List<ValueNamePairs> pairsList = new();

pairsList.Add(new ValueNamePairs(11, "Razzmatazz"));
pairsList.Add(new ValueNamePairs(3, "Fizz"));
pairsList.Add(new ValueNamePairs(5, "Buzz"));
pairsList.Add(new ValueNamePairs(9, "Jazz"));
pairsList.Add(new ValueNamePairs(10, "Razz"));
pairsList.Add(new ValueNamePairs(-10, "NegativeNumber"));

List<string> listOfStrings = FizzBuzzEmbedded.FizzBuzzEmbedded.WordListOrFizzBuzzResult(pairsList, val.Value);

foreach (string item in listOfStrings)
{
    Console.WriteLine(item);
}



