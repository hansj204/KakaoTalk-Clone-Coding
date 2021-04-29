using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WindowApp.Controller
{
    public enum DesType
    {
        Encrypt = 0, //암호화
        Decrypt = 1 //복호화
    }

    //암호화, 복호화 메서드
    class DES
    {
        public DES(string key)
        {
            Key = ASCIIEncoding.ASCII.GetBytes(key);
        }

        private byte[] Key { get; set; }

        //Key 값이 8자리 정보

        public string result(DesType type, string input) 
        {

            var des = new DESCryptoServiceProvider()
            {
                Key = Key,
                IV = Key
            };

            var ms = new MemoryStream();

            //익명 타입으로 transform / data 정의
            var property = new
            {
                transform = type.Equals(DesType.Encrypt) ? des.CreateEncryptor() : des.CreateDecryptor(),
                data = type.Equals(DesType.Encrypt) ? Encoding.UTF8.GetBytes(input.ToCharArray()) : Convert.FromBase64String(input)
            };

            var cryStream = new CryptoStream(ms, property.transform, CryptoStreamMode.Write);

            var data = property.data;
            cryStream.Write(data, 0, data.Length);
            cryStream.FlushFinalBlock();

            return type.Equals(DesType.Encrypt) ? Convert.ToBase64String(ms.ToArray()) : Encoding.UTF8.GetString(ms.GetBuffer()); 
        }
    }
}
