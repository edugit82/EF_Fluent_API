using EF_Fluent_API.Model.Mapping.Context;
using System;

namespace EF_Fluent_API
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            using (var SchoolEntities = new SchoolEntities()) 
            { 
               
            }
        }
    }
}
