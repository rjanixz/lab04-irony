using Irony.Parsing;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Evaluator
    {
        public Start evaluate(String input)
        {
            var language = new LanguageData(new BinaryTreeGrammar());
            var parser = new Parser(language);
            var syntaxTree = parser.Parse(input);   // evaluó la entrada

            if (syntaxTree.HasErrors())
            {
                Console.WriteLine("ERROR:");
                Console.WriteLine(syntaxTree.ParserMessages[0].Message);
                return null;
            }
            else
            {
                return evaluateStart(syntaxTree.Root);
            }
        }

        private Start evaluateStart(ParseTreeNode start)
        {
            int root = Int16.Parse(start.ChildNodes[0].Token.Text);
            Children children = evaluateChildren(start.ChildNodes[1]);

            return new Start(root, children);
        }

        private Children evaluateChildren(ParseTreeNode children)
        {
            Value leftValue = evaluateValue(children.ChildNodes[0]);
            Value rightValue = null;

            if (children.ChildNodes.Count == 2)
            {
                rightValue = evaluateValue(children.ChildNodes[1]);
            }

            return new Children(leftValue, rightValue);
        }

        private Value evaluateValue(ParseTreeNode value)
        {

            int root = Int16.Parse(value.ChildNodes[0].Token.Text);

            if (value.ChildNodes.Count == 2)
            {
                Children children = evaluateChildren(value.ChildNodes[1]);
                return new ChildrenValue(root, children);
            }
            else
            {
                return new SingleValue(root);
            }
        }
    }
}
