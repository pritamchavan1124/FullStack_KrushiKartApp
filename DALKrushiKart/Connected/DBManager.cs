namespace DAL.Connected;
using BOLKrushiKart;
using MySql.Data.MySqlClient;

public class DBManager{
    public static string conPool=@"server=localhost;
                            port=3306;
                            user=root;
                            password=root123;
                            database=krushiShop";

    public  static List<KrushiProduct> GetAllProducts(){
        List<KrushiProduct> allproducts=new List<KrushiProduct>();
         MySqlConnection connect=new MySqlConnection();
         connect.ConnectionString=conPool;

         try{
            connect.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=connect;
            string query="SELECT * FROM products";
                cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();


                while(reader.Read()){
                    int id = int.Parse(reader["ProdId"].ToString());
                    string ProdTitle = reader["ProdTitle"].ToString();
                    string ProdCategory = reader["ProdCategory"].ToString();
                    string ProdDescription=reader["ProdDesc"].ToString();
                    double ProductPrice=double.Parse(reader["ProdPrice"].ToString());
                    int ProductQuantity=int.Parse(reader["ProdQty"].ToString());

                   KrushiProduct prod=new KrushiProduct{ProdId=id,ProdTitle=ProdTitle,ProdCategory=ProdCategory,
                                                        ProdDesc=ProdDescription,ProdPrice=ProductPrice,ProdQty=ProductQuantity};
                allproducts.Add(prod);

         }
    }catch(Exception e){
            Console.WriteLine(e.Message);
         }finally{
            connect.Close();
         }
         return allproducts;

}
}
