using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeScores
{
    abstract public class InputFileReader<T>
    {
        public void Read(string strFileName, List<T> output)
        {
            // Open file 
            if (!File.Exists(strFileName))
            {
                string strError = string.Format("An invalid input file has been specified: {0}", strFileName);
                throw new Exception(strError);
            }

            using (StreamReader file = new StreamReader(strFileName))
            {               
                // Read the file and display it line by line.
                string strLine;
                while ((strLine = file.ReadLine()) != null)
                {
                    ReadLine(strLine, output);
                }
            }
        }

        abstract public void ReadLine(string strLine, List<T> output);
    }
}
