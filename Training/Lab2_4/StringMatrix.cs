using System;

namespace Hello_Class_stud
{
    abstract class StringMatrix
    {
        public const int Size1 = 2, Size2 = Alphabet.Size;
        private string[,] strMatrix = new string[Size1, Size2];

        public string this[int x, int y]
        {
            get { return strMatrix[x, y]; }
            set { strMatrix[x, y] = value; }
        }

        public void WriteMatrix()
        {
            Console.WriteLine();
            for (int i = 0; i < Size2; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < Size1; j++)
                {
                    Console.Write(" " + this[j, i]);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }

        public string StrClmn()
        {
            string clmn = null;
            for (int j = 0; j < Size2; j++)
            {
                clmn += this[1, j];
            }
            return clmn;
        }

        public static bool operator >=(StringMatrix tbl1, StringMatrix tbl2)
        {
            bool resStrMatrix = String.Compare(tbl1.StrClmn(), tbl2.StrClmn()) >= 0 ? true : false;
            return resStrMatrix;
        }

        public static bool operator <=(StringMatrix tbl1, StringMatrix tbl2)
        {
            bool resStrMatrix = String.Compare(tbl1.StrClmn(), tbl2.StrClmn()) <= 0 ? true : false;
            return resStrMatrix;
        }

        public static bool operator >(StringMatrix tbl1, StringMatrix tbl2)
        {
            bool resStrMatrix = String.Compare(tbl1.StrClmn(), tbl2.StrClmn()) > 0 ? true : false;
            return resStrMatrix;
        }

        public static bool operator <(StringMatrix tbl1, StringMatrix tbl2)
        {
            bool resStrMatrix = String.Compare(tbl1.StrClmn(), tbl2.StrClmn()) < 0 ? true : false;
            return resStrMatrix;
        }

        public override bool Equals(object obj)
        {
            StringMatrix strob = (StringMatrix) obj;
            return String.Compare(strob.StrClmn(), this.StrClmn()) == 0 ? true : false;
        }

        public override int GetHashCode()
        {
            return this.StrClmn().GetHashCode();
        }
    }
}