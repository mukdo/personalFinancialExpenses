using Autofac;
using PFE.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using PFE.MemberShip.Contexts;

namespace PFE.Framework
{
    public class FrameworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<PFEUnitOfWork>().As<IPFEUnitOfWork>()
                .InstancePerLifetimeScope();

            //builder.RegisterType<CategoryRepository>().As<ICategoryRepository>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterType<CategoryService>().As<ICategoryService>()
            //    .InstancePerLifetimeScope();

        


            base.Load(builder);
        }
    }
}
