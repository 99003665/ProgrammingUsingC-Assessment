using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    interface ITaxCompute
    {
        double TaxOnTotalBill();
    }
    public double TaxOnTotalBill(double finalprice)
    {
        double totalprice = finalprice;
        //for card
        double tax = finalprice * 0.33;
        totalprice = finalprice + tax;
        return totalprice;

    }
}
