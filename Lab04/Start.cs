using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Start
    {
        int root;
        Children children;

        public Start(int root, Children children)
        {
            this.root = root;
            this.children = children;
        }


        public String printTree()
        {
            int rootId = Constants.nextId();
            String rootNode = "\tnode" + rootId + "[label = \"" + root + "\"];\n";

            String dot = "digraph g{\n";
            dot += rootNode;
            dot += children.printTree(rootId);
            dot += "}";

            return dot;
        }

        public String printMirrorTree()
        {
            int rootId = Constants.nextId();
            String rootNode = "\tnode" + rootId + "[label = \"" + root + "\"];\n";

            String dot = "digraph g{\n";
            dot += rootNode;
            dot += children.printMirrorTree(rootId);
            dot += "}";

            return dot;
        }

        public Boolean isDegenerated()
        {
            return children.isDegenerated();
        }

        public Boolean seReipte()
        {
            return children.seRepite(root);
        }
    }
}
