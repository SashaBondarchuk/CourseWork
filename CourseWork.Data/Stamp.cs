using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Data
{
    public class Stamp : Base<Stamp>
    {
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Базовий конструктор. Викликається при створенні унікальної відмітки з програми.
        /// </summary>
        public Stamp() { }

        /// <summary>
        /// Конструктор, який викликається при перенесенні даних з файла stamps.txt в колекцію Items.
        /// </summary>
        /// <param name="Id"></param>
        public Stamp(Guid Id) : base(Id) { }

        private Guid _documentId;
        public Document Document
        {
            get => Document.Items[_documentId];
            set => _documentId = value.Id;
        }

        public override string ToString()
        {
            return $"Дійсний до {ExpirationDate.ToShortDateString()}";
        }

        /// <summary>
        /// Повертає рядок з усіма параметрами унікальної відмітки.
        /// </summary>
        private string StampToFullString()
        {
            return $"{Document} {this} {Id} {Document.Id}";
        }

        private static readonly string pathToStamps = @"..\..\..\stamps.txt";

        /// <summary>
        /// Заповнює колекцію Stamp.Items з текстового файла.
        /// </summary>
        public static void FillStamps()
        {
            string[] stampsContainer = File.ReadAllLines(pathToStamps);
            for (int i = 1; i < stampsContainer.Length; i++)
            {
                if (string.IsNullOrEmpty(stampsContainer[i]))
                    continue;

                string[] stampFields = stampsContainer[i].Split(' ');
                foreach (var document in Document.AllDocuments())
                {
                    if (document.Id == Guid.Parse(stampFields[5]))
                    {
                        document.Stamp = new Stamp(Guid.Parse(stampFields[4]))
                        {
                            Document = document,
                            ExpirationDate = DateTime.ParseExact(stampFields[3], "dd/MM/yyyy", null)
                        };
                    }
                }
            }
        }

        /// <summary>
        /// Повністю оновлює файл з унікальними відмітками.
        /// </summary>
        public static void RefreshStampsTxt()
        {
            File.Delete(pathToStamps);
            File.AppendAllText(pathToStamps, "Назва документа | Термін дії відмітки | Id відмітки | Id документа\n");
            foreach (var document in AllStamps())
            {
                File.AppendAllText(pathToStamps, document.StampToFullString() + "\n");
            }
        }

        /// <summary>
        /// Повертає список всіх унікальних відміток.
        /// </summary>
        public static List<Stamp> AllStamps()
        {
            return Items.Values.ToList();
        }
    }
}
