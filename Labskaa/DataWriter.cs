using Labskaa.WorkWithSchema;

namespace Labskaa
{
    class DataWriter
    {
        public static void AppendDataToCsv(string path, string data)
        {
            File.AppendAllText(path, "\n" + data);
        }

        public static void CreateCsvFile(string path, string columns)
        {
            File.WriteAllText(path, columns);
        }

        public static string[] GetDataFromCsv(string filePath, string schemaPath)
        {
            var lines = File.ReadAllLines(filePath);
            var schema = JSONSchemaValidator.GetSchema(schemaPath);

            try
            {
                if (JSONSchemaValidator.IsValidToSchema(lines, schema))
                {
                    lines = lines.Skip(1).ToArray();
                    return lines;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The program will finished. Check your data and correct it, and try again later.");
            }
            return null;
        }
    }
}