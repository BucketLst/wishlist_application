using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;

namespace wishlist.dataaccess
{
    public class WishlistRepository
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        protected IMongoCollection<WishListModel> _collection;

        public WishlistRepository(){
            _client = new MongoClient();
            _database = _client.GetDatabase("wishlistDB");
            _collection = _database.GetCollection<WishListModel>("wishlistData");
        }
        public string Test(){
            return "working";
        }
        public List<WishListModel> SelectAll()
        {
            var query = this._collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }
    }
}
