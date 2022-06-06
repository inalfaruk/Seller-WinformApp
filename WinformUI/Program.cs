using Autofac;
using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace WinformUI
{
    internal static class Program
    {


       // public static IContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
          
           
           
            
            ApplicationConfiguration.Initialize();
          //  Container = Configure();
            Application.Run(new MainForm());
        }
        //static IContainer Configure()
        //{
        //    var builder = new ContainerBuilder();
        //    builder.RegisterType<ProductManager>().As<IProductService>();
        //    builder.RegisterType<EfProductDal>().As<IProductDal>();
        //    builder.RegisterType<ProductForm>();
        //    return builder.Build();
       // }
    }
}