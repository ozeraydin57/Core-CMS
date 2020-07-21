using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tier.Business.Abstract;
using Tier.Business.Concrete;
using Tier.DataAccess.Abstract;
using Tier.DataAccess.Concrete.EntityFramework;
using Web.MVC.Services;

namespace Web.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();


            services.AddScoped<IMenuService, MenuManager>();
            services.AddScoped<IMenuDal, EfMenuDal>();

            services.AddScoped<IParamService, ParamManager>();
            services.AddScoped<IParamDal, EfParamDal>();

            services.AddScoped<IParamSessionService, ParamSessionService>();
            //services.AddScoped<SettingSessionService>();

            services.AddScoped<IPostService, PostManager>();
            services.AddScoped<IPostDal, EfPostDal>();
            services.AddScoped<IPostDetailDal, EfPostDetailDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            services.AddScoped<IPostCommentService, PostCommentManager>();
            services.AddScoped<IPostCommentDal, EfPostCommentDal>();


            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSingleton<ICartService, CartService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddMvc();

            services.AddSingleton<IAuthService, AuthService>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = "/Admin/Login";
                });//
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();//
            app.UseAuthorization();


            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
