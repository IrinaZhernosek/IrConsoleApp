using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrynaZharnasek.Lecture8.Task2
{
    internal class PersonalDocuments
    {
        public string docName { get; set; }
        private string docId;
        public string DocId
        {
            set
            {
                if (value.Length != 11) throw new DocIdException("Personal ID number should contain 11 digits");

                else docId = value;
            }
            get { return docId; }
        }
        public PersonalDocuments(string DocName, string DocId)
        {
            docName = DocName;
            this.DocId = DocId;
        }

    }
}
