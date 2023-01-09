namespace BOLKrushiKart;
public class KrushiProduct
{
    public int ProductId{set;get;}
    public string ProductTitle{set;get;}
    public string ProductCategory{set;get;}
    public string ProductDescription{set;get;}
    public double ProductPrice{set;get;}
    public int ProductQty{set;get;}

    public KrushiProduct()
    {

    }

    public KrushiProduct(int ProductId,string ProductTitle,string ProductCategory,
    string ProductDescription,double ProductPrice,int ProductQty)
    {
        this.ProductId=ProductId;
        this.ProductTitle=ProductTitle;
        this.ProductCategory=ProductCategory;
        this.ProductDescription=ProductDescription;
        this.ProductPrice=ProductPrice;
        this.ProductQty=ProductQty;
    }

    public override string ToString()
    {
        return string.Format("{0},{1},{2},{3},{4},{5}",ProductId,ProductTitle,ProductCategory,ProductDescription,ProductPrice,ProductQty);
    }

}
