using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Giffy
{
    // Function to hold a 
    public class hexByte
    {
        // the byte data
        byte datum;

        // function to get the character coresponding to ythe least significant digit of an int
        public static char LSDToChar(int i)
        {
            // grab the lsd, man
            int lsd = i % 10;

            // add the lsd to the char for 0 and return it.
            return (char)(lsd + (int)'0');
        }

        // function to convert an int into a hexit.
        // return 0 for values too high (>15)
        public static char intToHexChar(int i)
        {
            int midVal;

            // check for invalid input
            if (i > 15)
                return (char)0;

            // use LSDToChar for numeric hexits.
            if (i < 10)
                return LSDToChar(i);

            // calculate which hexit to return
            midVal = i - 10;

            // add that to the char val for 'A' (10 in hex)
            return (char)(midVal + (int)'A');
        }

        // Static function to convert a byte into 2 chars representing the byte's hex value
        public static char[] byteToHex(byte b)
        {
            int prefix;
            int suffix;
            char[] charArray = new char[2];

            // calculate the prefix value
            prefix = 0;
            if (b > 15)
                prefix = b / 16;

            // calculate the suffix value
            suffix = b % 16;

            //MessageBox.Show(prefix.ToString() + " " + suffix.ToString());

            // convert these values into chars
            charArray[0] = intToHexChar(prefix);
            charArray[1] = intToHexChar(suffix);

            // return the chars
            return charArray;
        }

        // constructor
        public hexByte(byte b)
        {
            this.datum = b;
        }

        // function to output it as a char array of 2 hexits
        public char[] toCharArray()
        {
            return byteToHex(datum);
        }

        // function to output it as a string
        public string ToString()
        {
            return new string(this.toCharArray());
        }
    }
}
