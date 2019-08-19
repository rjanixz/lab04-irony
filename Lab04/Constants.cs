using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Constants
    {
        public const String T_NUMBER = "T_NUMBER";
        public const String NT_START = "NT_START";
        public const String NT_CHILDREN = "NT_CHILDREN";
        public const String NT_VALUE = "NT_VALUE";


        private static int id = 0;
        public static int nextId()
        {
            return ++Constants.id;
        }
    }
}
