using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
    public int Itemid=0;
    public String ItemName = null;
    
    public int price = 0;

    public GourmetShop(int Itemid, String ItemName, int price)
    {
        this.Itemid = Itemid;
        this.ItemName = ItemName;
        this.price = price;
       
    }

    public static List<Gourmett> Mainitems { get; set; } = new List<GourmetShop>();

}
