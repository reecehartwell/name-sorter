public class Data {

    public List<string> ReadNames(string fileName){
        String filePath = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\" + fileName);

        // Print the filepath
        Console.WriteLine("File Path is: " + filePath);

        return System.IO.File.ReadAllLines(filePath).ToList();
    }

}