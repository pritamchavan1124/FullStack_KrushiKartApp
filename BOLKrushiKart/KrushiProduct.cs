namespace BOLKrushiKart;
public class KrushiProduct
{
    public int ProdId{set;get;}
    public string ProdTitle{set;get;}
    public string ProdCategory{set;get;}
    public string ProdDesc{set;get;}
    public double ProdPrice{set;get;}
    public int ProdQty{set;get;}

    public KrushiProduct()
    {

    }

    public KrushiProduct(string ProdTitle,string ProdCategory,
    string ProdDesc,double ProdPrice,int ProdQty)
    {
        this.ProdId=ProdId;
        this.ProdTitle=ProdTitle;
        this.ProdCategory=ProdCategory;
        this.ProdDesc=ProdDesc;
        this.ProdPrice=ProdPrice;
        this.ProdQty=ProdQty;
    }

    public override string ToString()
    {
        return string.Format("{0},{1},{2},{3},{4},{5}",ProdId,ProdTitle,ProdCategory,ProdDesc,ProdPrice,ProdQty);
    }

}
