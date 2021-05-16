using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Task1.Infrastructure
{
    public class CountUsersAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            StreamReader srtr = new StreamReader("App_Data/log.txt");
            List<string> listOfUsers = new List<string>();
            string line;
            while ((line = srtr.ReadLine()) != null)
                listOfUsers.Add(line);
            srtr.Close();    

            string userAgent = context.HttpContext.Request.Headers["User-Agent"];
            if (!listOfUsers.Contains(userAgent))
            {
                listOfUsers.Add(userAgent);
                StreamWriter strw = new StreamWriter("App_Data/log.txt", true);
                strw.WriteLine(userAgent);
                strw.Close();
            }
                

            
            
        }
    }
}
