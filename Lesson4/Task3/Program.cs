string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s) {
        letters = char.IsAsciiLetter(e) == true ? letters + e : letters;
    }
    return letters; 
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);