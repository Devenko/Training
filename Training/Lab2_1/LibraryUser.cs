using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class LibraryUser
    {
        private string FirstName;
        private string LastName;
        private int Id;
        private int BookLimit;
        private int Phone;

        public int Phone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }

    }
}
