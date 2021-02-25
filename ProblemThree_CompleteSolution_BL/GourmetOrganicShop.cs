using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {

        var organicPriceDict = new Dictionary<int, double>();

        int pieceprice = 100;
        public void PayPerPiece(int quantity)
        {
            if (quantity > 2)
            {
                organicPriceDict = pieceprice * quantity;
                return organicPriceDict;
            }


        }

        public void additems()
        {

            oitems[] obj = new oitems[20];
            //for electronics
            for (int i = 0; i < 20; i++)
            {

                itemobj[0] = new oitems(1, 70);
                itemobj[1] = new oitems(2, 100);
                

               oitems.Add(itemobj[i]);

            }






        }
    }
}
