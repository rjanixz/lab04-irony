using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Children
    {
        Value leftValue;
        Value rightValue;

        public Children(Value leftValue, Value rightValue) {
            this.leftValue = leftValue;
            this.rightValue = rightValue;
        }

        public string printTree(int parentId)
        {
            String dot = "";

            String leftNode = leftValue.printTree(parentId);
            dot += leftNode;

            if (rightValue != null)
            {
                String rightNode = rightValue.printTree(parentId);
                dot += rightNode;
            }

            return dot;
        }

        public string printMirrorTree(int parentId)
        {
            String dot = "";

            if (rightValue != null)
            {
                String rightNode = rightValue.printMirrorTree(parentId);
                dot += rightNode;
            }


            String leftNode = leftValue.printMirrorTree(parentId);
            dot += leftNode;
            return dot;
        }

        public Boolean isDegenerated()
        {
            return rightValue != null ? false : leftValue.isDegenerated();
        }

        public Boolean seRepite(int root)
        {
            return leftValue.seRepite(root) || ( rightValue != null && rightValue.seRepite(root));
        }
    }
}
