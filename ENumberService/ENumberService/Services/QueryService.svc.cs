using System.Collections.Generic;

namespace ENumberService.Services
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QueryService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select QueryService.svc or QueryService.svc.cs at the Solution Explorer and start debugging.
	public class QueryService : IQueryService
	{
		public string QueryENumber(string eNumber)
		{
			// Mock database query logic
			Dictionary<string, string> database = new Dictionary<string, string>
			{
				{ "E100", "Curcumin" },
				{ "E101", "Riboflavin" }
			};

			if (database.ContainsKey(eNumber))
			{
				return database[eNumber];
			}
			return "Unknown E-Number";
		}
	}
}
