namespace CSharpBasics
{
    class FileIO
    {
        public void LearnFileReading()
        {
            string file_path = "myfile.txt";
            if(File.Exists(file_path))
            {
                var content = File.ReadAllLines(file_path);
                foreach(var stmts in content)
                {
                    Console.WriteLine(stmts);
                }
            }
        }
        public void LearnFileWriting()
        {
            string file_path = "newfile.txt";
            File.WriteAllText(file_path,"Hello honey bunny.Poko Poko"); 
        }
        public void LearnFileInfo()
        {
            string filePath = "newfile.txt";
            FileInfo fileInfo= new FileInfo(filePath); 
            var size = fileInfo.Length;
            Console.WriteLine(fileInfo.Length);
            var createDate = fileInfo.CreationTime;
            Console.WriteLine(createDate.ToString());
        }
        public void LearnDirectory()
        {
            string folderPath = "MBM";
            Directory.CreateDirectory(folderPath);
            Console.Write("Do you want to delethe the folder named MBM ?(Y/N): ");
            string ans = Console.ReadLine();
            if(ans.ToUpper() == "Y")
            {
                Directory.Delete(folderPath);
                Console.WriteLine("Folder deleted sucessfully");
            }
            else
               Console.WriteLine("Folder not deleted");
            // Directory.Delete(folderPath);

            var drive = Directory.GetLogicalDrives();
            foreach(string s in drive){
                Console.WriteLine(s);
            }
        }
    }
}