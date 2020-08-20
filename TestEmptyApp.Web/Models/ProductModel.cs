using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestEmptyApp.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestEmptyApp.Web.Models
{
	public class ProductModel: CommonModel<Product>
	{
		public double Price {get; set;}

		public override void PopulateFrom(Product entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Price = entity.Price;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Product entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Price = this.Price;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
