using StateCensusAnalyzer.DTO;
using StateCensusAnalyzer.UsingCode;
using System;

namespace StateCensusAnalyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to IndianStatesCensusAnalyser ");
            string filePathStateCensus = @"E:\ashproject\IndianStateCensusAnalyzer\StateCensusAnalyzer\DTO\StateCensus.csv";
            string filePath = @"E:\ashproject\IndianStateCensusAnalyzer\StateCensusAnalyzer\UsingCode\StateCode.csv";

            StateCensusAnalyser analyzer = new StateCensusAnalyser();
            int StateCensusRecords = analyzer.ReadStateCensusData(filePathStateCensus);
            CSVStateCensus census = new CSVStateCensus();
            int censusRecords = census.ReadStateCensusData(filePathStateCensus);
            if (StateCensusRecords == censusRecords)
                Console.WriteLine("Number of records match");

            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            int StateCodeRecords = stateCodeAnalyzer.ReadStateCodeData(filePath);
            CSVStateCensus stateCode = new CSVStateCensus();
            int codeRecords = stateCode.ReadStateCodeData(filePath);
            if (StateCodeRecords == codeRecords)
                Console.WriteLine("Number of records match");
        }
    }
}
