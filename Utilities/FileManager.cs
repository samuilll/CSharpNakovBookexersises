using System;
using System.IO;
using System.Linq;
using Utilities.Exceptions;

namespace Utilities
{
  public  class FileManager
    {
      public  string ReadAllText(string path)
        {
            while (true)
            {
                try
                {
                    string content = File.ReadAllText(path);

                    return content;
                }
                catch (ArgumentException ex)
                {
                    throw new ArgumentException("Please enter a non-empty path", ex);
                }
                catch (FileNotFoundException ex)
                {
                   throw new FileNotFoundException("There is no file with the given path",ex);
                }
                catch (NotSupportedException ex)
                {
                    throw new NotSupportedException("The given path has invalid format",ex);
                }
                catch (UnauthorizedAccessException ex)
                {
                    throw new UnauthorizedAccessException("Yor are not authorized to use this file",ex);
                }
            }
        }

        public string[] ReadAllLines(string path)
        {
            while (true)
            {
                try
                {
                    string[] content = File.ReadAllLines(path);

                    return content;
                }
                catch (ArgumentException ex)
                {
                    throw new ArgumentException("Please enter a non-empty path", ex);
                }
                catch (FileNotFoundException ex)
                {
                    throw new FileNotFoundException("There is no file with the given path", ex);
                }
                catch (NotSupportedException ex)
                {
                    throw new NotSupportedException("The given path has invalid format", ex);
                }
                catch (UnauthorizedAccessException ex)
                {
                    throw new UnauthorizedAccessException("Yor are not authorized to use this file", ex);
                }
            }
        }


        public void ValidateFile(string fileName,string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                int row = i + 1;
                string line = lines[i];

                if (!line.Any(ch => char.IsDigit(ch)))
                {
                    throw new FileParseException(fileName, row);
                }
            }
        }

        public void IsHtmlValidation(string fileName)
        {
            if (!fileName.EndsWith(".html"))       
            {
               throw new NotSupportedException("The file must be html"); 
            }
        }

        public void WriteAllText(string path,string content)
        {
            File.WriteAllText(path,content);
        }

        public void WriteAllLines(string path, string[] content)
        {
            File.WriteAllLines(path, content);
        }
    }
}
