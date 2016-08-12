using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeTest.TestServices
{
    public static class TestLogger
    {
        public static void log(string className, string[] inputs, string[] outputs)
        {
            TextWriter writer = null;
            try
            {
                writer = getLogWriter(className);

                writer.WriteLine(className);
                writer.WriteLine("Inputs:");
                write(writer, inputs);
                writer.WriteLine("Outputs:");
                write(writer, outputs);
                writer.WriteLine("\n");
            }
            catch (Exception e)
            {                
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

        }

        private static void write(TextWriter writer, string[] toWrite)
        {
            for(int i = 0; i < toWrite.Length; i++)
            {
                writer.WriteLine(toWrite[i]);
            }
        }

        private static TextWriter getLogWriter(string className)
        {
            string logDirectory = Environment.CurrentDirectory + "\\Logs";
            Directory.CreateDirectory(logDirectory);

            string logPath = logDirectory + "\\" + className + ".txt";

            TextWriter writer;
            if (!File.Exists(logPath))
            {
                var stream = File.Create(logPath);
                stream.Close();
            }
            writer = new StreamWriter(logPath, true);

            return writer;
        }
    }
}
