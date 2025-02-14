string path = Directory.GetCurrentDirectory() + "/" + "FileCollection";
DirectoryInfo dirInfo = new DirectoryInfo(path);
const string filename = "result.txt";
if (!File.Exists(filename)){
    File.Create(filename);
}

if (dirInfo.Exists)
{
    List<string> thefiles = new List<string>(Directory.GetFiles(dirInfo.FullName));
    int excelCount = 0;
    int wordCount = 0;
    int pptCount = 0;
    long excelSize = 0;
    long wordSize = 0;
    long pptSize = 0;
    foreach (var file in thefiles)
    
    {
        FileInfo fileInfo = new FileInfo(file);
        
        if (fileInfo.Extension == ".docx"){
            wordCount++;
            wordSize += fileInfo.Length;
        }
        if (fileInfo.Extension == ".pptx"){
            pptCount++;
            pptSize += fileInfo.Length;
        }
        if (fileInfo.Extension == ".xlsx"){
            excelCount++;
            excelSize += fileInfo.Length;
        }
        
    }

    if (File.Exists(filename))
    {
        File.WriteAllText(filename, $"Total Files: {thefiles.Count}\n");
        File.AppendAllText(filename, $"Excel Count: {excelCount}\n");
        File.AppendAllText(filename, $"Word Count: {wordCount}\n");
        File.AppendAllText(filename, $"PPt Count: {pptCount}\n");
        File.AppendAllText(filename, "--------------\n");
        File.AppendAllText(filename, $"Total Size: {(excelSize + wordSize + pptSize):N0} bytes\n");
        File.AppendAllText(filename, $"Excel Size: {excelSize:N0} bytes\n");
        File.AppendAllText(filename, $"Word Size: {wordSize:N0} bytes\n");
        File.AppendAllText(filename, $"PPt Size: {pptSize:N0} bytes\n");
    }
}
else{
    Console.WriteLine("Does not exist");
}
