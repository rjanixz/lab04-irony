using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class SingleValue : Value
    {
        int root;

        public SingleValue(int root)
        {
            this.root = root;
        }

        override public string printTree(int parentId)
        {
            String dot = "";

            int numberId = Constants.nextId();
            String numberNode = "\tnode" + numberId + "[label = \"" + root + "\"];\n";

            dot += numberNode;
            dot += "\tnode" + parentId + " -> node" + numberId + ";\n";

            return dot;
        }

        override public string printMirrorTree(int parentId)
        {
            String dot = "";

            int numberId = Constants.nextId();
            String numberNode = "\tnode" + numberId + "[label = \"" + root + "\"];\n";

            dot += numberNode;
            dot += "\tnode" + parentId + " -> node" + numberId + ";\n";

            return dot;
        }

        override public Boolean isDegenerated()
        {
            return true;
        }

        override public bool seRepite(int root2)
        {
            return root2 == root;
        }
    }
}
