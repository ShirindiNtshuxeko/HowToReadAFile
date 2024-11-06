namespace HowToReadAFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string TextPath = Path.Combine(DocPath, "New.txt");

            //Check if file exist
            if (File.Exists(TextPath))
            {
                //Read and display the data from the file
                using (StreamReader sr = new StreamReader(TextPath))
                {
                    string fileContent = sr.ReadToEnd();
                    Console.WriteLine("Contents of text file new");
                    Console.WriteLine(fileContent);
                }
            }
            else 
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
