using AccountHw.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountHw.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Account(AccountViewModel x)
        {
            List<AccountViewModel> list = new List<AccountViewModel>();


            Random ram = new Random();

            for (int ii = 1; ii< 201; ii++)
            {
                var money = ram.Next(1001);
                var category = ram.Next(2);
                string i = "";
                if (category == 1)
                { i = "支出"; }
                else
                { i = "收入"; }

                Random Counter = new Random(Guid.NewGuid().GetHashCode());
                var yy = Counter.Next(100);
                DateTime dt = DateTime.Now.AddDays(yy);
                list.Add(new AccountViewModel {Water=ii ,Category = i, Date = dt, Money = money });
            }
           
            return View(list);



        }


    }
}