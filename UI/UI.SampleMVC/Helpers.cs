using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.SampleMVC
{
    public static class Helpers
    {
        public static int? GetUserID()
        {
            var userInfo = HttpContext.Current.Request.Cookies["User"].Values;  //这个地方耦合度高,可以放到UI层然后通过调用对象的方式降低耦合度
            if (userInfo == null)
            {
                return null;
            }

            int userInfoID = Convert.ToInt32(userInfo["ID"]);
            string userInfoPassword = (userInfo["Password"]).ToString();

            int ID = SRV.ProdServices.Helpers.GetUserId(userInfoID, userInfoPassword);
            return ID;

        }
    }
}