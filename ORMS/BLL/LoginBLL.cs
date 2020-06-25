using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ORMS.BLL
{
    // validate all the input and MD5
    class LoginBLL
    {
        public bool idValidator(string text)
        {
            return Regex.Match(text, "^[\\d]{1,6}$").Success;
        }

        public bool nameValidator(string text)
        {
            return Regex.Match(text, "^[A-Z]{1}[a-z]{1,19}$").Success;
        }

        public bool phoneValidator(string text)
        {
            return Regex.Match(text, "^[\\d]{8,15}$").Success;
        }

        public bool passwordValidator(string text)
        {
            return Regex.Match(text, "^[\\dA-Za-z(!@#$%&)]{6,22}$").Success;
        }

        public bool confirmPasswordValidator(string text1, string text2)
        {
            return text1.Equals(text2);
        }

        public bool addressValidator(string text)
        {
            return Regex.Match(text, "^[\\dA-Za-z(,.)]{1,15}$").Success;
        }

        public bool dobValidator(string text)
        {
            return Regex.Match(text, "^[\\d]{2}/[\\d]{2}/[\\d]{4}$").Success;
        }

        public bool emailValidator(string text)
        {
            return Regex.Match(text, "^[\\dA-Za-z(!@#$%&.)]{4,22}$").Success;
        }

        public bool confirmUserTypeValidator(string text)
        {
            return (text.Equals("HR") || text.Equals("Attendant")
                || text.Equals("Assistant") || text.Equals("Manager"));
        }

        public bool confirmWorkTypeValidator(string text)
        {
            return (text.Equals("Full time") || text.Equals("Part time"));
        }

        //public int dateCalculator(DateTime date)
        //{
        //    return (date - DateTime.Now.Date).Days;
        //}

        public string GetMd5Hash(string input)
        {
            byte[] data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
