using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using THL.DAL.Context;
using THL.DAL.Entities;

namespace Solita_Test_Exercise.Services
{
    public class DataService
    {
        private readonly VaccineContext _db;

        public DataService(VaccineContext context)
        {
            _db = context;
        }

        internal int TotalOrders()
        {
            int data = _db.VaccineOrders.Count();

            return data;
        }

        internal int TotalVaccinesCame()
        {
            int data = _db.VaccineOrders.Select(v => v.Injections).Sum();

            return data;
        }

        internal int TotalVaccinationsNumber()
        {
            int data = _db.Vaccines.Count();

            return data;
        }

        internal List<VaccineOrder> ArrivedInMonth()//Method shows how much vaccines arrived in last 30 days.
        {
            DateTime todayDate = new DateTime(2021, 04, 12);//In real app we can write DateTime.Now and we will get method that counts from todays date.

            DateTime monthAgo = todayDate.AddDays(-30);

            var data = _db.VaccineOrders.OrderByDescending(v => v.Arrived.Date)
                .Where(v => v.Arrived.Date <= todayDate && v.Arrived.Date >= monthAgo)
                .ToList();

            return data;
        }

        internal Dictionary<string, int> VaccineProducers()// Method showing how much vaccines came from different companies.
        {

            int antiquaQuantity = _db.VaccineOrders.Where(v => v.Vaccine == "Antiqua").Count();

            int solarBuddhicaQuantity = _db.VaccineOrders.Where(v => v.Vaccine == "SolarBuddhica").Count();

            int zerpfyQuantity = _db.VaccineOrders.Where(v => v.Vaccine == "Zerpfy").Count();

            var dict = new Dictionary<string, int>
            {
                {"Antiqua", antiquaQuantity },
                {"SolarBudhhica", solarBuddhicaQuantity },
                {"Zerpfy", zerpfyQuantity }
            };

            return dict;
        }

        internal int ExpireToday()//Method showing how much vaccines will expire today.
        {
            DateTime todayDate = new DateTime(2021, 04, 12);//In real app we can write DateTime.Now and we will get method that counts from todays date.

            DateTime expireDate = todayDate.AddDays(-30);

            var vaccinesDone = _db.Vaccines.Select(v => v.SourceBottle);

            var expiredVaccines = _db.VaccineOrders.Where(v => v.Arrived.Date == expireDate && v.Id != vaccinesDone.ToString())
                .Count();

            return expiredVaccines;
        }

        internal List<VaccineOrder> ExpireTodayList()//returning the list of the expiring vaccines.
        {
            DateTime todayDate = new DateTime(2021, 04, 12);//In real app we can write DateTime.Now and we will get method that counts from todays date.

            DateTime expireDate = todayDate.AddDays(-30);

            var vaccinesDone = _db.Vaccines.Select(v => v.SourceBottle);

            var expiredVaccinesList = _db.VaccineOrders.Where(v => v.Arrived.Date == expireDate && v.Id != vaccinesDone.ToString())
                .ToList();

            return expiredVaccinesList;    
        }

        internal int ExpireSoon()//Returns number of vaccines that will expire after 10 days.
        {
            DateTime todayDate = new DateTime(2021, 04, 12);//In real app we can write DateTime.Now and we will get method that counts from todays date.

            DateTime arrivedDate = todayDate.AddDays(-20);

            var vaccinesUsed = _db.Vaccines.Select(v => v.SourceBottle);

            var vaccinesLeft = _db.VaccineOrders.Where(v => v.Arrived.Date == arrivedDate && v.Id != vaccinesUsed.ToString())
                .Count();

            return vaccinesLeft;
        }

        internal List<VaccineOrder> ExpireSoonList()//Returns list of vaccines that will expire after 10 days.
        {
            DateTime todayDate = new DateTime(2021, 04, 12);//In real app we can write DateTime.Now and we will get method that counts from todays date.

            DateTime arrivedDate = todayDate.AddDays(-20);

            var vaccinesUsed = _db.Vaccines.Select(v => v.SourceBottle);

            var vaccinesLeft = _db.VaccineOrders.Where(v => v.Arrived.Date == arrivedDate && v.Id != vaccinesUsed.ToString())
                .ToList();

            return vaccinesLeft;
        }

        internal int LeftToUse()//Method shows how much vaccines are left to use from "today" date.
        {
            DateTime todayDate = new DateTime(2021, 04, 12);//In real app we can write DateTime.Now and we will get method that counts from todays date.

            DateTime arrivedDate = todayDate.AddDays(-29);

            var usedVaccines = _db.Vaccines.Select(v => v.SourceBottle);

            var leftToUse = _db.VaccineOrders.Where(v => v.Arrived.Date > arrivedDate && v.Id != usedVaccines.ToString())
                .Count();

            return leftToUse;
        }

        internal List<VaccineOrder> LeftToUseList()//Method shows how much vaccines are left to use from "today" date.
        {
            DateTime todayDate = new DateTime(2021, 04, 12);//In real app we can write DateTime.Now and we will get method that counts from todays date.

            DateTime arrivedDate = todayDate.AddDays(-29);

            var usedVaccines = _db.Vaccines.Select(v => v.SourceBottle);

            var leftToUse = _db.VaccineOrders.Where(v => v.Arrived.Date > arrivedDate && v.Id != usedVaccines.ToString())
                .ToList();

            return leftToUse;
        }
    }
}
