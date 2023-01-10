namespace DALKrushiKart;
using BOLKrushiKart;

public class DBManager
{
    public static List<KrushiProduct> GetAllProductsList()
    {
        List<KrushiProduct> productList = new List<KrushiProduct>();

        productList.Add(new KrushiProduct{ProdTitle="Tomato Seed",ProdCategory="Seeds",ProdDesc="Hybrid red tomato seeds",ProdPrice=1200,ProdQty=143});
        productList.Add(new KrushiProduct{ProdTitle="Ankur Bhendi Seed",ProdCategory="Seeds",ProdDesc="Hybrid bhendi seeds",ProdPrice=950,ProdQty=106});
        productList.Add(new KrushiProduct{ProdTitle="Grapes Seed",ProdCategory="Seeds",ProdDesc="Hybrid Black grapes seeds",ProdPrice=730,ProdQty=153});
        productList.Add(new KrushiProduct{ProdTitle="Shine Carrot  Seed",ProdCategory="Seeds",ProdDesc="Hybrid Carrot seeds",ProdPrice=1630,ProdQty=126});
        productList.Add(new KrushiProduct{ProdTitle="Pomigrade Seed",ProdCategory="Seeds",ProdDesc="Hybrid pomigrades seeds",ProdPrice=1800,ProdQty=93});
    
        return productList;
    }
    public static KrushiProduct GetProductByID(int id){
        List<KrushiProduct> products=GetAllProductsList();

        //var productItem=from prod in product where prod.ProductId ==id select prod;
        KrushiProduct product=new KrushiProduct{ProdTitle="Tomato Seed",ProdCategory="Seeds",
                                ProdDesc="Hybrid red tomato seeds",ProdPrice=1200,ProdQty=143

        };
        return product;
    }

    
}
