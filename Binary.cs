namespace Convert
{
    public class Binary
    {

        // String To Binary
        public static string StringToBinary(string data)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(System.Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        // Binary To String
        public static string BinaryToString(string data)
        {
            System.Collections.Generic.List<System.Byte> byteList = 
                    new System.Collections.Generic.List<System.Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(System.Convert.ToByte(data.Substring(i, 8), 2));
            }
            return System.Text.Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
}