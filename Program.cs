using System;

namespace CSharpStringFunctions
{
    class Program
    {

        static void Main(string[] args)
        {

            string testerString = "This is my some strange string";
            string second = "Here is the second string";
            string[] arrayString = { "een", "twee", "drie", "vier", "vyf" };
            string joinedOne;

            Console.WriteLine("Length of string : {0}", testerString.Length);
            Console.WriteLine("Character at position testerString[5]: {0}", testerString[5]);
            foreach (char karakter in testerString)
            {
                Console.WriteLine("Character in string: {0}", karakter);
                if (karakter == 'i')
                {
                    break;
                }
            }

            joinedOne = String.Concat(arrayString);
            Console.WriteLine(joinedOne);

            // Joining string with String.join
            joinedOne = String.Join(".", arrayString);
            Console.WriteLine("Joined One: {0}", joinedOne);

            joinedOne = String.Join("----", arrayString);
            Console.WriteLine("Joined One: {0}", joinedOne);

            //String comparisons
            /*
              String.Compare
              < 0 : String 1 comes before String 2 in a sort order
              = 0 : String 1 and String 2 are equal in sort order
              > 0 : String 1 comes after String 2 in sort order
            */
            Console.WriteLine("String 1 before String 2 :{0}", String.Compare("ABC", "XYZ"));
            Console.WriteLine("String 1 is equal to String 2 : {0}", String.Compare("abc", "abc"));
            Console.WriteLine("String 1 comes after String 2 : {0}", String.Compare("XYZ", "ABC"));

            // String comparison with String.Equal
            Console.WriteLine("Strings 'abcd' and 'abcd' are equal {0}", String.Equals("abcd", "abcd"));
            Console.WriteLine("Strings 'abcd' and 'ABCD' are not equal {0}", String.Equals("abcd", "ABCD"));

            Console.WriteLine("Index of 'e' : {0}", testerString.IndexOf('e'));
            Console.WriteLine("Index of 'some' : {0}", testerString.IndexOf("some"));

            String outString = testerString.Replace("some", "fox");
            Console.WriteLine("Tester string replacing 'some' with fox' : {0}", outString);

        }//end Main
    }

}