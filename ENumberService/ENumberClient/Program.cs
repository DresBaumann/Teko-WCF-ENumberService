using System;
using ENumberClient.ENIdentificationServiceRef;
using ENumberClient.EvaluationServiceRef;
using ENumberClient.QueryServiceRef;

namespace ENumberClient
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter E-Number:");
			string eNumber = Console.ReadLine();

			var enIdentificationClient = new ENIdentificationServiceClient();
			var queryServiceClient = new QueryServiceClient();
			var evaluationServiceClient = new EvaluationServiceClient();

			bool isValidENumber = enIdentificationClient.VerifyENumber(eNumber);
			if (isValidENumber)
			{
				string queryResult = queryServiceClient.QueryENumber(eNumber);
				string evaluationResult = evaluationServiceClient.EvaluateQueryResult(queryResult);
				Console.WriteLine(evaluationResult);
			}
			else
			{
				Console.WriteLine("Invalid E-Number format.");
			}

			Console.ReadKey();
			enIdentificationClient.Close();
			queryServiceClient.Close();
			evaluationServiceClient.Close();
		}
	}
}