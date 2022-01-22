using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Eitaa.dll
{
    public class Bot
    {
        WebClient REQ = new WebClient();
        string MainURL;

        public string GetToken(string Token)//Token
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            return MainURL = "https://eitaayar.ir/api/" + Token;
        }

        public string sendMessage(string ChatID, string MassegeText)//sendMessage
        {
            return REQ.DownloadString(MainURL + "/sendMessage?chat_id=" + ChatID + "&text=" + MassegeText);
        }

        public string sendDocument(string ChatID, string FileID)//sendDocument
        {
            return REQ.DownloadString(MainURL + "/sendDocument?chat_id=" + ChatID + "&file=" + FileID);
        }

        public string getMe()//getMe
        {
            return REQ.DownloadString(MainURL + "/getMe");
        }
    }

    
}
