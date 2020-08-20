using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using TestEmptyApp.Entities;
using MetaShare.Common.Core.Services;
using TestEmptyApp.Daos.Interfaces;
using TestEmptyApp.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace TestEmptyApp.Services
{
	public class ProductService : Service<Product>, IProductService
	{
		public ProductService() : base(typeof (IProductDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
