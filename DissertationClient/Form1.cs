using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace DissertationClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Menu_Login_Click(object sender, EventArgs e)
        {

            String ifTarget1 = "http://localhost:8080/DissertationBackend/sys_Image/Overview.php";
            String ifTarget2 = "http://localhost:8080/DissertationBackend/sys_Image/ImageUpload.php";
            Uri urlTarget1 = new Uri(ifTarget1);
            Uri urlTarget2 = new Uri(ifTarget2);
            if (webControl.Source == urlTarget1 || webControl.Source == urlTarget2)
            {

                Uri LogoutTarget = new Uri("http://localhost:8080/DissertationBackend/Sys_Login/login.php");
                groupBox_CreateAccount.Visible = false;
                webControl.Visible = true;
                webControl.Source = LogoutTarget;

            }
            else
            {
                button_CA_Create.Visible = false;
                groupBox_CreateAccount.Visible = true;
                button_Login.Visible = true;
                webControl.Visible = false;
            }
        }

        private void button_Menu_CreateAccount_Click(object sender, EventArgs e)
        {
            button_CA_Create.Visible = true;
            groupBox_CreateAccount.Visible = true;
            button_Login.Visible = false;
            webControl.Visible = false;
        }

        private void button_CA_Create_Click(object sender, EventArgs e)
        {
            String User = textBox_UserName.Text;
            String Pass = textBox_Password.Text;
            String P = "";
            String i = "";
            String k = "";

            Console.Write("Calling Encrypt Function" + "\r\n");
            GenerateKeyIV(out k, out i);
            Encrypt(Pass, out P, k, i);
           
            
           // Encrypt(Pass,out P,k,i);


            Console.WriteLine("Pass is" + Pass + "\r\n");
            Console.WriteLine("P is" + P + "\r\n");
            Console.WriteLine("Key is" + k);
            Console.WriteLine("IV is" + i);


            // Deals with the uri and visibility settings
            String username = "UserName=" + User;
            String PassWord = "&Password=" + Pass;
            String INV = "&IV=" + i;
            String KY = "&K=" + k;

            String target = "http://localhost:8080/DissertationBackend/Sys_Register/RegisterCheck.php?" + username + PassWord + INV + KY;
            Uri T = new Uri(target);
            groupBox_CreateAccount.Visible = false;
            webControl.Visible = true;
            webControl.Source = T;




        }
        static String Encrypt(String Pass,out string P, string k, string i)
        {
            /*
             * function static void Encrypt
             * --------------------------------------------------------
             * PURPOSE: Encrypt the Password Entered in the Text Box
             * --------------------------------------------------------
             * PASSED VARIABLES:
             * 1) String Pass = unencrypted Password
             * 2) out String P = Encrypted Password
             * 
             * ---------------------------------------------------------
             */
          
           
             var rj = new RijndaelManaged()
            {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC,
                KeySize = 256,
                BlockSize = 256,
            };
                      
            
           
            
            var sToEncrypt = Pass;

           

            var key = Convert.FromBase64String(k);
            var IV = Convert.FromBase64String(i);

           
            var encryptor = rj.CreateEncryptor(key, IV);

            var msEncrypt = new MemoryStream();
            var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            var toEncrypt = Encoding.ASCII.GetBytes(sToEncrypt);

            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();

            var p = msEncrypt.ToArray();
            P = Convert.ToBase64String(p);
            return P;


        }

        public static void GenerateKeyIV(out string key, out string IV)
        {
            var rj = new RijndaelManaged()
            {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC,
                KeySize = 256,
                BlockSize = 256,
            };
            rj.GenerateKey();
            rj.GenerateIV();

            key = Convert.ToBase64String(rj.Key);
            IV = Convert.ToBase64String(rj.IV);
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
               
                       
            String User = textBox_UserName.Text;
            String Pass = textBox_Password.Text;
            String P = "";
            String i = "";
            String k = "";


            Console.WriteLine("Calling Encrypt Function" + "\r\n");
            GenerateKeyIV(out k, out i);
            Encrypt(Pass, out P, k, i);


            Console.WriteLine("Pass is" + Pass + "\r\n");
            Console.WriteLine("P is" + P + "\r\n");
            Console.WriteLine("i = " + i);
            Console.WriteLine("k = " + k);

            // Deals with the uri and visibility settings
            String username = "UserName=" + User;
            String PassWord = "&Password=" + P;
            String INV = "&IV=" + i;
            String KY = "&K=" + k;

            String target = "http://localhost:8080/DissertationBackend/Sys_Login/logintosite.php?" + username + PassWord + INV + KY;
            Uri T = new Uri(target);
            groupBox_CreateAccount.Visible = false;
            webControl.Visible = true;
            webControl.Source = T;

            
        }

        private void button_Upload_Image_Click(object sender, EventArgs e)
        {
            String Tar = "http://localhost:8080/DissertationBackend/sys_Image/ImageUpload.php";
            Uri Im = new Uri(Tar);
            webControl.Visible = true;
            webControl.Source = Im;
        
        }

        private void button_Menu_View_Images_Click(object sender, EventArgs e)
        {
            String Tar = "http://localhost:8080/DissertationBackend/sys_Image/Overview.php";
            Uri Im = new Uri(Tar);
            webControl.Visible = true;
            webControl.Source = Im;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;

            
            fontDialog1.Font = button_Login.Font;
            fontDialog1.Color = button_Login.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                button_Login.Font = fontDialog1.Font;
                button_Login.ForeColor = fontDialog1.Color;

                button_CA_Create.Font = fontDialog1.Font;
                button_CA_Create.ForeColor = fontDialog1.Color;

                button_Menu_Login.Font = fontDialog1.Font;
                button_Menu_Login.ForeColor = fontDialog1.Color;

                button_Menu_CreateAccount.Font = fontDialog1.Font;
                button_Menu_CreateAccount.ForeColor = fontDialog1.Color;

                button_Menu_View_Images.Font = fontDialog1.Font;
                button_Menu_View_Images.ForeColor = fontDialog1.Color;

                button_Upload_Image.Font = fontDialog1.Font;
                button_Upload_Image.ForeColor = fontDialog1.Color;


                label1.Font = fontDialog1.Font;
                label1.ForeColor = fontDialog1.Color;

                label2.Font = fontDialog1.Font;
                label2.ForeColor = fontDialog1.Color;
                


            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.BackColor = colorDialog1.Color;
                
            }
        }
    }
}
