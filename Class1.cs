using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boot_file_creator
{
    internal class Class1
    {
        public enum ByteSize
        {
            Byte_1 = 1,
            Byte_2,
            Byte_3,
            Byte_4,
            Byte_5,
            Byte_6,
            Byte_7,
            Byte_8
        }

        public static string[] get_hex_char = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        public static string[] get_day_of_week = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public static Byte ascii_char_to_byte(char character)
        {
            return Convert.ToByte(character);
        }
        public static Byte[] ascii_string_to_byte_array(string ascii_string)
        {
            Byte[] b_array = new byte[ascii_string.Length];
            int index = 0;

            foreach (char c in ascii_string)
            {
                b_array[index++] = ascii_char_to_byte(c);
            }
            return b_array;
        }
        public static Byte[] ascii_string_to_byte_array(string ascii_string, int start_ptr)
        {
            ascii_string = ascii_string.Substring(start_ptr);
            return (ascii_string_to_byte_array(ascii_string));
        }

        public static Byte[] ascii_string_to_byte_array(string ascii_string, int start_ptr, int length)
        {
            ascii_string = ascii_string.Substring(start_ptr, length);
            return (ascii_string_to_byte_array(ascii_string));
        }


        public static char byte_to_ascii_char(byte b)
        {
            return Convert.ToChar(b);
        }

        public static string byte_array_to_ascii_string(byte[] b_array, int b_array_len)
        {
            string str = "";
            for (int index = 0; index < b_array_len; index++)
            {
                str += byte_to_ascii_char(b_array[index]);
            }
            return str;
        }

        public static string byte_array_to_ascii_string(byte[] b_array, int b_array_len, int start_ptr)
        {
            string str = "";
            for (int index = start_ptr; index < b_array_len; index++)
            {
                str += byte_to_ascii_char(b_array[index]);
            }
            return str;
        }

        public static string byte_array_to_ascii_string(byte[] b_array, int b_array_len, int start_ptr, int length)
        {
            string str = "";
            for (int index = start_ptr; index < (start_ptr + length); index++)
            {
                str += byte_to_ascii_char(b_array[index]);
            }
            return str;
        }


        public static string ascii_char_to_hex(char c)
        {
            string hex_string;
            ushort char1 = Convert.ToUInt16(c);
            hex_string = GetHexChar((ushort)((char1 >> 4) & 0x0F));
            hex_string += GetHexChar((ushort)(char1 & 0x0F));
            return hex_string;
        }

        public static String ascii_string_to_hex_string(string ascii_string)
        {
            string hex_string = "";
            foreach (char c in ascii_string)
            {
                hex_string += ascii_char_to_hex(c);

            }
            return hex_string;
        }

        public static String ascii_string_to_hex_string_spaced(string ascii_string)
        {
            string hex_string = "";
            foreach (char c in ascii_string)
            {
                hex_string += ascii_char_to_hex(c);
                hex_string += " ";
            }
            return hex_string;
        }

        public static String ascii_string_to_hex_string(string ascii_string, int start_ptr)
        {
            string hex_string = ascii_string.Substring(start_ptr);
            hex_string = ascii_string_to_hex_string(hex_string);
            return hex_string;
        }
        public static String ascii_string_to_hex_string(string ascii_string, int start_ptr, int length)
        {
            string hex_string = ascii_string.Substring(start_ptr, length);
            hex_string = ascii_string_to_hex_string(hex_string);
            return hex_string;
        }

        public static char hex_to_ascii_char(string hex_string)
        {
            char ret_char;
            ret_char = (char)Convert.ToUInt16(hex_string, 16);
            return ret_char;
        }

        public static string hex_string_to_ascii_string(string hex_string)
        {
            string ascii_string = "";
            for (int index = 0; index < hex_string.Length / 2; index++)
            {
                ascii_string += hex_to_ascii_char(hex_string.Substring(2 * index, 2));
            }
            return ascii_string;
        }

        public static string hex_string_to_ascii_string(string hex_string, int start_ptr)
        {
            string ascii_string = hex_string.Substring(2 * start_ptr);
            ascii_string = hex_string_to_ascii_string(ascii_string);
            return ascii_string;
        }

        public static string hex_string_to_ascii_string(string hex_string, int start_ptr, int len)
        {
            string ascii_string = hex_string.Substring(2 * start_ptr, 2 * len);
            ascii_string = hex_string_to_ascii_string(ascii_string);
            return ascii_string;
        }

        public static byte hex_to_byte(string hex_string)
        {
            byte temp_byte = (byte)(Convert.ToUInt16(hex_string, 16));
            return temp_byte;
        }

        public static Byte[] hex_string_to_byte_array(string hex_string)
        {
            Byte[] b_array = new Byte[hex_string.Length / 2];
            string temp;
            for (int i = 0; i < hex_string.Length / 2; i++)
            {
                temp = hex_string.Substring(2 * i, 2);
                b_array[i] = hex_to_byte(temp);
            }
            return b_array;
        }
        public static Byte[] hex_string_to_byte_array(string hex_string, int start_ptr)
        {
            return hex_string_to_byte_array(hex_string.Substring(start_ptr * 2));
        }
        public static Byte[] hex_string_to_byte_array(string hex_string, int start_ptr, int length)
        {
            return hex_string_to_byte_array(hex_string.Substring(start_ptr * 2, length));
        }

        public static string byte_to_hex(byte b)
        {
            char c = byte_to_ascii_char(b);
            string hex_string = ascii_char_to_hex(c);
            return hex_string;
        }
        public static string byte_array_to_hex_string(byte[] b_array, int b_array_len)
        {
            string hex_string = "";
            for (int index = 0; index < b_array_len; index++)
            {
                hex_string += byte_to_hex(b_array[index]);
            }
            return hex_string;
        }

        public static string byte_array_to_hex_string_spaced(byte[] b_array, int b_array_len)
        {
            string hex_string = "";
            for (int index = 0; index < b_array_len; index++)
            {
                hex_string += byte_to_hex(b_array[index]);
                hex_string += " ";
            }
            return hex_string;
        }
        public static string byte_array_to_hex_string(byte[] b_array, int b_array_len, int start_ptr)                                /* Verified */
        {
            string hex_string = "";
            for (int index = start_ptr; index < b_array_len; index++)
            {
                hex_string += byte_to_hex(b_array[index]);
            }
            return hex_string;
        }

        public static string byte_array_to_hex_string(byte[] b_array, int b_array_len, int start_ptr, int length)                                /* Verified */
        {
            string hex_string = "";
            for (int index = start_ptr; index < (start_ptr + length); index++)
            {
                hex_string += byte_to_hex(b_array[index]);
            }
            return hex_string;
        }
        public static string int_to_hex(int i)
        {
            byte[] barry = new byte[2];
            barry[0] = (byte)(i / 256);
            barry[1] = (byte)(i % 256);
            string hex_string = byte_array_to_hex_string(barry, 2);
            return hex_string;
        }

        public static string string_insertor(string input_string, char c, int insert_len)
        {
            string output_string = "";
            for (int i = 0; i < input_string.Length / insert_len; i++)
            {
                output_string += input_string.Substring(insert_len * i, insert_len);
                output_string += c;
            }
            return output_string;
        }

        public static string string_insertor(string input_string, string str, int insert_len)
        {
            string output_string = "";
            for (int i = 0; i < input_string.Length / insert_len; i++)
            {
                output_string += input_string.Substring(insert_len * i, insert_len);
                output_string += str;
            }
            return output_string;
        }

        public static string string_subtract(string input_string, char oldchar, char newchar)
        {
            string output_string = input_string.Replace(oldchar, newchar);
            return output_string;
        }
        public static string string_subtract(string input_string, string oldstr, string newstr)
        {
            string output_string = input_string.Replace(oldstr, newstr);
            return output_string;
        }

        public static bool checkBit(byte num, byte check_pos_decimal)
        {
            if ((num & check_pos_decimal) == check_pos_decimal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkBit(int num, byte check_pos_decimal)
        {
            if ((num & check_pos_decimal) == check_pos_decimal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool checkBit(long num, byte check_pos_decimal)
        {
            if ((num & check_pos_decimal) == check_pos_decimal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GetHexChar(byte i)
        {
            string ret_val = get_hex_char[i];
            return ret_val;
        }
        public static string GetHexChar(ushort i)
        {
            string ret_val = get_hex_char[i];
            return ret_val;
        }
        public static string GetHexChar(uint i)
        {
            string ret_val = get_hex_char[i];
            return ret_val;
        }
        public static bool CheckValidHexString(string hex_string)
        {
            if (hex_string.Length % 2 == 1 || hex_string.Length == 0)
            {
                return false;
            }
            else
            {
                foreach (char b in hex_string)
                {
                    if ((b >= '0' && b <= '9') || (b >= 'a' && b <= 'f') || (b >= 'A' && b <= 'F'))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool CheckValidHexSpacedString(string hex_string)
        {
            hex_string = hex_string.Replace(" ", "");
            return CheckValidHexString(hex_string);
        }
        /************************************** byte array to number conversion *********************************/
        public static sbyte ByteToSByte(byte b)
        {
            return ((sbyte)b);
        }
        public static byte SByteToByte(sbyte b)
        {
            return ((byte)b);
        }
        public static short ByteArrayToS16(byte[] byte_array, ushort loc)
        {
            return (short)(byte_array[loc] * 256 + byte_array[loc + 1]);
        }
        public static double ByteArrayToS16(byte[] byte_array, ushort loc, ushort divisor)
        {
            return ((double)ByteArrayToS16(byte_array, loc) / divisor);
        }

        public static ushort ByteArrayToUs16(byte[] byte_array, ushort loc)
        {
            return (ushort)(byte_array[loc] * 256 + byte_array[loc + 1]);
        }

        public static double ByteArrayToUs16(byte[] byte_array, ushort loc, ushort divisor)
        {
            return ((double)ByteArrayToUs16(byte_array, loc) / divisor);
        }
        public static int ByteArrayToS24(byte[] byte_array, ushort loc)
        {
            return (byte_array[loc] * 65536 + byte_array[loc + 1] * 256 + byte_array[loc + 2]);
        }
        public static double ByteArrayToS24(byte[] byte_array, ushort loc, ushort divisor)
        {
            return ((double)ByteArrayToS24(byte_array, loc) / divisor);
        }
        public static uint ByteArrayToUs24(byte[] byte_array, ushort loc)
        {
            return ((uint)(byte_array[loc] * 65536 + byte_array[loc + 1] * 256 + byte_array[loc + 2]));
        }
        public static double ByteArrayToUs24(byte[] byte_array, ushort loc, ushort divisor)
        {
            return ((double)ByteArrayToUs24(byte_array, loc) / divisor);
        }
        public static int ByteArrayToS32(byte[] byte_array, ushort loc)
        {
            return (byte_array[loc] * 16777216 + byte_array[loc + 1] * 65536 + byte_array[loc + 2] * 256 + byte_array[loc + 3]);
        }
        public static double ByteArrayToS32(byte[] byte_array, ushort loc, ushort divisor)
        {
            return ((double)ByteArrayToS32(byte_array, loc) / divisor);
        }
        public static uint ByteArrayToUs32(byte[] byte_array, ushort loc)
        {
            return ((uint)(byte_array[loc] * 16777216 + byte_array[loc + 1] * 65536 + byte_array[loc + 2] * 256 + byte_array[loc + 3]));
        }
        public static double ByteArrayToUs32(byte[] byte_array, ushort loc, ushort divisor)
        {
            return ((double)ByteArrayToUs32(byte_array, loc) / divisor);
        }

        public static double byte_aray_to_double(byte[] byte_array, ushort loc)
        {
            double d_double = 0;

            if (loc == 1)
            {
                d_double = byte_array[loc];
            }
            else if (loc == 2)
            {
                d_double = byte_array[loc] * 256 + byte_array[loc + 1];
            }
            else if (loc == 3)
            {
                d_double = byte_array[loc] * 65536 + byte_array[loc + 1] * 256 + byte_array[loc + 2];
            }
            else if (loc == 4)
            {
                d_double = byte_array[loc] * 16777216 + byte_array[loc + 1] * 65536 + byte_array[loc + 2] * 256 + byte_array[loc + 3];
            }
            return d_double;
        }

        public static double byte_aray_to_double(byte[] byte_array, ushort loc, ushort divisor)
        {
            return byte_aray_to_double(byte_array, loc) / divisor;
        }

        public static int CalcStringLines(string text)
        {
            int count = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n') count++;
            }

            return count;
        }
    }
}
