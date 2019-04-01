using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Configuration;
using QBuildDesktop.BO;

namespace QBuildDesktop.DAL
{
    

    public class BomContext
    {
        
        public const string ITEMS_COLLECTION_NAME = "bom";
        public const string PARTS_COLLECTION_NAME = "part";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static BomContext()
        {
            var connectionString = Properties.Settings.Default.CONNECTION_STRING;
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(Properties.Settings.Default.DATABASE_NAME);
        }


        public IMongoClient Client
        {
            get { return _client; }
        }

        public IMongoCollection<Item> Items
        {
            get { return _database.GetCollection<Item>(ITEMS_COLLECTION_NAME); }
        }

        public IMongoCollection<Part> Parts
        {
            get { return _database.GetCollection<Part>(PARTS_COLLECTION_NAME); }
        }


    }
}
