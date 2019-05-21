using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tokenizer;

namespace WPDText
{
    public static class WPD_TextParser
    {

        public static string Parse(string url)
        {
                TokenizedDocument doc = new TokenizedDocument(url);
                return UtilityMethods.ConvertTokensToString(doc.DocumentTokens, 0);         
        }




    }
}
