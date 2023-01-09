namespace DALKrushiKart;
using BOLKrushiKart;

public class DBManager
{
    public static List<KrushiProduct> GetAllProductsList()
    {
        List<KrushiProduct> productList = new List<KrushiProduct>();

        productList.Add(new KrushiProduct{ProductId=101,ProductTitle="Tomato Seed",ProductCategory="Seeds",ProductDescription="Hybrid red tomato seeds",ProductPrice=1200,ProductQty=143});
        productList.Add(new KrushiProduct{ProductId=102,ProductTitle="Ankur Bhendi Seed",ProductCategory="Seeds",ProductDescription="Hybrid bhendi seeds",ProductPrice=950,ProductQty=106});
        productList.Add(new KrushiProduct{ProductId=103,ProductTitle="Grapes Seed",ProductCategory="Seeds",ProductDescription="Hybrid Black grapes seeds",ProductPrice=730,ProductQty=153});
        productList.Add(new KrushiProduct{ProductId=104,ProductTitle="Shine Carrot  Seed",ProductCategory="Seeds",ProductDescription="Hybrid Carrot seeds",ProductPrice=1630,ProductQty=126});
        productList.Add(new KrushiProduct{ProductId=105,ProductTitle="Pomigrade Seed",ProductCategory="Seeds",ProductDescription="Hybrid pomigrades seeds",ProductPrice=1800,ProductQty=93});
    
        return productList;
    }
    public static KrushiProduct GetProductByID(int id){
        List<KrushiProduct> products=GetAllProductsList();

        //var productItem=from prod in product where prod.ProductId ==id select prod;
        KrushiProduct product=new KrushiProduct{ProductId=101,ProductTitle="Tomato Seed",ProductCategory="Seeds",
                                ProductDescription="Hybrid red tomato seeds",ProductPrice=1200,ProductQty=143

        };
        return product;
    }
}
