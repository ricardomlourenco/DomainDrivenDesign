using DomainDrivenDesign.Infra.Data.Context;
using SimpleInjector;

namespace DomainDrivenDesign.Infra.Data
{
    public static class Bootstrapper
    {
        public static void Register(Container container)
        {
            container.Register<DefaultORMContext>(Lifestyle.Scoped);
        }
    }
}
