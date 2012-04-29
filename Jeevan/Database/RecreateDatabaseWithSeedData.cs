using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Jeevan.Models;

namespace Jeevan.Database
{
    public class RecreateDatabaseWithSeedData : DropCreateDatabaseAlways<Jeevan.Database.DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.CordBloodUnits.Add(new CordBloodUnit() { HLA_A1 = 2, HLA_A2 = 24, HLA_B1 = 18, HLA_B2 = 40, HLA_C1 = 12, HLA_C2 = 15, DRB_1 = 11, DRB_2 = 14, DQB_1 = 03, DQB_2 = 05 });
            context.CordBloodUnits.Add(new CordBloodUnit(){HLA_A1=1, HLA_A2=32, HLA_B1=15, HLA_B2= 57, HLA_C1 = 6 , HLA_C2 = 07, DRB_1 = 15, DRB_2 = 16 , DQB_1 = 05, DQB_2 = 05});
            context.CordBloodUnits.Add(new CordBloodUnit(){HLA_A1=24, HLA_A2=33, HLA_B1=40, HLA_B2= 44, HLA_C1 = 1 , HLA_C2 = 07, DRB_1 = 01, DRB_2 = 07 , DQB_1 = 02, DQB_2 = 05});
            context.CordBloodUnits.Add(new CordBloodUnit(){HLA_A1=1, HLA_A2=33, HLA_B1=15, HLA_B2= 44, HLA_C1 = 3 , HLA_C2 = 07, DRB_1 = 07, DRB_2 = 13 , DQB_1 = 02, DQB_2 = 06});
            context.CordBloodUnits.Add(new CordBloodUnit(){HLA_A1=3, HLA_A2=68, HLA_B1=15, HLA_B2= 55, HLA_C1 = 1 , HLA_C2 = 04, DRB_1 = 13, DRB_2 = 15 , DQB_1 = 06, DQB_2 = 06});
            context.CordBloodUnits.Add(new CordBloodUnit() { HLA_A1 = 1, HLA_A2 = 33, HLA_B1 = 15, HLA_B2 = 37, HLA_C1 = 4, HLA_C2 = 06, DRB_1 = 10, DRB_2 = 15, DQB_1 = 05, DQB_2 = 05 });

            base.Seed(context);
        }
    }
}