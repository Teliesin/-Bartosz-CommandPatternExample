using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    public class Area
    {
        public string[][] Fields { get; set; }

        public Area()
        {
            Fields = GenerateEmptyArea10x10();
        }

        private string[][] GenerateEmptyArea10x10()
        {
            string[][] fields = new string[10][];

            for (int i = 0; i < 10; i++)
            {
                fields[i] = new string[10];

                for (int j = 0; j < 10; j++)
                {
                    fields[i][j] = string.Empty;
                }
            }

            return fields;
        }
    }
}
