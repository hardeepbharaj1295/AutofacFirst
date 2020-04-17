using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {

            _logger.Log("Starting the process of data");
            Console.WriteLine("Processing the Data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed Info");
            _logger.Log("Finished Processing of Data");
        }
    }
}
