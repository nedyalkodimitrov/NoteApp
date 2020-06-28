using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class Type
    {
        public Type()
        {
            
        }
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Color { get; set; }
        public ICollection<Note> Notes{ get; set; }
    }
}
