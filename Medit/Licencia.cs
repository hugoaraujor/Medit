using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Instrumentation;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Runtime.InteropServices;

namespace Medit
{
    public class Licencia
    {

        public static string base64Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

        [DllImport("kernel32.dll")]
        public static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, UInt32 VolumeNameSize, ref UInt32 VolumeSerialNumber, ref UInt32 MaximumComponentLength, ref UInt32 FileSystemFlags, StringBuilder FileSystemNameBuffer, UInt32 FileSystemNameSize);

        //logico
        public static string GetVolumeSerial(string strDriveLetter)
        {
            uint serNum = 0;
            uint maxCompLen = 0;
            StringBuilder VolLabel = new StringBuilder(256); // Label
            UInt32 VolFlags = new UInt32();
            StringBuilder FSName = new StringBuilder(256); // File System Name
            strDriveLetter += ":\\"; // fix up the passed-in drive letter for the API call
            long Ret = GetVolumeInformation(strDriveLetter, VolLabel, (UInt32)VolLabel.Capacity, ref serNum, ref maxCompLen, ref VolFlags, FSName, (UInt32)FSName.Capacity);
            return Convert.ToString(serNum);
        }

        //Fisico
        //public static string SerialDiscoduro()
        //{
        //    int count = 0;
        //    DirectoryInfo currentDir = new DirectoryInfo(Environment.CurrentDirectory);
        //    string path = string.Format("win32_logicaldisk.deviceid=\"{0}\"",
        //      currentDir.Root.Name.Replace("\\", ""));
        //    ManagementObject disk = new ManagementObject(path);
        //    disk.Get();
        //    //Console.WriteLine(disk.Get("SerialNumber").Value.ToString());
        //    string xvalue = "";
        //    foreach (PropertyData property in disk.Properties)
        //    {
        //        string name = property.Name;
        //        object value = (property.Value ?? string.Empty);
        //        //     MessageBox.Show(name+":"+value.ToString());
        //        if (name == "VolumeSerialNumber")
        //        {
        //            xvalue = value.ToString();

        //        }

        //    }
        //    return xvalue;
        //}

        public static short Asc(string String)
        {
            return Encoding.Default.GetBytes(String)[0];
        }
        public static string Chr(int CharCode)
        {
            if (CharCode > 255)
                throw new ArgumentOutOfRangeException("CharCode", CharCode, "CharCode must be between 0 and 255.");
            return Encoding.Default.GetString(new[] { (byte)CharCode });
        }


        //RegistryKey rkey3 = key2.CreateSubKey("TESTING");
        //key3.SetValue("Test","Hi there!");

        public static string EncodeStr(string strIn)
        {

            dynamic c1 = null;
            dynamic c2 = null;
            dynamic c3 = null;
            dynamic w1 = null;
            dynamic w2 = null;
            dynamic w3 = null;
            dynamic w4 = null;
            dynamic n = null;
            dynamic strOut = null;
            strOut = "";
            for (n = 0; n < strIn.Length; n += 3)
            {
                try
                {
                    c1 = Asc(strIn.Substring(n, 1));
                    c2 = Asc(strIn.Substring(n + 1, 1) + Chr(0));
                    c3 = Asc(strIn.Substring(n + 2, 1) + Chr(0));
                }
                catch (Exception ex)
                {

                }
                w1 = Convert.ToInt32(c1 / 4);
                w2 = (c1 & 3) * 16 + Convert.ToInt32(c2 / 16);
                if (strIn.Length >= n + 1)
                {
                    w3 = (c2 & 15) * 4 + Convert.ToInt32(c3 / 64);
                }
                else
                {
                    w3 = -1;
                }
                if (strIn.Length >= n + 2)
                {
                    w4 = c3 & 63;
                }
                else
                {
                    w4 = -1;
                }
                try
                {
                    strOut = strOut + mimeencode(w1) + mimeencode(w2) + mimeencode(w3) + mimeencode(w4);
                }
                catch (Exception ex)
                {

                }

            }
            return strOut;
        }

        private static int mimedecode(string strIn)
        {
            int functionReturnValue = 0;
            if (strIn.Length == 0)
            {
                functionReturnValue = -1;
            }
            else
            {
                functionReturnValue = base64Chars.IndexOf(strIn);
            }
            return functionReturnValue;
        }

        public static string DecodeStr(string strIn)
        {
            dynamic w1 = 0;
            dynamic w2 = 0;
            dynamic w3 = 0;
            dynamic w4 = 0;
            dynamic n = 0;
            dynamic strOut = "";
            strOut = "";
            for (n = 0; n < strIn.Length; n += 4)
            {
                w1 = mimedecode(strIn.Substring(n, 1));
                w2 = mimedecode(strIn.Substring(n + 1, 1));
                w3 = mimedecode(strIn.Substring(n + 2, 1));
                w4 = mimedecode(strIn.Substring(n + 3, 1));
                if (w2 >= 0)
                    strOut = strOut + Chr(((w1 * 4 + Convert.ToInt32(w2 / 16)) & 255));
                if (w3 >= 0)
                    strOut = strOut + Chr(((w2 * 16 + Convert.ToInt32(w3 / 4)) & 255));
                if (w4 >= 0)
                    strOut = strOut + Chr(((w3 * 64 + w4) & 255));
            }
            return strOut;
        }


        private static string mimeencode(int intIn)
        {
            string functionReturnValue = "";

            if (intIn >= 0)
            {
                functionReturnValue = base64Chars.Substring(intIn, 1);
            }
            else
            {
                functionReturnValue = "";
                return functionReturnValue;
            }
            return functionReturnValue;
        }

        public static bool ESTALICENCIADO()
        {
            bool ale = true;
            //if ((DateTime.Now > Convert.ToDateTime("30/07/2014")) || (DateTime.Now < Convert.ToDateTime("20/04/2014")))
            //    ale = false;
            ////  //MTIw-MTMw-Mz14-ODgw-MjEw-OTQy
            //string path = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            //IniFile MyIni = new IniFile(path + "\\app.wpf");
            //         if (ale==false)
            //             MyIni.Write("Licencia", "codigo","120");
            ////   MyIni.Write("Licencia", "paranada", "0");
            //string licencia = MyIni.Read("Licencia", "codigo");
            //string licenciafecha = MyIni.Read("Licencia", "extension");
            //string licenciaa= MyIni.Read("Version");
            //if (licenciaa == "0") 
            //{
            //    MessageBox.Show("Su Licencia ha expirado.");
            //    MyIni.Write("Version", "0");

            //         Application.Exit();
            //    return false;
            //}

            //if (licencia == "")
            //    construyelicencia();

            //  licencia = licencia.Replace("-", "");
            //  //string auxspc = new string(' ', 30);
            //  //if (licencia.Length < 24)
            //  //    licencia = licencia + auxspc;
            //  //   string fecha = licencia.Substring(1, 12);

            string liccode = "";// licencia.Substring(12, 12);

            //  string fecha = DecodeStr(licenciafecha);
            //  string liccode = DecodeStr(licencia);
            //  string diass =Microsoft.VisualBasic.Strings.Left(fecha, 2);
            //  string fech = "";
            //  if (fecha.Length>0)
            //   fech = Microsoft.VisualBasic.Strings.Mid(fecha, 3,fecha.Length-3+1);
            ////  MessageBox.Show(fech);
            //  //   MessageBox.Show(diass);
            string serialdisco = GetVolumeSerial("C");
            //  MessageBox.Show(fecha);
            //   MessageBox.Show(liccode);
            //            MessageBox.Show(EncodeStr("11"));
            //if ((diass!= "11")&&(fech!=""))
            //{
            //    DateTime firstDate = Convert.ToDateTime(fech);
            //    //     MessageBox.Show(firstDate.ToLongDateString());
            //    //   MessageBox.Show(DateTime.Now.Date.Subtract(firstDate).TotalDays.ToString());
            //    if (DateTime.Now.Date.Subtract(firstDate).TotalDays >= Convert.ToInt32(diass))
            //    {
            //        MessageBox.Show("Su Licencia ha expirado.");
            //        MyIni.Write( "Version", "0");
            //        Application.Exit();
            //        return false;
            //    }
            //}
            //  MessageBox.Show(serialdisco);
            //403668415
         
            if ((liccode == serialdisco))
                ale = true;

            return ale;
        }

    }

}



