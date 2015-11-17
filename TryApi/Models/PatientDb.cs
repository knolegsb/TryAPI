﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace TryApi.Models
{
    public static class PatientDb
    {
        public static MongoCollection<PatientData> Open()
        {
            var client = new MongoClient("mongodb://localhost");
            var server = client.GetServer();
            var db = server.GetDatabase("PatientDb");
            return db.GetCollection<PatientData>("Patients");
        }
    }
}