var range = 250;
var counts = new int[range];
int totalCharacters = 0;
string text = "something";

Console.WriteLine("enter a bunch of leters and see percentages: ");
while (!string.IsNullOrWhiteSpace(text))
{
    Console.WriteLine("Your input here: ");
    text = Console.ReadLine().ToLower();
    foreach (var character in text ?? string.Empty)
    {
        totalCharacters++;
        counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {

        if (counts[i] > 0)
        {

            var percent = 100 * counts[i] / totalCharacters;
            var character = (char)i;
            var answer = character + " - " + percent.ToString("F2") + "%";
            var length = answer.Length;
            Console.CursorLeft = Console.BufferWidth - length;
            Console.WriteLine(answer);

        }
    }
}
