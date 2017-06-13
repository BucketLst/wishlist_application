using System;
using System.Collections.Generic;
using wishlist.dataaccess;
using Newtonsoft.Json;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {            
            WishlistRepository obj = new WishlistRepository();
            List<WishListModel> result = obj.SelectAll();
            foreach (WishListModel item in result){
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }
            
        }
    }
}
