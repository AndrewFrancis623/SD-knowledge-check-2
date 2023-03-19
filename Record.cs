using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Record : Album
    {
        public Record()
        {

        }
        public Record(int recordId)
        {
            RecordId = recordId;
        }
        public int RecordId { get; private set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public string? Author { get; set; }
        public List<Record> Retrieve() 
        {
            return new List<Record>();
        }

    }
}

