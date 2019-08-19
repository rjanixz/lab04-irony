using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    abstract class Value
    {

        public abstract string printTree(int id);

        public abstract string printMirrorTree(int id);

        public abstract Boolean isDegenerated();

        public abstract Boolean seRepite(int root);
    }
}
