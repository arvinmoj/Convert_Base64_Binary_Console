namespace Convert
{
    class Program
    {
        // Encode Base64

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter EC For Encode Base64 ");
            System.Console.WriteLine("Enter DC For Decode Base64 ");
            System.Console.WriteLine("Enter SB For String To Binary ");
            System.Console.WriteLine("Enter BS For Binary To String ");
            System.Console.Write("Enter: ");

            string check = System.Console.ReadLine();

            if (check.ToLower() == "ec")
            {
                System.Console.Write("Enter Text: ");
                string Text = Base64.Base64Encode(System.Console.ReadLine());
                System.Console.WriteLine("Encode Base64: " + Text);
            }

            if (check.ToLower() == "dc")
            {
                System.Console.Write("Enter Text: ");
                string Text = Base64.Base64Decode(System.Console.ReadLine());
                System.Console.WriteLine("Decode Base64: " + Text);
            }

           if (check.ToLower() == "sb")
            {
                System.Console.Write("Enter Text: ");
                string Text = Binary.StringToBinary(System.Console.ReadLine());
                System.Console.WriteLine("String To Binary: " + Text);
            }

            if (check.ToLower() == "bs")
            {
                System.Console.Write("Enter Text: ");
                string Text = Binary.BinaryToString(System.Console.ReadLine());
                System.Console.WriteLine("Binary To String: " + Text);
            }
        }
    }
}