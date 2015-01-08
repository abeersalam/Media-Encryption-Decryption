using System;
using System.Text;
using System.IO;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;


namespace Cryptik
{
    internal class CSDocument : CSFile
    {
        /******************************************
         * Private Variables specific to this class
         ******************************************/
        private StringBuilder text;
        private string[,] cells;

        /******************************************
         * Public Methods
         *****************************************/

        /******************************************
         * CONSTRUCTOR
         *****************************************/
        public CSDocument()
        {
            text = null;
            filename = extension = key = filepath = null;
            cells = null;
        }

        /******************************************
         * READ FROM FILE HELPER METHOD
         *****************************************/
        public override void import(int encryptionType, string _filename)
        {
            string[] file_ext = _filename.Split('.');
            filename = file_ext[0];
            extension = file_ext[1];

            if (extension == "txt")
            {
                // .txt file
                ImportText(_filename);
            }
            else if (extension == "doc" || extension == "docx")
            {
                // word document
                ImportDocument(_filename);
            }
            else if (extension == "xls" || extension == "xlsx")
            {
                // Excel spreadsheets
                ImportExcel(_filename);
            }
        }

        /******************************************
          * ENCRYPTION HELPER METHOD
          *****************************************/
        public override void encrypt(int encryptionType)
        {

            if (encryptionType == 1)
            {
                if (extension == "xls" || extension == "xlsx")
                {
                    AaliExcelEncrypt();
                }
                else
                {
                    AaliEncrypt();
                }
            }
            else if (encryptionType == 2)
            {
                if (extension == "xls" || extension == "xlsx")
                {
                    KyleExcelEncrypt(); // Don't worry about this, I have taken care of it
                }
                else
                {
                    KyleEncrypt();
                }
            }
        }

        /******************************************
         * DECRYPTION HELPER METHOD
         *****************************************/
        public override void decrypt(int encryptionType)
        {
            if (encryptionType == 1)
            {
                if (extension == "xls" || extension == "xlsx")
                {
                    AaliExcelDecrypt();
                }
                else
                {
                    AaliDecrypt();
                }
            }
            else if (encryptionType == 2)
            {
                if (extension == "xls" || extension == "xlsx")
                {
                    KyleExcelDecrypt(); // Don't worry about this, I have taken care of it
                }
                else
                {
                    KyleDecrypt();
                }
            }
        }

        /******************************************
         * SAVE TO FILE HELPER METHOD
         *****************************************/
        public override void export(bool encrypt, int encryptionType, string filename)
        {
            if (extension == "txt")
            {
                // .txt file
                ExportText(filename);
            }
            else if (extension == "doc" || extension == "docx")
            {
                // word document
                ExportDocument(filename);
            }
            else if (extension == "xls" || extension == "xlsx")
            {
                // excel spreadsheets
                ExportExcel(filename);
            }
        }

        /******************************************
         * Initialize key for encryption/decryption
         *****************************************/
        public override void setKey(string _key)
        {
            key = _key;

            simpleDes._setKey(key);
        }

        /******************************************
         * PRIVATE METHODS
         *****************************************/

        /******************************************
         * IMPORT METHODS
         *****************************************/
        // txt documents
        private void ImportText(string _filename)
        {
            StreamReader sr = new StreamReader(_filename);
            string fileInput = sr.ReadToEnd();
            text = new StringBuilder(fileInput);
        }

        // word documents
        private void ImportDocument(string _filename)
        {
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            Document document = application.Documents.Open(_filename);
            string test = "";

            for (int i = 1; i <= document.Words.Count; i++)
            {
                test += document.Words[i].Text;
            }

            ((Microsoft.Office.Interop.Word._Document)document).Close();
            text = new StringBuilder(test);
            ((Microsoft.Office.Interop.Word._Application)application).Quit();
        }

        // excel documents
        private void ImportExcel(string _filename)
        {
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            Microsoft.Office.Interop.Excel.Application _excelApp = null;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            Microsoft.Office.Interop.Excel.Range excelRange = null;

            _excelApp = new Microsoft.Office.Interop.Excel.Application();
            _excelApp.Visible = false;

            workbook = _excelApp.Workbooks.Open(_filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                            Type.Missing, Type.Missing);


            worksheet = (Worksheet)workbook.Worksheets[1];

            excelRange = worksheet.UsedRange;

            object[,] valueArray = (object[,])excelRange.get_Value(XlRangeValueDataType.xlRangeValueDefault);

            cells = new string[worksheet.UsedRange.Rows.Count, worksheet.UsedRange.Columns.Count];

            for (int row = 1; row <= worksheet.UsedRange.Rows.Count; ++row)
            {
                for (int col = 1; col <= worksheet.UsedRange.Columns.Count; ++col)
                {
                    cells[row - 1, col - 1] = valueArray[row, col].ToString();
                }
            }

            workbook.Close(false, Type.Missing, Type.Missing);
            _excelApp.Quit();
        }

        /******************************************
         * EXPORT METHODS
         *****************************************/
        private void ExportText(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.Write(text);
            }
        }

        private void ExportDocument(string filename)
        {
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();

            oWord.Visible = false;

            var oDoc = oWord.Documents.Add();

            var paragraph1 = oDoc.Content.Paragraphs.Add();

            paragraph1.Range.Text = text.ToString();
            paragraph1.Range.Font.Bold = 0;
            paragraph1.Format.SpaceAfter = 24;

            oDoc.SaveAs2(filename);
            oDoc.Close();
            //((Microsoft.Office.Interop.Word._Document)paragraph1).Close();
            oWord.Quit();
        }

        private void ExportExcel(string _filename)
        {
            Microsoft.Office.Interop.Excel._Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = false;
            var workbook = xlApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
            object misValue = System.Reflection.Missing.Value;

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    worksheet.Cells[i + 1, j + 1] = cells[i, j];
                }
            }

            string[] names = null;

            if (_filename[2] == '/')
            {
                names = _filename.Split('/');
            }
            else if (_filename[2] == '\\')
            {
                names = _filename.Split('\\');
            }

            if (names.Length > 0)
            {
                // AUTOMATICALLY SAVES TO DOCUMENTS FOLDER
                workbook.SaveAs(names[names.Length - 1], Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            workbook.Close();
            xlApp.Quit();
        }

        /******************************************
         * ENCRYPTION METHODS
         *****************************************/
        private void AaliEncrypt()
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = (char)((key[i % key.Length] + text[i]) ^ key[i % key.Length]);
            }
        }

        private void KyleEncrypt()
        {
            byte[] plainTextBytes = Encoding.Default.GetBytes(text.ToString());
            byte[] encryptedTextBytes = simpleDes.EncryptInfo(plainTextBytes);
            string tempString = simpleDes.WriteEncryptedText(encryptedTextBytes);
            text.Clear();
            text.Append(tempString);
        }

        /******************************************
         * EXCEL FORMAT ENCRYPTION HELPER
         * DO NOT TOUCH
         *****************************************/
        private void AaliExcelEncrypt()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    text = new StringBuilder(cells[i, j]);
                    AaliEncrypt();
                    cells[i, j] = text.ToString();
                }
            }
        }

        private void KyleExcelEncrypt()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    text = new StringBuilder(cells[i, j]);
                    KyleEncrypt();
                    cells[i, j] = text.ToString();
                }
            }
        }

        /******************************************
         * DECRYPTION METHODS
         *****************************************/
        private void AaliDecrypt()
        {
            int xor = 0;

            for (int i = 0; i < text.Length; i++)
            {
                xor = text[i] ^ key[i % key.Length];
                text[i] = (char)(xor - key[i % key.Length]);
            }
        }

        private void KyleDecrypt()
        {
            Byte[] encryptedTextBytes;
            string decryptText;
            encryptedTextBytes = simpleDes.GetEncryptedText(text.ToString());
            decryptText = simpleDes.decrypt_text(encryptedTextBytes);
            text.Clear();
            text.Append(decryptText);
        }

        /******************************************
         * EXCEL FORMAT DECRYPTION HELPER
         * DO NOT TOUCH
         *****************************************/
        private void AaliExcelDecrypt()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    text = new StringBuilder(cells[i, j]);
                    AaliDecrypt();
                    cells[i, j] = text.ToString();
                }
            }
        }

        private void KyleExcelDecrypt()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    text = new StringBuilder(cells[i, j]);
                    KyleDecrypt();
                    cells[i, j] = text.ToString();
                }
            }
        }
    }
}
