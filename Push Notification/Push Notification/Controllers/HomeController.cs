using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Push_Notification.Models;
using WebPush;

namespace Push_Notification.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public void AddNewSubscriber(SubscribersSet newSubscriber)
        {
            DatabaseService.NewSubscriber(newSubscriber);
        }

        public void PushNotification() {
            VapidDetails vapidDetails = new VapidDetails("mailto:klilichyassine8@gmail.com", "BMl6hADzk-Je4guA6a5k7FwDSW_VpXYUgEaaP0xvZI6iuOT8HxyesmMiPF0G7wHnk6Cij1-gS4MYWEBO181X8zI", "cLwbe_BjpADid1pzNrvHv5lt_YB1sk5nwT_PhBB6R48");

            WebPushClient webPushClient = new WebPushClient();
            try {
                foreach (SubscribersSet subscriber in DatabaseService.GetSubscribers())
                {
                    PushSubscription subscription = new PushSubscription(subscriber.endPoint, subscriber.p256dh, subscriber.auth);
                    webPushClient.SendNotification(subscription, "New Notification !", vapidDetails);
                }
            }catch(WebPushException) {
                // Error
            }
        }
    }
}