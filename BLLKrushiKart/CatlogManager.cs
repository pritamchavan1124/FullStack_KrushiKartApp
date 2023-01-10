namespace BLLKrushiKart;
using BOLKrushiKart;
//using DALKrushiKart;
using DAL.Connected;
public class CatlogManager{

    // public  List<KrushiProduct> GetAllProducts(){

    //     List<KrushiProduct> allproductList=new List<KrushiProduct>();
    //     allproductList=DBManager.GetAllProductsList();
    //     return allproductList;

    // }
    // public KrushiProduct GetProduct(int id){

    //     List<KrushiProduct> lists=DBManager.GetAllProductsList();
    //     KrushiProduct foundItem=lists.Find((x)=>x.ProdId==id);
    //     return foundItem;
    // }

    public List<KrushiProduct> GetAllProducts(){

        List<KrushiProduct> allproductList=new List<KrushiProduct>();
        allproductList=DBManager.GetAllProducts();
        return allproductList;
    }

}
