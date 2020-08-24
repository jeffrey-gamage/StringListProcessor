using System;
using System.Collections.Generic;
using System.Text;

namespace StringListProcessor
{
    class UrtheCastOrderedString: IComparable
    {
        public string _string;

        public UrtheCastOrderedString(string newString)
        {
            this._string = newString;
        }

        public int CompareTo(object obj)
        {
            if(obj.GetType()!=typeof(UrtheCastOrderedString))
            {
                return 0;
            }
            if(((UrtheCastOrderedString)obj)._string.Length>_string.Length)
            {
                return 1;
            }
            if(((UrtheCastOrderedString)obj)._string.Length < _string.Length)
            {
                return -1;
            }
            for(int i=0;i<_string.Length;i++)
            {
                if(((UrtheCastOrderedString)obj)._string[i]!=_string[i])
                {
                    return ((UrtheCastOrderedString)obj)._string[i] - _string[i];
                }
            }
            return 0;
        }
    }
}
