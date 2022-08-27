﻿using AgentGL.Syntax.Lexeme;

namespace AgentGL.Syntax.Expression.Nodes.LiteralNodes
{
    public class StringLiteralNode : LiteralNode<string>
    {
        public StringLiteralNode(string value) : base(Classifier.StringLiteral)
        {
            Value = value;
        }

        public StringLiteralNode(Token token) : base(Classifier.StringLiteral)
        {
            Value = token.Value;
        }
    }
}
