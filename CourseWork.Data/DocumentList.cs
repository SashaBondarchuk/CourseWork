using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Data
{
    public class DocumentList : Base<DocumentList>
    {
        public string Name { get; set; }
        public User User { get; set; }
        public List<Document> Documents => Document.Items.Values.Where(doc => doc.DocumentList == this).ToList();

        /// <summary>
        /// Базовий конструктор. Викликається при створенні списка документів з програми.
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Name"></param>
        public DocumentList(User User, string Name)
        {
            this.Name = Name;
            this.User = User;
            this.User.ListCount++;
        }

        /// <summary>
        /// Конструктор, який викликається при перенесенні даних з файла documentLists.txt в колекцію Items.
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Name"></param>
        /// <param name="Id"></param>
        public DocumentList(User User, string Name, Guid Id) : base(Id)
        {
            this.Name = Name;
            this.User = User;
            this.User.ListCount++;
        }

        public override string ToString() => Name;

        /// <summary>
        /// Повертає рядок з усіма параментрами списка документів.
        /// </summary>
        public string DocumentListToFullString()
        {
            return $"{Name} {User.Id} {User} {Id}";
        }

        private static readonly string pathToDocumentLists = @"..\..\..\documentLists.txt";

        /// <summary>
        /// Заповнює колекцію DocumentList.Items з текстового файла.
        /// </summary>
        public static void FillDocumentLists()
        {
            string[] documentListsContainer = File.ReadAllLines(pathToDocumentLists);
            for (int i = 1; i < documentListsContainer.Length; i++)
            {
                if (string.IsNullOrEmpty(documentListsContainer[i]))
                    continue;

                string[] documentListsFields = documentListsContainer[i].Split(' ');
                foreach (var user in User.AllUsers())
                {
                    if(user.Id == Guid.Parse(documentListsFields[1]))
                    {
                        new DocumentList(Name: documentListsFields[0], User: user, Id: Guid.Parse(documentListsFields[3]));
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Повністю оновлює файл зі списками документів.
        /// </summary>
        public static void RefreshDocumentListsTxt()
        {
            File.Delete(pathToDocumentLists);
            File.AppendAllText(pathToDocumentLists, "Назва списку | Id Користувача | Нікнейм | Id\n");
            foreach (var docList in AllDocumentLists())
            {
                File.AppendAllText(pathToDocumentLists, docList.DocumentListToFullString() + "\n");
            }
        }

        /// <summary>
        /// Повертає список всіх списків документів.
        /// </summary>
        public static List<DocumentList> AllDocumentLists()
        {
            return Items.Values.ToList();
        }

        /// <summary>
        /// Повертає список списків документів, у яких кількість документів більше трьох.
        /// </summary>
        public static List<DocumentList> DocumentListsWithDocumentCount()
        {
            return Items.Values.Where(docList => docList.Documents.Count > 3).ToList();
        }
    }
}
