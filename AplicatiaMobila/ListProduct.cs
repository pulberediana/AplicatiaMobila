using System;
using System.Collections.Generic;
using System.Text;
using AplicatiaMobila.Models;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace AplicatiaMobila
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(ShopList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }
    }
}
