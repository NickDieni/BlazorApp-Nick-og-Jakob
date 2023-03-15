using Microsoft.SqlServer.Server;
using System.Data.SqlClient;

namespace BlazorApp.Data
{
    
    public class Memes
    {
        public int Id { get; set; }
        public string MemeName { get; set; }
        public string Url { get; set; }
    }
}
