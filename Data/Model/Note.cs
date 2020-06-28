using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    class Note
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name  { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
        public Type Type{ get; set; }
        

    }
}
