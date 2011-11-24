using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Giffy
{
    class Document
    {
        int length;
        byte[] rawBytes;

        // constructor
        public Document(byte[] bytes)
        {
            // Save the bytes
            this.rawBytes = bytes;
            this.length = bytes.GetLength(0);
        }

        // function to get an array of chars based on the bytes
        public char[] getChars()
        {
            int i;
            // generate the array
            char[] charArray = new char[length];
            
            // transcribe the array.
            for(i = 0; i < length; i++)
                charArray[i] = (char)rawBytes[i];

            // return it.
            return charArray;
        }

        // function to get an array of chars represnting hex values per byte
        public char[] getHexChars()
        {
            int i;
            char[] hexits;

            // generate the array
            char[] charArray = new char[length * 2];


            // generate and transcribe the hexits
            for (i = 0; i < length; i++)
            {
                hexits = hexByte.byteToHex(rawBytes[i]);
                charArray[i * 2] = hexits[0];
                charArray[i * 2 + 1] = hexits[1];
            }

            // return it
            return charArray;               
        }
    }
}
