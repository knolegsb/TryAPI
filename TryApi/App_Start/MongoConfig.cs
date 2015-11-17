using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryApi.Models;

namespace TryApi.App_Start
{
    public class MongoConfig
    {
        public static void Seed()
        {
            var patients = PatientDb.Open();
        }
    }
}