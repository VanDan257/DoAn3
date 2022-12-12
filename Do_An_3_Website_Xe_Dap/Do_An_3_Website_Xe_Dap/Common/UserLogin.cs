using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Do_An_3_Website_Xe_Dap
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { set; get; }
        public string UserName { set; get; }
    }
}