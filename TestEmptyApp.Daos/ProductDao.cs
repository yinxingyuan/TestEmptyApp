using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using TestEmptyApp.Daos.Interfaces;
using TestEmptyApp.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestEmptyApp.Daos
{
	public class ProductDao : CommonObjectDao<Product>, IProductDao
	{
		public class ProductSqlBuilder : ObjectSqlBuilder
		{
			public ProductSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Product")
			{
				this.SqlInsert = "INSERT INTO Product (Price," + this.SqlBaseFieldInsertFront + ") VALUES (@Price," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Product SET Price=@Price," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class ProductResultHandler : CommonObjectResultHandler<Product>
		{
			public override void GetColumnValues(IDataReader reader, Product item)
			{
				base.GetColumnValues(reader, item);
				int ordinalPrice = reader.GetOrdinal("Price");
				item.Price =  reader.IsDBNull(ordinalPrice) ? 0 : reader.GetDouble(ordinalPrice);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Product item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Price", item.Price);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public ProductDao(SqlDialect sqlDialect) : base(new ProductSqlBuilder(sqlDialect), new ProductResultHandler())
		{
		}

		public ProductDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ProductSqlBuilder(sqlDialect), new ProductResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
