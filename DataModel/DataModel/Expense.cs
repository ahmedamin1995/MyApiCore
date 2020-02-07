using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModel
{
   public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }

        public int UserId { get; set; }
        public  User User { get; set; }

        public bool IsDeleted { get; set; }
    }
}
