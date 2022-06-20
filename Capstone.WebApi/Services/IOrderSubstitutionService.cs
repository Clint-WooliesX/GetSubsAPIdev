using System;
using System.Threading.Tasks;
using Capstone.WebApi.Models;

namespace Capstone.WebApi.Services
{
	public interface IOrderSubstitutionService
	{
		 public Task<SmartSubsReturn[]> GetSubstitutionOfOrder(DTOOrder[] order);

		// returning an array of stores and products
	}
}

