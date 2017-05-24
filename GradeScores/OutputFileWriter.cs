using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeScores
{
    public abstract class OutputFileWriter<T>
    {
        public void OutputToFile(string strFileName, List<T> values)
        {
            // Create a file to write to.
            using (StreamWriter file = CreateStreamWriter(strFileName))
            {
                // Write each line
                foreach (T value in values)
                {
                    file.WriteLine(GetLine(value));
                }
            }
        }

        public virtual StreamWriter CreateStreamWriter(string strFileName)
        {
            return new StreamWriter(strFileName, false);
        }

        abstract public string GetLine(T value);
    }
}
