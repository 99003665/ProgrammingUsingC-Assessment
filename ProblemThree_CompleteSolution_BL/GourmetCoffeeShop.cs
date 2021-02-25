using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        public GourmetCoffeeShop(int icode,string iname,Dictionary<int,double>iPrice)
        {
            var CoffeePriceDict = new Dictionary<int, double>();
            int pieceprice = 100;
            public void PayPerPiece(int quantity)
            {
                if (quantity > 2)
                {
                    CoffeePriceDict = pieceprice * quantity;
                    return CoffeePriceDict;
                }


            }

        }
        public class Totalprice
        {
            public int Total(int quantity)
            {

                if (quantity > 20)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
        }

    }
}
