using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    class Author
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Password { get; set; }
        public int Emeil { get; set; }
        public ICollection<Note> Notes  { get; set; }
    }
}
