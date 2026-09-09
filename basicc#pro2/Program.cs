using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace basicc_pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine("Original title: " + title);
            //Console.WriteLine("Uppercase title: " + upperTitle);

            #endregion

            #region question 2
            ////Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            //string str1 = "Clean Code";
            //string str2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(str1, str2));
            //// The output will be True , both str1 and str2 point to the same object in memory.
            #endregion

            #region question 3
            ////Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            //StringBuilder bookList = new StringBuilder();
            //bookList.Append("Book List");
            //bookList.Append(" - Updated");
            //Console.WriteLine(bookList);

            #endregion

            #region question 4
            ////Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".Print the result.
            //StringBuilder bookList = new StringBuilder();
            //bookList.Append("Book List");
            //bookList.Append(" - Updated");
            //bookList.Replace("Book List", "Library");
            //Console.WriteLine(bookList);
            #endregion

            #region question 5
            ////Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator. 
            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(sentence);
            ////تتحول pages تلقائيًا إلى string أثناء عملية الـconcatenation.
            #endregion

            #region question 6
            //// Build the same sentence as above, but using string interpolation ($"..."). 
            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = $"Book: {title}, Pages: {pages}";
            //Console.WriteLine(sentence);
            #endregion

            #region question 7
            ////Build the same sentence again, but using string.Format(). 

            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(sentence);
            #endregion

            #region question 8
            ////Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".
            //int pages = 464;
            //if(pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion
        }
    }
}
