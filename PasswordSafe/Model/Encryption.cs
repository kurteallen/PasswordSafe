using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSafe.Model
{
    public class Encryption
    {
        private byte[] enPass = null;
        
        public Encryption ()
        {
           
        }

        public void EncryptAndSerialize(string password, BindingList<Accounts> blist)
        {
            RijndaelManaged des = new RijndaelManaged();
            
            byte[] Salt = Encoding.ASCII.GetBytes(password.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(password, Salt);
            ICryptoTransform Encryptor = des.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            var fs = new FileStream("./datas", FileMode.Create, FileAccess.Write);
            var cryptoStream = new CryptoStream(fs, Encryptor, CryptoStreamMode.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            
            // This is where you serialize the class
            formatter.Serialize(cryptoStream, blist);
            cryptoStream.FlushFinalBlock();
            fs.Close();
        }

        public void DecryptAndUnSerialize(string password)
        {
            RijndaelManaged des = new RijndaelManaged();
            
            byte[] Salt = Encoding.ASCII.GetBytes(password.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(password, Salt);
            ICryptoTransform Decryptor = des.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            var fs = new FileStream("./datas", FileMode.Open, FileAccess.Read);
            var cryptoStream = new CryptoStream(fs, Decryptor, CryptoStreamMode.Read);
            
            BinaryFormatter formatter = new BinaryFormatter();

            SingletonList.Instance.GetList = (BindingList<Accounts>) formatter.Deserialize(cryptoStream);
            cryptoStream.Flush();
            fs.Close();
        }

        public Boolean StoreNewPassword(string password)
        {
            Boolean status = true;
            string filePath = "./filedata";
            byte[] encrypted = this.EncryptRij(password);

            try
            {
                File.WriteAllBytes(filePath, encrypted);
                
            }
            catch (Exception e)
            {
                if (e != null)
                    status = false;
            }
            return status;
        }

        public byte[] EncryptRij(string password)
        {
            
            RijndaelManaged des = new RijndaelManaged();
            
            byte[] Salt = Encoding.ASCII.GetBytes(password.Length.ToString());
            byte[] encrypted = null;
            
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(password, Salt);
            
            ICryptoTransform encryptor = des.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
           
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(password);
                    }
                   
                    encrypted = msEncrypt.ToArray();
                    this.enPass = encrypted;
                }
            }
            System.Console.WriteLine("The encrypted Text after Encrypter " + password);
            
            return encrypted;

        }

        public string Decryptr(string password)
        {
            string plainText = null;

            string filePath = "./filedata";

            byte[] cipherText = null;
            cipherText = File.ReadAllBytes(filePath);
            
            RijndaelManaged des = new RijndaelManaged();
            
            //System.Console.WriteLine("Encrypted Bytes read from file " + System.Text.Encoding.Default.GetString(cipherText));

            byte[] Salt = Encoding.ASCII.GetBytes(password.Length.ToString());
  
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(password, Salt);
            
            ICryptoTransform decryptor = des.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            try
            {
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plainText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            System.Console.WriteLine("This is the decrypted password from Decrypt " + plainText);
            return (plainText);
        }
  
        public Boolean VerifyPassword(string password)
        {
            
            // retrieve encrypted password and decrypt
            Boolean status = true;

            // Decrypt the recieved file

            string decryptedPassword = this.Decryptr(password);

            if (password.Equals(decryptedPassword))
                System.Console.WriteLine("Passwords Match " + decryptedPassword);
                
            else
            {
                System.Console.WriteLine("Passwords did not match");
                status = false;
            }
         
            return status;
        }
    }
}
