// collect the message
Console.WriteLine("Enter your message!: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');
string[] pigLatinWords = new string[words.Length];

string vowels = "aeiouAEIOU";

for (int i = 0; i < words.Length; i++)
{
    string word = words[i].ToLower().TrimEnd('.', '!', '?');
}