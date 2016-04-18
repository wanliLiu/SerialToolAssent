using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace SerialToolAssent
{
    class SerialClass
    {
        Encoding gb = Encoding.GetEncoding("GBK");//获得字符编码的方式，采用GBK编码方式
        
        public SerialClass() { }//空构造函数
        //---------------------------------
        //摘要：字符编码成十六进制
        //参数：
        //      str:
        //          输入字符串
        //返回结果：
        //     编码好后的十六进制数组
        //而外说明：
        //　　 采用GBK方式编码
        //---------------------------------
        public byte[] StringToBytes(string str)
        {
            byte[] array = gb.GetBytes(str);
            return array;
        }
        //---------------------------------
        //摘要：十六进制编码成字符
        //参数：
        //      array:
        //           输入十六进制数组
        //返回结果：
        //     编码好后的字符
        //而外说明：
        //　　 采用GBK方式编码
        //---------------------------------
        public string BytesToString(byte[] array)
        {
            string str = gb.GetString(array);
            return str;
        }
        //-----------------------------------------------
        //摘要：把文本十六进制转成十六进制数组
        //参数：
        //      str:
        //           输入字符串
        //返回结果：
        //     解码好后的字符
        //而外说明：
        //　　 采用GBK方式编码
        //-----------------------------------------------
        public string StringToHex(string str)
        {
            int len = str.Length / 2;
            byte[] array = new byte[len];
            if (str.Length % 2 == 0)//必须保证是偶数个数据
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
                }
                
            }
            else
            {
                MessageBox.Show("必须保证输入的数据是偶数个！");
            }
            return BytesToString(array);
        }
        //---------------------------------------------------------------
        //输入字符串，输出字节数组，与上面那一个的区别在于去掉空格
        //---------------------------------------------------------------
        public string StringToBytesTab(string str)
        {
            string text = str.Replace(" ", "");//去掉空格字符
            string array = StringToHex(text);
            return array;
        }
    }
 
}
