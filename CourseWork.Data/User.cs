using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseWork.Data
{
    public class User : Base<User>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string Type { get; protected set; }
        public int AllowedCountOfLists { get; protected set; }
        public int ListCount { get; set; }
        public List<DocumentList> DocumentLists => DocumentList.Items.Values.Where(item => item.User == this).ToList();

        /// <summary>
        /// Базовий конструктор. Викликається при користувача з програми.
        /// </summary>
        public User()
        {
            Type = "Звичайний";
            AllowedCountOfLists = 10;
        }

        /// <summary>
        /// Конструктор, який викликається при перенесенні даних з файла users.txt в колекцію Items.
        /// </summary>
        /// <param name="Id"></param>
        public User(Guid Id) : base(Id)
        {
            Type = "Звичайний";
            AllowedCountOfLists = 10;
        }

        public override string ToString() => UserName;

        /// <summary>
        /// Повертає рядок з усіма параметрами користувача.
        /// </summary>
        protected string UserToFullString()
        {
            return $"{FirstName} {LastName} {UserName} {BirthdayDate.ToShortDateString()} {Type} {ListCount} {Id}";
        }

        private static readonly string pathToUsers = @"..\..\..\users.txt";

        /// <summary>
        /// Заповнює колекцію User.Items з текстового файла.
        /// </summary>
        public static void FillUsers()
        {
            string[] userContainer = File.ReadAllLines(pathToUsers);
            for (int i = 1; i < userContainer.Length; i++)
            {
                if (string.IsNullOrEmpty(userContainer[i]))
                    continue;

                string[] userFields = userContainer[i].Split(' ');
                if (userFields[4] == "Звичайний")
                {
                    new User(Guid.Parse(userFields[6]))
                    {
                        FirstName = userFields[0],
                        LastName = userFields[1],
                        UserName = userFields[2],
                        BirthdayDate = DateTime.ParseExact(userFields[3], "dd/MM/yyyy", null),
                        ListCount = 0
                    };
                }
                else
                {
                    new PremiumUser(Guid.Parse(userFields[6]))
                    {
                        FirstName = userFields[0],
                        LastName = userFields[1],
                        UserName = userFields[2],
                        BirthdayDate = DateTime.ParseExact(userFields[3], "dd/MM/yyyy", null),
                        ListCount = 0
                    };
                }
            }
        }

        /// <summary>
        /// Повністю оновлює файл з користувачами.
        /// </summary>
        public static void RefreshUsersTxt()
        {
            File.Delete(pathToUsers);
            File.AppendAllText(pathToUsers, "Ім'я | Прізвище | Нікнейм | Дата Народження | Тип | Кількість списків | Id\n");
            foreach (var user in AllUsers())
            {
                File.AppendAllText(pathToUsers, user.UserToFullString() + "\n");
            }
        }

        /// <summary>
        /// Повертає список користувачів, які мають 5 або більше списків документів.
        /// </summary>
        public static List<User> UsersWithListCount()
        {
            return Items.Values.Where(user => user.DocumentLists.Count >= 5).ToList();
        }

        /// <summary>
        /// Повертає список повнолітніх користувачів.
        /// </summary>
        public static List<User> AdultUsers()
        {
            return Items.Values.Where(user => (DateTime.Now - user.BirthdayDate).TotalDays >= 18*365).ToList();
        }

        /// <summary>
        /// Повертає список всіх користувачів без документів у списках.
        /// </summary>
        public static List<User> UserWithoutDocuments()
        {
            return Items.Values.Where(user => user.DocumentLists.Where(docList => docList.Documents.Count == 0).ToList().Count() == user.DocumentLists.Count).ToList();
        }

        /// <summary>
        /// Повертає список всіх користувачів з типом "Звичайний".
        /// </summary>
        public static List<User> OrdianryUsers()
        {
            return Items.Values.Where(user => user.Type == "Звичайний").ToList();
        }

        /// <summary>
        /// Повертає список всіх користувачів.
        /// </summary>
        public static List<User> AllUsers()
        {
            return Items.Values.ToList();
        }
    }
}
