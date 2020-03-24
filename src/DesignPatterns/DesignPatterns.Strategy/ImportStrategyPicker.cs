using DesignPatterns.Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public static class ImportStrategyPicker
    {
        public static IImportStrategy Select(string fileType)
        {
            if (fileType == ".csv")
            {
                return new CsvStrategy();
            }
            else if (fileType == ".json")
            {
                return new JsonStrategy();
            }

            throw new ApplicationException("No strategy found for file type: " + fileType);
        }
    }
}
