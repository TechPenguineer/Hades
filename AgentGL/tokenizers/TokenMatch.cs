﻿using AgentGL.Parsing.Tokens;

namespace AgentGL.Parsing.Tokenizers
{
    internal class TokenMatch
    {
        public TokenType TokenType { get; set; }
        public string Value { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public int Precedence { get; set; }
    }
}
