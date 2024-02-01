using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Collection.Exceptions
{
    internal class BookAlreadyExist:Exception
    {
        public BookAlreadyExist(string message) : base(message)
        {
                
        }
    }
}
