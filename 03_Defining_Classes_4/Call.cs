using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_4
{
    public class Call
    {
        public int CallId { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string Message { get; set; }

        public Call()
        {
            
        }

        public Call(int callId, DateTime entryDateTime, string message)
        {
            CallId = callId;
            EntryDateTime = entryDateTime;
            Message = message;
        }
    }
}
