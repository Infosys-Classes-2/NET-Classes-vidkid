// using System;
// using System.IO;
// public class FileIO
// {

//     public void Do()
//     {
//         string folderPath = @"F:\Test\test1.txt";
//         File.AppendAllText(folderPath, " This is another line");
//         Console.WriteLine("file created successfully");

//         FileInfo fi = new(folderPath);
//         var text = File.ReadAllText(folderPath);
//         Console.WriteLine("file details: ");
//         Console.WriteLine("Created Date" + fi.CreationTime);
//         Console.WriteLine("Last update Date" + fi.LastWriteTime);
//         Console.WriteLine("Size" + (float)fi.Length / 1024);
        


//         // Directory.CreateDirectory(@"F:\Test\Test1");
//     }
// }