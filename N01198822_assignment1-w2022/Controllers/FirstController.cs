using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01198822_assignment1_w2022.Controllers
{
    public class FirstController : ApiController
    // Q1
    // GET api/first
    // <summary>
    // I want to get the following values 31,10 and 1
    // You can achieve this by adding 21/ 0 and -9 to the browser
    // </summary>
    //<param>name = "id"> the input number to add </param>
    // returns the input number plus 10
    {
        public int Get(int id)
        {
            int product = id + 10;
            return product;
        }
      // Q2
      //
    public static void Main()
        {
            int num = 2;
            int productA = Square(num);
        }
        
      
      // Q3
      //POST api/first
      // <summary>
      // Can only see example on the command prompt
      // </summary>
    public string Post()
        {
            return "Hello World!";
        }
      // Q4
      // I was unsure how to do this question. I thought that maybe I should make variables,
      // and when the integer 3.6 and 0 were entered they would be greeted by the correct message,
      // unfourtunately I could not figure it out.
    public string Get()
        {
            return "Greetings 3 people!";
            return "Greetings 6 people";
            return "Greetings 0 people!";
       
        }
        // Q5
        ///<summary>
        ///Inputs a message and relays the message
        ///</summary>
        ///<returns></returns>
        ///This i what i wanted to do with my equation but i still was unable to figure it out.
    }
    public int Get1
}
