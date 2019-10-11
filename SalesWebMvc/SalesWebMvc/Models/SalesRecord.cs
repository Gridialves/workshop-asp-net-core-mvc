﻿using SalesWebMvc.Models.Enums;
using System;


namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amout { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amout, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amout = amout;
            Status = status;
            Seller = seller;
        }
    }
}
