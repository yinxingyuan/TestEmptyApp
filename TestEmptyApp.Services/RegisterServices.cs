using MetaShare.Common.Core.CommonService;
/*add customized code between this region*/
/*add customized code between this region*/
using TestEmptyApp.Services.Interfaces;

namespace TestEmptyApp.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IProductService), new ProductService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
