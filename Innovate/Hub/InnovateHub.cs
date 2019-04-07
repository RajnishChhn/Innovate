using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Innovate.Hub
{
    public class InnovateHub : Hub
    {
        //notify the web client that user has sent response via sms
        public async Task SendUserResponse(int assignedUserId, int initiatingUserId, int loadId, int? originallyAssignedUserId)
        {
            try
            {
                //var message = string.Format();
                await Clients.All.getUserResponse(empId, status);// getUserResponse - client side method to be invoked
            }
            catch (SystemException exception)
            {
                _log.Error(exception);
                throw;
            }
        }
    }
}