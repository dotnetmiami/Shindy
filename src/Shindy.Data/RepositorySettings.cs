using System;
using System.Configuration;

namespace Shindy.Data
{
    internal class RepositorySettings
    {
        public readonly static string ConnectionString = ConfigurationManager.ConnectionStrings["Shindy.Data"].ToString();
    }
}
