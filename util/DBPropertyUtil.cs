
using System.IO;

namespace OrderManagementSystem.util
{
    public static class DBPropertyUtil
    {
        public static string GetConnectionString(string propertyFileName)
        {
            string propertyFilePath = Path.Combine(Directory.GetCurrentDirectory(), propertyFileName);

            if (File.Exists(propertyFilePath))
            {
                return File.ReadAllText(propertyFilePath);
            }
            else
            {
                throw new FileNotFoundException($"Property file '{propertyFileName}' not found.");
            }
        }
    }
}
