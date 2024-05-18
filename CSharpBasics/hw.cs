using System;
using System.Collections.Generic;
namespace CSharpBasics
{
    class Homework
    {
        public void Homeworksolution()
        {
            int count;
            Directory.CreateDirectory("Nepal");
            for(count =1;count<=10;count++ )
            {
                string sub_folder_name = "Nepal//Subfolder"+count;
                Directory.CreateDirectory(sub_folder_name);
                string file_name = sub_folder_name + "//Test.txt";
                File.WriteAllText(file_name,"Subfolder"+count);
            }
        }
    }
}