using System.IO;
using System.Text;

namespace GradeScores.Tests.MockObjects
{
    class TestStudentScoreWriter : StudentScoreWriter
    {
        public override StreamWriter CreateStreamWriter(string strFileName)
        {
            mStream = new MemoryStream();
            return new StreamWriter(mStream);
        }

        public string GetOutput()
        {
            return Encoding.UTF8.GetString(mStream.ToArray());
        }

        private MemoryStream mStream;
    }
}
