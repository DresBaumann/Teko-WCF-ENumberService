using System.ServiceModel;

namespace ENumberService.Services
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EvaluationService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select EvaluationService.svc or EvaluationService.svc.cs at the Solution Explorer and start debugging.
	public class EvaluationService : IEvaluationService
	{
		public string EvaluateQueryResult(string queryResult)
		{
			// Simple evaluation logic, modify as needed
			return queryResult != "Unknown E-Number" ? $"Valid substance: {queryResult}" : "Invalid E-Number";
		}
	}
}
