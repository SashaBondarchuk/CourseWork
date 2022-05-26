using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork.Data
{
    public class PremiumUser : User
    {
        /// <summary>
        /// Базовий конструктор. Викликається при створенні пруміум користувача з програми.
        /// </summary>
        public PremiumUser()
        {
            Type = "Premium";
            AllowedCountOfLists = int.MaxValue;
        }

        /// <summary>
        /// Конструктор, який викликається при перенесенні даних з файла users.txt в колекцію Items.
        /// </summary>
        /// <param name="Id"></param>
        public PremiumUser(Guid Id) : base(Id)
        {
            Type = "Premium";
            AllowedCountOfLists = int.MaxValue;
        }

        /// <summary>
        /// Повертає список всіх користувачів з типом "Premium".
        /// </summary>
        public static List<User> PremiumUsers()
        {
            return Items.Values.Where(user => user.Type == "Premium").ToList();
        }
    }
}
