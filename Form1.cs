using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Speech.Synthesis;

namespace NumberReader
{
    public partial class Form1 : Form
    {
        static string[] digit = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static string[] tensdigit = new string[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static string[] teensdigit = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        static string[] round = new string[] { "", "thousand", "million", "billion" };
        static string[] roundvie = new string[] { "", "nghìn", "triệu", "tỷ" };
        static string[] digitvie = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        static string[] tensdigitvie = new string[] { "lẻ", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        int count = 0;
        string Input = "";
        bool t = true;
        public Form1()
        {
            InitializeComponent();
            rbt_Vietnamese.Checked = true;
            DoubleBuffered = true;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (rbt_Vietnamese.Checked==true) MessageBox.Show("Hẹn Gặp Lại", "Chào Tạm Biệt", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (rbt_English.Checked == true) MessageBox.Show("See You Again", "Good Bye", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Close();
        }

        private void rbt_Vietnamese_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Vietnamese.Checked == true)
            {
                MessageBox.Show("Xin chào, tôi là Bay Max, người bạn đọc số cho bạn", "Xin chào!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DoubleBuffered = true;
                lbl_Input.Text = "Nhập Số: ";
                gbx_Language.Text = "Ngôn Ngữ";
                rbt_Vietnamese.Text = "Tiếng Việt";
                rbt_English.Text = "Tiếng Anh";
                btn_Read.Text = "Đọc Số";
                btn_Close.Text = "Đóng";
                this.Text = "Đọc Số Nguyên";
                btn_Speak.Text = "Phát âm";
            }
            else if (rbt_English.Checked == true)
            {
                MessageBox.Show("Hi, I'm Bay Max, Your Number Reader", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DoubleBuffered = true;
                lbl_Input.Text = "Input: ";
                gbx_Language.Text = "Language";
                rbt_Vietnamese.Text = "Vietnamese";
                rbt_English.Text = "English";
                btn_Read.Text = "Read Number";
                btn_Close.Text = "Close";
                this.Text = "Number Reader";
                btn_Speak.Text = "Pronounce";
            }
            btn_Read.PerformClick();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            txt_Result.Text = "";
            if (rbt_English.Checked == true)
            {
                string inputstring = txt_Input.Text.Replace(",", "");
                string resultstring = "";
                int len = inputstring.Length;
                int family = 0;
                if (inputstring == "0") resultstring = "zero";
                if (inputstring != "0")
                {
                    while (len > 0)
                    {
                        if (len > 3)
                        {
                            Int64 tmp = Int64.Parse(inputstring.Substring(len - 3, 3));
                            if (tmp != 0)
                            {
                                resultstring = ReadFunctionEnglish(tmp) + " " + round[family] + " " + resultstring;
                            }
                            len -= 3;
                            family += 1;
                        }
                        else
                        {
                            Int64 tmp1 = Int64.Parse(inputstring.Substring(0, len));
                            if (tmp1 != 0)
                            {
                                resultstring = ReadFunctionEnglish(tmp1) + " " + round[family] + " " + resultstring;
                            }
                            len -= 3;
                            family += 1;
                        }
                    }
                }
                txt_Result.Text = resultstring;
            }
            if (rbt_Vietnamese.Checked == true)
            {
                string inputstring = txt_Input.Text.Replace(",", "");
                string resultstring = "";
                int time;
                int len = inputstring.Length;
                int family = 0;
                if (inputstring == "0") resultstring = "không ";
                if (inputstring != "0")
                {
                    while (len > 0)
                    {
                        if (len > 3)
                        {
                            Int64 tmp = Int64.Parse(inputstring.Replace(",", "").Substring(len - 3, 3));
                            if (tmp != 0)
                            {
                                resultstring = ReadFunctionVietnamese(tmp, 2) + " " + roundvie[family] + " " + resultstring;
                            }
                            len -= 3;
                            family += 1;
                        }
                        else
                        {
                            Int64 tmp1 = Int64.Parse(inputstring.Replace(",", "").Substring(0, len));
                            if (tmp1 != 0)
                            {
                                resultstring = ReadFunctionVietnamese(tmp1, 1) + " " + roundvie[family] + " " + resultstring;
                            }
                            len -= 3;
                            family += 1;
                        }
                    }
                }
                txt_Result.Text = resultstring;
            }
        }

        public static string ReadFunctionEnglish(Int64 number)
        {
            string outstring;
            outstring = "";
            if ((number % 1000) / 100 != 0) outstring += digit[(number % 1000) / 100] + " hundred";
            if ((number % 100) / 10 == 1 && (number % 10 != 0))
            {
                if ((number % 1000) / 100 == 0) outstring += teensdigit[number % 10];
                if ((number % 1000) / 100 != 0) outstring += " " + teensdigit[number % 10];
            }
            else
            {
                if ((number % 100) / 10 != 0 && ((number % 1000) / 100 != 0)) outstring += " " + tensdigit[(number % 100) / 10];
                if ((number % 100) / 10 != 0 && ((number % 1000) / 100 == 0)) outstring += tensdigit[(number % 100) / 10];
                if ((number % 10 != 0) && (((number % 100) / 10 != 0) || ((number % 1000) / 100 != 0))) outstring += " " + digit[number % 10];
                if ((number % 10 != 0) && ((number % 100) / 10 == 0) && ((number % 1000) / 100 == 0)) outstring += digit[number % 10];
            }
            return outstring;
        }

        public static string ReadFunctionVietnamese(Int64 number, int length)
        {
            string outstring;
            outstring = "";
            if (length == 1)
            {
                if ((number % 1000) / 100 != 0) outstring += digitvie[(number % 1000) / 100] + " trăm";
                if (((number % 100) / 10 != 0) && ((number % 1000) / 100 != 0))
                {
                    if ((number % 100) / 10 == 1) outstring += " mười";
                    else outstring += " " + digitvie[(number % 100) / 10] + " mươi";
                }
                if (((number % 100) / 10 != 0) && ((number % 1000) / 100 == 0))
                {
                    if ((number % 100) / 10 == 1) outstring += "mười";
                    else outstring += digitvie[(number % 100) / 10] + " mươi";
                }
                if ((number % 10 != 0) && (number % 100) / 10 != 0)
                {
                    if ((number % 100) / 10 != 1)
                    {
                        if (number % 10 == 1) outstring += " mốt";
                        if (number % 10 == 5) outstring += " lăm";
                        if ((number % 10 != 1) && (number % 10 != 5)) outstring += " " + digitvie[number % 10];
                    }
                    if ((number % 100) / 10 == 1)
                    {
                        if (number % 10 == 5) outstring += " lăm";
                        if (number % 10 != 5) outstring += " " + digitvie[number % 10];
                    }
                }
                if ((number % 1000) / 100 == 0 && (number % 100) / 10 == 0) outstring += digitvie[number % 10];
                if ((number % 100) / 10 == 0 && ((number % 1000) / 100 != 0) && (number % 10 != 0)) outstring += " lẻ " + digitvie[number % 10];
            }
            else
            {
                if (number != 000)
                {
                    outstring += digitvie[(number % 1000) / 100] + " trăm";
                    if ((number % 100) / 10 == 1) outstring += " mười";
                    if (((number % 100) / 10 != 1) && (number % 100) / 10 != 0) outstring += " " + digitvie[(number % 100) / 10] + " mươi";
                    if ((number % 100) / 10 == 0 && (number % 10 != 0)) outstring += " lẻ " + digitvie[number % 10];
                    if (((number % 100) / 10 != 0) && (number % 10 != 0) && (number % 10 != 5) && (number % 10 != 1)) outstring += " " + digitvie[number % 10];
                    if (((number % 100) / 10 != 0) && (number % 10 != 0) && (number % 10 == 5)) outstring += " lăm";
                    if (((number % 100) / 10 != 0) && (number % 10 != 0) && (number % 100) / 10 != 1 && (number % 10 == 1)) outstring += " mốt";
                    if (((number % 100) / 10 != 0) && (number % 10 != 0) && (number % 100) / 10 == 1 && (number % 10 == 1)) outstring += " một";
                }
                else outstring = "";
            }
            return outstring;
        }

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
            if (txt_Input.Text.Length > 0)
            {
                int tmp = txt_Input.SelectionStart;
                int count = txt_Input.TextLength - txt_Input.Text.Replace(",", "").Length;
                string tmp1 = Convert.ToInt64(txt_Input.Text.Replace(",", "")).ToString("N0");
                tmp1 = tmp1.Replace(".", ",");
                txt_Input.Text = tmp1;
                int count1= txt_Input.TextLength - txt_Input.Text.Replace(",", "").Length;
                if (count1 > count) txt_Input.SelectionStart = tmp + 1;
                if (count1 < count) txt_Input.SelectionStart = tmp-1;
                if (count1 == count) txt_Input.SelectionStart = tmp;

            }
            btn_Read.PerformClick();
        }

        private void btn_Speak_Click(object sender, EventArgs e)
        {
            if (rbt_Vietnamese.Checked == true)
            {
                string tmp = "";
                string inputstring = txt_Result.Text;
                //inputstring = inputstring.Replace(" ", "");
                for (int i = 1; i <= inputstring.Length; i++)
                {
                    if (inputstring.Substring(i - 1, 1) != " ") tmp += inputstring.Substring(i - 1, 1);
                    if (inputstring.Substring(i - 1, 1) == " ")
                    {
                        if (tmp == "một")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Một);
                            audio.Play();                            
                        }
                        if (tmp == "hai")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Hai);
                            audio.Play();                            
                        }
                        if (tmp == "ba")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Ba);
                            audio.Play();                            
                        }
                        if (tmp == "bốn")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Bốn);
                            audio.Play();                            
                        }
                        if (tmp == "năm")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Năm);
                            audio.Play();                            
                        }
                        if (tmp == "sáu")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Sáu);
                            audio.Play();                            
                        }
                        if (tmp == "bảy")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Bảy);
                            audio.Play();                            
                        }
                        if (tmp == "tám")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Tám);
                            audio.Play();                            
                        }
                        if (tmp == "chín")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Chín);
                            audio.Play();                           
                        }
                        if (tmp == "mười")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Mười);
                            audio.Play();                            
                        }
                        if (tmp == "mươi")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Mươi);
                            audio.Play();                           
                        }
                        if (tmp == "mốt")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Mốt);
                            audio.Play();                            
                        }
                        if (tmp == "lăm")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Lăm);
                            audio.Play();                            
                        }
                        if (tmp == "nghìn")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Nghìn);
                            audio.Play();                           
                        }
                        if (tmp == "triệu")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Triệu);
                            audio.Play();
                            
                        }
                        if (tmp == "tỷ")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Tỷ);
                            audio.Play();                         
                        }
                        if (tmp == "lẻ")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Lẻ);
                            audio.Play();                        
                        }
                        if (tmp == "không")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Không);
                            audio.Play();                        
                        }
                        if (tmp == "trăm")
                        {
                            SoundPlayer audio = new SoundPlayer(NumberReader.Properties.Resources.Trăm);
                            audio.Play();              
                        }
                        tmp = "";
                        Thread.Sleep(750);
                    }
                }
            }
            if (rbt_English.Checked == true)
            {
                SpeechSynthesizer speaker = new SpeechSynthesizer();
                speaker.SpeakAsync(txt_Result.Text);
            }
        }

        private void txt_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            string temp = txt_Input.Text;
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8))
                e.Handled = true;
            if ((temp.Replace(",", "").Length >= 12) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Input_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            if (rbt_Vietnamese.Checked == true)
            {
                tt.Show("Vui lòng nhập số không quá 12 ký tự", txt_Input, 0, -50, 2000);
            }
            if (rbt_English.Checked == true)
            {
                tt.Show("Please input a number with no more than 12 digits", txt_Input, 0, -50, 2000);
            }
        }
    }
}
