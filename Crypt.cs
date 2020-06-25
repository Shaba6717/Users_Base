using System;


    public class Crypt
    {
        public static string crypt_str; //encrypted string

        private static ushort key = 0x0088; //encryption key

    public Crypt()
        {
           
        }
        
        //return encrypted string
        public string Decrypt(string in_str)
        {
            return crypt_str = encode_decrypt(in_str, key);
        }

    //function encrypts a string with a key
    private static string encode_decrypt(string in_str, ushort key)
    {
        var ch = in_str.ToCharArray();
        string newStr = "";
        foreach (var c in ch)
            newStr += top_secret(c, key);

        return newStr;
    }
        
    //use XOR with key
    private static char top_secret(char sym, ushort key) 
    {
        sym = (char)(sym ^ key);
        return sym;
    }
}

