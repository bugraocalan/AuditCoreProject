using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuditManager>().As<IAuditService>();

            builder.RegisterType<CustomerManager>().As<ICustomerDal>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<SurveyDetailManager>().As<ISurveyDetailService>();
            builder.RegisterType<EfSurveyDetailDal>().As<ISurveyDetailDal>();

            builder.RegisterType<SurveyMasterManager>().As<ISurveyMasterService>();
            builder.RegisterType<EfSurveyMasterDal>().As<ISurveyMasterDal>();

            builder.RegisterType<TemplateSurveyDetailManager>().As<ITemplateSurveyDetailService>();
            builder.RegisterType<EfTemplateSurveyDetailDal>().As<ITemplateSurveyDetailDal>();

            builder.RegisterType<TemplateSurveyMasterManager>().As<ITemplateSurveyMasterDal>();
            builder.RegisterType<EfTemplateSurveyMasterDal>().As<ITemplateSurveyMasterDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }
    }
}
