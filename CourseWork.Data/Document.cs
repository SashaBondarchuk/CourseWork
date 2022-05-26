using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseWork.Data
{
    public class Document : Base<Document>
    {
        public string Name { get; set; } 
        public DateTime CreationTime { get; set; }

        private Guid _documentListId;
        public DocumentList DocumentList
        {
            get => DocumentList.Items[_documentListId];
            set => _documentListId = value.Id;
        }
        public Stamp Stamp { get; set; }
        public DocumentType DocType { get; set; }

        /// <summary>
        /// Базовий конструктор. Викликається при створенні документа з програми.
        /// </summary>
        public Document() => CreationTime = DateTime.Now; 

        /// <summary>
        /// Конструктор, який викликається при перенесенні даних з файла documents.txt в колекцію Items.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="CreationTime"></param>
        public Document(Guid Id, DateTime CreationTime) : base(Id) => this.CreationTime = CreationTime;

        public override string ToString() => Name;

        /// <summary>
        /// Повертає рядок з усіма параментрами документа.
        /// </summary>
        private string DocumentToFullString()
        {
            return $"{Name} {CreationTime.ToShortDateString()} {DocumentList.Id} {Stamp?.ToString() ?? "- - -"} {DocType.ToNotFormatedString()} {Id}";
        }

        private static readonly string pathToDocuments = @"..\..\..\documents.txt";

        /// <summary>
        /// Заповнює колекцію Document.Items з текстового файла.
        /// </summary>
        public static void FillDocuments()
        {
            string[] documentsContainer = File.ReadAllLines(pathToDocuments);
            for (int i = 1; i < documentsContainer.Length; i++)
            {
                if (string.IsNullOrEmpty(documentsContainer[i]))
                    continue;

                string[] documentFields = documentsContainer[i].Split(' ');
                foreach (var docList in DocumentList.AllDocumentLists())
                {
                    if (docList.Id == Guid.Parse(documentFields[2]))
                    {
                        string[] type = documentFields[6].Split(',');
                        new Document(Id: Guid.Parse(documentFields[7]), CreationTime: DateTime.ParseExact(documentFields[1], "dd/MM/yyyy", null))
                        {
                            Name = documentFields[0],
                            DocumentList = docList,
                            DocType = new DocumentType()
                            {
                                ByName = type[0],
                                ByTermOfImplementation = type[1],
                                ByOrigin = type[2],
                                ByDegreeOfPublicity = type[3]
                            }                   
                        };
                    }
                }
            }
        }

        /// <summary>
        /// Повністю оновлює файл з документами.
        /// </summary>
        public static void RefreshDocumentsTxt()
        {
            File.Delete(pathToDocuments);
            File.AppendAllText(pathToDocuments, "Назва документа | Дата створення | Id Списку | Унікальна відмітка | Тип | Id\n");
            foreach (var document in AllDocuments())
            {
                File.AppendAllText(pathToDocuments, document.DocumentToFullString() + "\n");
            }
        }

        /// <summary>
        /// Повертає список документів, у яких термін дії відмітки більше року.
        /// </summary>
        public static List<Document> LongTermDocuments()
        {
            return Items.Values.Where(document => (document.Stamp.ExpirationDate - DateTime.Now).TotalDays > 365).ToList();
        }

        /// <summary>
        /// Повертає список всіх документів.
        /// </summary>
        public static List<Document> AllDocuments()
        {
            return Items.Values.ToList();
        }

        /// <summary>
        /// Повертає кількість документів без унікальної відмітки.
        /// </summary>
        public static int DocumentsStampCount()
        {
            return AllDocuments().Where(document => document.Stamp == null).Count();
        }

        /// <summary>
        /// Повертає Id унікальної відмітки.
        /// </summary>
        /// <param name="document"></param>
        public Guid GetDocumentStampId(Document document)
        {
            return document.Stamp.Id;
        }
    }
}
