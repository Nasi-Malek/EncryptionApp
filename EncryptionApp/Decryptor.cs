using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Decryptor
{
    public string Decrypt(string message, int key)
    {
        key %= 26;
        char[] buffer = message.ToUpper().ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (char.IsLetter(letter))
            {
                letter = (char)(letter - key);
                if (letter < 'A') letter = (char)(letter + 26);
                buffer[i] = letter;
            }
        }

        return new string(buffer);
    }

    public void BruteForceDecrypt(string message)
    {
        Console.WriteLine("Trying all possible keys...");
        for (int key = 1; key <= 26; key++)
        {
            Console.WriteLine($"Key {key}: {Decrypt(message, key)}");
        }
    }
}
