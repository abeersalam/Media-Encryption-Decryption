using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

/*************************************************************************************************************** 
 * Version 0.1
 * NOTE: Add these references
 *  1) Project -> Add Reference -> .NET -> Microsoft.Office.Interop.Word (version 14)
 *  2) Project -> Add Reference -> .NET -> System.Drawing (version 4)
 ***************************************************************************************************************/

namespace Cryptik
{
    internal class Program
    {
        private static void ProgMain(string[] args)
        {
            ////////////////////////////////////////////////////////////////
            /// Jarid command line arguments ///////////////////////////////
            ////////////////////////////////////////////////////////////////
            int encryptionType = 3;
            bool encrypt = true;
            string input_filename = "C:/Users/aalirehman/Desktop/test2.png";
            string output_file = "C:/Users/aalirehman/Desktop/test3.png";
            string key = "Thisis my keyasdfasfakfasdfjdskfjsd;kfjabc123";
            ////////////////////////////////////////////////////////////////


            /****************************************
             * DO NOT TOUCH
             ****************************************/

            if (File.Exists(input_filename))
            {
                string[] file_ext = input_filename.Split('.');
                file_ext[1] = file_ext[1].ToLower();

                CSFile test;
                if (file_ext[1] == "doc" || file_ext[1] == "docx" || file_ext[1] == "txt" || file_ext[1] == "xls" ||
                    file_ext[1] == "xlsx")
                {
                    // Documents
                    test = new CSDocument();

                    test.import(input_filename);
                    test.setKey(key);

                    if (encrypt == true)
                    {
                        test.encrypt(encryptionType);
                    }
                    else
                    {
                        test.decrypt(encryptionType);
                    }

                    test.export(output_file);                    
                }
                else if (file_ext[1] == "png" || file_ext[1] == "bmp" || file_ext[1] == "jpg" || file_ext[1] == "jpeg")
                {
                    // Images
                    test = new CSImage();

                    test.import(input_filename);
                    test.setKey(key);

                    if (encrypt == true)
                    {
                        test.encrypt(encryptionType);
                    }
                    else
                    {
                        test.decrypt(encryptionType);
                    }

                    test.export(output_file);
                }
                else if (file_ext[1] == "mp4")
                {
                    // Videos
                }
                else
                {

                }
            }
        }
    }
}