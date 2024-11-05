using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Encryptor
{
    public string Encrypt(string message, int key)
    {
        // Adjust key to ensure it's between 1 and 26
        key %= 26;
        char[] buffer = message.ToUpper().ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (char.IsLetter(letter))
            {
                letter = (char)(letter + key);
                if (letter > 'Z') letter = (char)(letter - 26);
                buffer[i] = letter;
            }
        }

        return new string(buffer);
    }
}
