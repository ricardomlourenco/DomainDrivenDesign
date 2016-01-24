using DomainDrivenDesign.Application.Interfaces;
using DomainDrivenDesign.Application.Services;
using DomainDrivenDesign.Domain.Interfaces.Repository;
using DomainDrivenDesign.Domain.Interfaces.Services;
using DomainDrivenDesign.Domain.Services;
using DomainDrivenDesign.Infra.Data.Repository;
using SimpleInjector;

namespace DomainDrivenDesign.Infrastructrue.CrossCutting.IoC
{
    public class Bootstrapper
    {
        public static void Register(Container container)
        {
            /// Application Layer
            container.Register<ISecurityAppService, SecurityAppService>(Lifestyle.Scoped);

            /// Domain
            container.Register<ISecurityService, SecurityService>(Lifestyle.Scoped);

            /// Infra Data
            container.Register<ISecurityRepository, SecurityRepository>(Lifestyle.Scoped);

            DomainDrivenDesign.Infra.Data.Bootstrapper.Register(container);

        }
    }
}
