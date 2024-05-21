using System.ServiceModel;

namespace ENumberService.Services
{
	[ServiceContract]
	public interface IQueryService
	{
		[OperationContract]
		string QueryENumber(string eNumber);
	}
}