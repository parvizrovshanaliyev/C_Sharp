using System;
using System.Linq;

namespace Week6.Tasks
{
    public static class ConsoleDataFormatter
    {
        private const int TableWidth = 80;

        public static void PrintSeparatorLine()
        {
            Console.WriteLine(new string('-', TableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            // (80 - 4)/4= 19
            int columnWidth = (TableWidth - columns.Length) / columns.Length;

            const string seed = "|";

            string row = columns.Aggregate(seed, (separator, columnText) =>
            {
                string centerAlignedText = separator + GetCenterAlignedText(columnText, columnWidth) + seed;
                if (columnText.Length > columnWidth)
                {

                }
                return centerAlignedText;
            });

            Console.WriteLine(row);
        }

        private static string GetCenterAlignedText(string columnText, int columnWidth)
        {
            columnText = columnText.Length > columnWidth
                ? columnText.Substring(0, columnWidth - 3) + "..."
                : columnText;

            //  text: id length=2
            //  (columnWidth-((columnWidth - columnText.Length) / 2) = 19-(19-2)/2=10.5
            string text = string.IsNullOrEmpty(columnText)
                ? new string(' ', columnWidth)
                : columnText.PadRight(columnWidth - ((columnWidth - columnText.Length) / 2)).PadLeft(columnWidth);
            return text;
        }
    }
}