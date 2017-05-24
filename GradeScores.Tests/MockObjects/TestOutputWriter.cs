using System.IO;
using System.Text;

namespace GradeScores.Tests.MockObjects
{
    public class TestOutputWriter : OutputFileWriter<string>
    {
        public override StreamWriter CreateStreamWriter(string strFileName)
        {
            mStream = new MemoryStream();
            return new StreamWriter(mStream);
        }

        public override string GetLine(string strLine)
        {
            WriteCount++;
            return strLine;
        }

        public int WriteCount { get; set; }

        public string GetOutput()
        {
            return Encoding.UTF8.GetString(mStream.ToArray());
        }

        private MemoryStream mStream;
    }
}
