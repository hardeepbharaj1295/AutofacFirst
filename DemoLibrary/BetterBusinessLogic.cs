using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class BetterBusinessLogic: IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {

            _logger.Log("Starting the process of data");
            Console.WriteLine();
            Console.WriteLine("Processing the Data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed Info");
            Console.WriteLine();
            _logger.Log("Finished Processing of Data");
        }
    }
}
