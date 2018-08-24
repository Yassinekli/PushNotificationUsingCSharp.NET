using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Push_Notification.Models;

namespace Push_Notification.Models
{
    public class DatabaseService
    {
        static Test_Push_Notification_DBEntities database = new Test_Push_Notification_DBEntities();

        static public void NewSubscriber(SubscribersSet newSubscriber) {
            database.SubscribersSet.Add(newSubscriber);
            database.SaveChanges();
        }

        static public List<SubscribersSet> GetSubscribers() {
            return database.SubscribersSet.ToList();
        }
    }
}