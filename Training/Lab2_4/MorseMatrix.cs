using System;

namespace Hello_Class_stud
{
    class MorseMatrix : StringMatrix, IMorseCrypt
    {
        public const int Size2 = Alphabet.Size;
        private int offsetKey = 0;

        public MorseMatrix(int offset = 0)
        {
            if (((offset >= 0) & (offset < Alphabet.Size)) == true)
                offsetKey = offset;
            else Console.WriteLine("MorseMatrix Offset error, initialization by default");

            fd(Alphabet.Dictionary_arr);
            sd();
        }

        public MorseMatrix(string[,] DictArr, int offset = 0)
        {
            if (((offset >= 0) & (offset < Alphabet.Size)) == true)
                offsetKey = offset;
            else Console.WriteLine("MorseMatrix. Offset error, initialization by default");

            if (DictArr == null)
                DictArr = Alphabet.Dictionary_arr;

            fd(DictArr);
            sd();
        }

        private void fd(string[,] DictArr)
        {
            for (int ii = 0; ii < Size1; ii++)
                for (int jj = 0; jj < Size2; jj++)
                    this[ii, jj] = DictArr[ii, jj];
        }

        private void sd()
        {
            int off = Size2 - offsetKey;
            for (int jj = 0; jj < off; jj++)
                this[1, jj] = this[1, jj + offsetKey];
            for (int jj = 0; jj < Size2; jj++)
                this[1, jj] = this[1, jj - off];
        }

        public static MorseMatrix operator +(MorseMatrix tbl1, MorseMatrix tbl2)
        {
            MorseMatrix resStrMatrix = new MorseMatrix();
            for (int i = 0; i < Size1; i++)
                for (int j = 0; j < Size2; j++)
                    resStrMatrix[i, j] = tbl1[i, j] + tbl2[i, j];
            return resStrMatrix;
        }

        public string crypt(string word)
        {
            string strRslt = null;
            foreach (char c in word.ToCharArray())
            {
                string rslt = "";
                for (int i = 0; i < Size2; i++)
                {
                    if (this[0, i] == c.ToString())
                    {
                        rslt = this[1, i];
                        strRslt += rslt;
                        break;
                    }
                }
            }

            return strRslt;
        }

        public string decrypt(string[] signal)
        {
            string strRslt = null;
            foreach (string c in signal)
            {
                string rslt = "";
                for (int i = 0; i < Size2; i++)
                {
                    if (this[1, i].Trim() == c.Trim())
                    {
                        rslt = this[0, i];
                        strRslt += rslt;
                    }
                }
            }
            return strRslt;
        }

        public void ResBeep(string rslt)
        {
            foreach (char c2 in rslt.ToCharArray())
            {
                if (c2 == '.')
                    Console.Beep(1000,250);
                else if (c2 == '-')
                {
                    Console.Beep(1000,750);
                }
            }
        }
    }
}