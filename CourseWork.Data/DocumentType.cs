using System;
using System.Linq;

namespace CourseWork.Data
{
    public class DocumentType : Base<DocumentType>
    {
        public string ByOrigin { get; set; }
        public string ByTermOfImplementation { get; set; }
        public string ByDegreeOfPublicity { get; set; }
        public string ByName { get; set; }

        private Guid _documentId;
        public Document Document
        {
            get => Document.Items[_documentId];
            set => _documentId = value.Id;
        }

        /// <summary>
        /// Повертає рядок з типом документа.
        /// </summary>
        public override string ToString()
        {
            string[] tempArr = {ByName, ByTermOfImplementation, ByOrigin, ByDegreeOfPublicity};
            string temp = "";
            tempArr = tempArr.Where(type => type != "").ToArray();
            foreach (var type in tempArr)
            {
                temp += type + ", ";
            }
            return temp.Remove(temp.Length - 2);
        }

        /// <summary>
        /// Повертає рядок з типом документа (не відредагований).
        /// </summary>
        public string ToNotFormatedString()
        {
            string[] tempArr = {ByName, ByTermOfImplementation, ByOrigin, ByDegreeOfPublicity};
            string temp = "";
            foreach (var type in tempArr)
            {
                temp += type + ",";
            }
            return temp.Remove(temp.Length - 1);
        }
    }
}
