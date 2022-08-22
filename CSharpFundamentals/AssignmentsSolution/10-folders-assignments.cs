using System.Collections.Generic;
using System.IO;

public class Folder
{
    public void Boom()
    {
        string rootFolderPath = @"F:\assignments";
        List<string> fileInfos = new List<string>();

        for (int i = 1; i <= 10; i++)
        {
            var folderPath = $"{rootFolderPath}/Folder{i}";
            Directory.CreateDirectory(folderPath);

            var filePath = $"{folderPath}/file{i}.txt";
            File.WriteAllText(filePath, "The Meta Information of this file");
            
            FileInfo fi = new(filePath);
            
            string info = $"Create Date: {fi.CreationTime} \n" +
                $"Last Modified Date: {fi.LastWriteTime} \n" +
                $"Size: {(float)fi.Length / 1024}kb \n " +
                $"File Type: {fi.Extension}";
            fileInfos.Add(info);

            File.AppendAllText(filePath, info);
        }
    }
}