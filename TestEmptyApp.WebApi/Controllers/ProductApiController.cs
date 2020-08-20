using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestEmptyApp.Entities;
using TestEmptyApp.Services.Interfaces;
using TestEmptyApp.WebApi.Models;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestEmptyApp.WebApi.Controllers
{
	[Route("/ProductApi")]
	public class ProductApiController : CommonApiController<Product, IProductService>
	{


		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
