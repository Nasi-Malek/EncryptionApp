using System;

class Program
{
    static void Main()
    {
        Encryptor encryptor = new Encryptor();
        Decryptor decryptor = new Decryptor();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Encrypt a message");
            Console.WriteLine("2. Decrypt a message with a key");
            Console.WriteLine("3. Decrypt a message without a key");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter message to encrypt: ");
                    string message = Console.ReadLine();
                    Console.Write("Enter key (1-26): ");
                    int encryptKey = int.Parse(Console.ReadLine());
                    string encryptedMessage = encryptor.Encrypt(message, encryptKey);
                    Console.WriteLine("Encrypted Message: " + encryptedMessage);
                    break;

                case "2":
                    Console.Write("Enter message to decrypt: ");
                    message = Console.ReadLine();
                    Console.Write("Enter key (1-26): ");
                    int decryptKey = int.Parse(Console.ReadLine());
                    string decryptedMessage = decryptor.Decrypt(message, decryptKey);
                    Console.WriteLine("Decrypted Message: " + decryptedMessage);
                    break;

                case "3":
                    Console.Write("Enter message to brute force decrypt: ");
                    message = Console.ReadLine();
                    decryptor.BruteForceDecrypt(message);
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
