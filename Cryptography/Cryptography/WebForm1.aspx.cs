using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace Cryptography
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        UnicodeEncoding byteConverter = new UnicodeEncoding();
        byte[] plainText;
        byte[] encryptedText;
        byte[] decryptedText;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            plainText = byteConverter.GetBytes(TextBox1.Text);
            encryptedText = RSAecrypt(plainText,RSA.ExportParameters(false),false);
            TextBox2.Text = byteConverter.GetString(encryptedText);
            decryptedText = RSADecrypt(encryptedText, RSA.ExportParameters(true),false);
            TextBox3.Text = byteConverter.GetString(decryptedText);
        }

        private byte[] RSAecrypt(byte[] encryptedText, RSAParameters rSAParameters, bool v)
        {
            //throw new NotImplementedException();
            try
            {
                byte[] encrypteddata; ;
                RSACryptoServiceProvider RCSP = new RSACryptoServiceProvider();
                {
                    RCSP.ImportParameters(rSAParameters);
                    encrypteddata = RCSP.Encrypt(plainText, v);
                }
                return encrypteddata;
            }catch (CryptographicException e) {
                Response.Write(e);
                return null;
            }
        }

        public byte[] RSADecrypt(byte[] encryptedText, RSAParameters rSAParameters, bool v)
        {
            //throw new NotImplementedException();
            try
            {
                byte[] decrypteddata;
                RSACryptoServiceProvider RCSP = new RSACryptoServiceProvider();
                {
                    RCSP.ImportParameters(rSAParameters);
                    decrypteddata = RCSP.Decrypt(encryptedText, v);
                }
                return decrypteddata;
            }catch(CryptographicException e)
            {
                Response.Write(e);
                return null;
            }
        }
    }
}