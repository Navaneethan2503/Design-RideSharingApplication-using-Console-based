using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.AbstractClassDemo
{
    public class MathsBooks : Book
    {
        public MathsBooks(int id, string title, string description, string author) : base(id, title, description, author)
        {
        }

        public Book GetBook()
        {
            return this;
        }
    }
}
