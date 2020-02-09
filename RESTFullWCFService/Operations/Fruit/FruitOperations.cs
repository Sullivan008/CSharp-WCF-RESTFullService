using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Hosting;

namespace RESTFullWCFService.Operations.Fruit
{
    public class FruitOperations
    {
        private readonly List<Models.Fruit> _fruits;

        public FruitOperations()
        {
            _fruits = FruitsInitialize();
        }

        public List<Models.Fruit> GetFruits() =>
            _fruits;

        #region PRIVATE Helper Methods

        private static List<Models.Fruit> FruitsInitialize()
        {
            List<Models.Fruit> result = new List<Models.Fruit>();

            string[] fruits = File.ReadAllText(
                HostingEnvironment.MapPath(@"~/App_Data/fruits.txt") ??
                    throw new InvalidOperationException("File not found. File name: \\fruits.txt\\"),
                Encoding.UTF8).Split(new[] { "\r\n" }, StringSplitOptions.None);

            for (int i = 1; i <= fruits.Length; i++)
            {
                result.Add(new Models.Fruit
                {
                    Id = i,
                    Name = fruits[i - 1],
                    Price = new Random(Convert.ToInt32(Regex.Match(Guid.NewGuid().ToString(), @"\d+").Value))
                        .Next(0, 300)
                });
            }

            return result;
        }

        #endregion
    }
}