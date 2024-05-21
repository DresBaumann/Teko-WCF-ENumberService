using System.ServiceModel;

namespace ENumberService.Services
{
	[ServiceContract]
	public interface IEvaluationService
	{
		[OperationContract]
		string EvaluateQueryResult(string queryResult);
	}
}