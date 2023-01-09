namespace BLLKrushiKart;
using BOLKrushiKart;
using DALKrushiKart;
public class CatlogManager{

    public  List<KrushiProduct> GetAllProducts(){

        List<KrushiProduct> allproductList=new List<KrushiProduct>();
        allproductList=DBManager.GetAllProductsList();
        return allproductList;

    }
    public KrushiProduct GetProduct(int id){

        List<KrushiProduct> lists=DBManager.GetAllProductsList();
        KrushiProduct foundItem=lists.Find((x)=>x.ProductId==id);
        return foundItem;
    }

}
