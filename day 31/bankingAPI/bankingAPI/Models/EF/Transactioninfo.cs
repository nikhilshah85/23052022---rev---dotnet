using System;
using System.Collections.Generic;

namespace bankingAPI.Models.EF
{
    public partial class Transactioninfo
    {
        public int TrNo { get; set; }
        public int? TrFromAccount { get; set; }
        public int? TrToAccount { get; set; }
        public int? TrAmount { get; set; }
        public string? TrType { get; set; }

        public virtual AccountsInfo? TrFromAccountNavigation { get; set; }
        public virtual AccountsInfo? TrToAccountNavigation { get; set; }
    }
}
