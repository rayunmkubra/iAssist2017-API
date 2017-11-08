using System;

namespace iAssistAPI.Models
{
    /// <summary>
    /// Bills model
    /// </summary>
    public class Bills
    {
        public string AcctNo { get; set; }

        public string InvoiceNo { get; set; }

        public string DueDate { get; set; }

        public Decimal Amt { get; set; }

        public string CompanyName { get; set; }

        public string Status { get; set; }
    }
}