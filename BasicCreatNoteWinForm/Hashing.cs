using System.Security.Cryptography;
using System.Text;

namespace BasicCreatNoteWinForm
{
    static class Hashing
    {
        public static string HashSha128(string userInput)
        {
            using(var sha128 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(userInput);
                byte[] hash = sha128.ComputeHash(inputBytes);

                return Convert.ToBase64String(hash);
            }
        }  
    }
}
