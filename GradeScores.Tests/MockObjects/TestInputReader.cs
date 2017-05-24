using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeScores.Tests.MockObjects
{
    public class TestInputReader : InputFileReader<string>
    {
        public override void ReadLine(string strLine, List<string> output)
        {
            ReadCount++;
        }

        public int ReadCount { get; set; }
    }
}
