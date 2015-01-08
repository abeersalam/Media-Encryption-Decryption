using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cryptik
{
    /******************************************
     * Base Abstract Class CSFile
     *  
     * All methods and variables inherited by:
     *  - CSDocument
     *  - CSImage
     *****************************************/
    public abstract class CSFile
    {
        protected string filename;
        protected string extension;
        protected string key;
        protected string filepath;
        protected byte[] authKey;
        protected byte[] aesKey;
        public virtual void import(int encryptionType, string _filename) { }
        public virtual void encrypt(int encryptionType) { }
        public virtual void decrypt(int encryptionType) { }
        public virtual void export(bool encrypt, int encryptionType, string filename) { }
        public virtual void setKey(string _key) { }
        public virtual void print() { }
    }
}
