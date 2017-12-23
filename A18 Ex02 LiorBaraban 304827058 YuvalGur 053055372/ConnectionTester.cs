using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace A18_Ex02_LiorBaraban_YuvalGur_BeSocial_Logic
{
    public static class ConnectionTester
    {
        public static bool TestConnection(string i_LinkUrl)
        {
            bool isValid = false;
            Uri uri = new Uri(i_LinkUrl);
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(uri.Host);
            if (pingReply.Status == IPStatus.Success)
            {
                isValid = true;
            }
            else
            {
                throw new Exception("Couldn't reach site");
            }

            return isValid;
        }
    }
}
