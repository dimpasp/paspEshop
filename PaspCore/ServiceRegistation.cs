using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using PaspCore.Services;

namespace PaspCore
{
    public class ServiceRegistation
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder
                .RegisterType<CustomerService>()
                .InstancePerLifetimeScope()
                .As<ICustomerServices>();

            builder
               .RegisterType<ProductRepository>()
               .InstancePerLifetimeScope()
               .As<IProductRepository>();

            builder
                .RegisterType<OrderServices>()
                .InstancePerLifetimeScope()
                .As<IOrderServices>();
            builder.
               RegisterType<Data.PaspDbContext>()
               .InstancePerLifetimeScope()
               .AsSelf();
            return builder.Build();
        }
    }
}
