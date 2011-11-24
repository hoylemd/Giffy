using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Giffy
{
    class Document
    {
        int length;
        byte[] rawBytes;

        public Document(byte[] bytes)
        {
            // Save the bytes
            this.rawBytes = bytes;
            this.length = bytes.GetLength(0);
        }

        public char[] getChars()
        {
            int i;
            char[] charArray = new char[length];
            
            for(i = 0; i < length; i++)
                charArray[i] = (char)rawBytes[i];

            return charArray;
        }
    }
}
