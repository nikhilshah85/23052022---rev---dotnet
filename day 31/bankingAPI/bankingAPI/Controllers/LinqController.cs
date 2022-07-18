using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using bankingAPI.Models.EF;
using System.Linq;
namespace bankingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqController : ControllerBase
    {
        bankingLINQContext db = new bankingLINQContext();

        [HttpGet]
        [Route("accounts")]
        public IActionResult GetAccounts()
        {
            //we want to get all the accounts from accountsinfo table

            //select * from Accountsinfo --- sql query
            //var acc = from a in db.AccountsInfos
            //          select a;


            #region where and order by 
            //var acc = from a in db.AccountsInfos
            //          where a.AccType == "Savings"
            //          orderby a.AccBalance
            //          select a;
            #endregion

            #region select only limited columns
            //var acc = from a in db.AccountsInfos
            //          select new
            //          {
            //              Number = a.AccNo,
            //              Name = a.AccName,
            //              Balance = a.AccBalance,
            //              Bonus = a.AccBalance * 0.1
            //          };
            #endregion

            //lambda expression, this are nothing by short hand linq

            //   var minBalance = db.AccountsInfos.Min(ab => ab.AccBalance);
            //   var maxBalance = db.AccountsInfos.Max(ab => ab.AccBalance);
            //  var countAccounts = db.AccountsInfos.Count(ab => ab.AccNo);

            #region single Account
            //var myAcc = (from a in db.AccountsInfos
            //            where a.AccNo == 2
            //            select a).Single();
            #endregion

            #region Join

            //var myAcc = from a in db.AccountsInfos
            //            join b in db.BranchInfos on
            //             a.AccBranch equals b.BranchId
            //            select new
            //            {
            //                AccountNo = a.AccNo,
            //                Name = a.AccName,
            //                Type = a.AccType,
            //                Balance = a.AccBalance,
            //                BranchName = b.BranchName,
            //                City = b.BranchCity,
            //                BranchId = b.BranchId,
            //                Email = b.BranchEmail
            //            };
            #endregion


            var nikhil = from a in db.AccountsInfos
                         join b in db.BranchInfos
                         on a.AccBranch equals b.BranchId
                         join c in db.Transactioninfos
                         on a.AccNo equals c.TrFromAccount
                         where a.AccNo == 1
                         select new
                         {
                             FromAccountNo = a.AccNo,
                             ToAccountNo = c.TrToAccount,
                             Transaction = c.TrType,
                             Amount = c.TrAmount,
                             City = b.BranchCity
                         };


            return Ok(nikhil);
        }

    }
}
