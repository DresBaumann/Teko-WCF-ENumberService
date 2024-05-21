using System.ServiceModel;

namespace ENumberService.Services
{
	[ServiceContract]
	public interface IENIdentificationService
	{
		[OperationContract]
		bool VerifyENumber(string eNumber);
	}
}