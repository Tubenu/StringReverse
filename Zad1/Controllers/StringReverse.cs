using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Zad1.Controllers
{
    public class StringReverseController : ApiController
    {
        [Route("api/StringReverse/{paramOne}")]
        public string Get(string paramOne)
        {
            char[] charArray = paramOne.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
    }
}
