// collect the message
Console.WriteLine("Enter your message!: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');
string[] pigLatinWords = new string[words.Length];

string vowels = "aeiouAEIOU";

for (int i = 0; i < words.Length; i++)
{
    //grabbing any of the punctuation
    string word = words[i].ToLower().TrimEnd('.', '!', '?');
    string punctuation = words[i].Substring(word.Length);

    if (vowels.Contains(word[0]))
    {
        pigLatinWords[i] = word + "way" + punctuation;
    }
    else
    {
        int firstVowelIndex = -1;
        for (int j = 0; j < word.Length; j++)
        {
            if (vowels.Contains(word[j]))
            {
                firstVowelIndex = j;
                break;
            }
        }

        if (firstVowelIndex == -1)
        {
            pigLatinWords[i] = word + "ay" + punctuation;
        }
        else
        {
            string cluster = word.Substring(0,firstVowelIndex);
            string rest = word.Substring(firstVowelIndex);
            pigLatinWords[i] = rest + cluster + "ay" + punctuation;
        }
    }
}

string fullPigLatin = string.Join(" ", pigLatinWords);
Console.WriteLine($"In pig latin that is: " {fullPigLatin});