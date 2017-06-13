using MongoDB.Bson;
namespace wishlist.dataaccess
{
 public class WishListModel
{

    public ObjectId _id { get; set; }
    public int unique_Id { get; set; }
    public string tag { get; set; }
    public string wish { get; set; }

}
}
