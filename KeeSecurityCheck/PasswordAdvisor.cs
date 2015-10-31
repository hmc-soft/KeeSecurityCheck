using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KeeSecurityCheck
{
    public enum PasswordScore
    {
        Blank = 0,
        VeryWeak = 1,
        Weak = 2,
        Medium = 3,
        Strong = 4,
        VeryStrong = 5
    }

    class PasswordAdvisor
    {
        public static PasswordScore CheckStrength(string password)
        {
            int score = 0;
            if(password.Length < 1)
            {
                return PasswordScore.Blank;
            }
            if(password.Length < 6)
            {
                return PasswordScore.VeryWeak;
            }

            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;

            if (
                (
                    Regex.Match(password, @"([a-z])").Success ||
                    Regex.Match(password, @"([A-Z])").Success
                ) &&
                Regex.Match(password, @"([0-9])").Success
                )
                score++;

            if (
                Regex.Match(password, @"([a-z])").Success &&
                Regex.Match(password, @"([A-Z])").Success
                )
                score++;

            if (
                Regex.Match(password, @"(\W)").Success
                )
                score++;

           
            return (PasswordScore)score;
        }
    }
}
