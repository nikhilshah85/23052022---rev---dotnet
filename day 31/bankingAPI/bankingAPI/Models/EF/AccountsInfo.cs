using System;
using System.Collections.Generic;

namespace bankingAPI.Models.EF
{
    public partial class AccountsInfo
    {
        public AccountsInfo()
        {
            TransactioninfoTrFromAccountNavigations = new HashSet<Transactioninfo>();
            TransactioninfoTrToAccountNavigations = new HashSet<Transactioninfo>();
        }

        public int AccNo { get; set; }
        public string? AccName { get; set; }
        public string? AccType { get; set; }
        public int? AccBalance { get; set; }
        public int? AccBranch { get; set; }

        public virtual BranchInfo? AccBranchNavigation { get; set; }
        public virtual ICollection<Transactioninfo> TransactioninfoTrFromAccountNavigations { get; set; }
        public virtual ICollection<Transactioninfo> TransactioninfoTrToAccountNavigations { get; set; }
    }
}
