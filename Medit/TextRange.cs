namespace Medit
{
    internal class TextRange
    {
        private object contentEnd;
        private object contentStart;

        public TextRange(object contentStart, object contentEnd)
        {
            this.contentStart = contentStart;
            this.contentEnd = contentEnd;
        }
    }
}