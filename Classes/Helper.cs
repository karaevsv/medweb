using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmTest.Classes
{
    public static class Helper
    {
        public static bool IsAuthorized
        {
            get
            {
                return AuthorizedUser != null;
            }
        }
        public static User AuthorizedUser = null;
    }
}