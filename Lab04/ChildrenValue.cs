using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class ChildrenValue : Value
    {
        int root;
        Children children;

        public ChildrenValue(int root, Children children)
        {
            this.root = root;
            this.children = children;
        }

        public ChildrenValue(int root)
        {
            this.root = root;
            this.children = null;
        }

        override public string printTree(int parentId)
        {
            String dot = "";

            int rootId = Constants.nextId();
            String numberNode = "\tnode" + rootId + "[label = \"" + root + "\"];\n";

            dot += numberNode;
            dot += "\tnode" + parentId + " -> node" + rootId + ";\n";
            dot += children.printTree(rootId);

            return dot;
        }

        override public string printMirrorTree(int parentId)
        {
            String dot = "";

            int rootId = Constants.nextId();
            String numberNode = "\tnode" + rootId + "[label = \"" + root + "\"];\n";

            dot += numberNode;
            dot += "\tnode" + parentId + " -> node" + rootId + ";\n";
            dot += children.printMirrorTree(rootId);

            return dot;
        }

        public override bool isDegenerated()
        {
            return children.isDegenerated();
        }

        override public Boolean seRepite(int root2)
        {
            return root2 == root || children.seRepite(root);
        }
    }
}
