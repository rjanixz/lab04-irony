using Irony.Ast;
using Irony.Parsing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class BinaryTreeGrammar : Grammar
    {
        public BinaryTreeGrammar() : base(false) {

            var number = new NumberLiteral("Number");
            var comma = ToTerm(",");
            var open_par = ToTerm("(");
            var closed_par = ToTerm(")");

            var start = new NonTerminal("Start");
            var children = new NonTerminal("Children");
            var value = new NonTerminal("Value");

            start.Rule = number + children;

            children.Rule = open_par + value + comma + value + closed_par
                            | open_par + value + closed_par;

            value.Rule = number
                            | number + children;


            RegisterBracePair("(", ")");
            MarkPunctuation(",", "(", ")");

            this.Root = start;
        }
    }
}
