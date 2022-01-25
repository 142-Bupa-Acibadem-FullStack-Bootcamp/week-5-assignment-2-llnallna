using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NorthwindBupa.Bll;
using NorthwindBupa.Concrete.EntityFramework.Repository;
using NorthwindBupa.Dal.Abstract;
using NorthwindBupa.Dal.Concreate.EntityFramework.UnitOfWork;
using NorthwindBupa.Dal.Concrete.EntityFramework.Context;
using NorthwindBupa.Dal.Concrete.EntityFramework.Repository;
using NorthwindBupa.Interface;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using ISupplierRepository = NorthwindBupa.Dal.Abstract.ISupplierRepository;

namespace NorthwindBupa.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region JwtTokenService

            // JwtSecurityTokenHandler
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(cfg =>
            {
                cfg.SaveToken = true;
                cfg.RequireHttpsMetadata = false;

                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    RoleClaimType = "Roles",
                    ClockSkew = TimeSpan.FromMinutes(5),
                    ValidateLifetime = true,
                    ValidIssuer = Configuration["Tokens:Issuer"],
                    ValidateAudience = true,
                    ValidAudience = Configuration["Tokens:Issuer"], //Configuration["Tokens:Audience"] biz token service ile token clientler ayný olduðundan Issuer key'ini kullandik
                    RequireSignedTokens = true,
                    RequireExpirationTime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Key"]))
                };
            });
            #endregion

            #region ApplicationContext
            //services.AddDbContext<NorthwindContext>();
            //services.AddScoped<DbContext, NorthwindContext>();

            //DB baðlantý için yöntem 2
            services.AddScoped<DbContext, NorthwindBupaContext> ();
            IServiceCollection serviceCollection = services.AddDbContext<NorthwindBupaContext> (opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("SqlServer"), sqlOpt =>
                {
                    sqlOpt.MigrationsAssembly("Northwind.Dal");
                });
            });
            #endregion

            #region ServiceSection
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ICustomerDemographicService, CustomerDemographicManager>();


            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICustomerCustomerDemoService, CustomerCustomerDemoManager>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeTerritoryService, EmployeeTerritoryManager>();
            services.AddScoped<IOrderDetailService, OrderDetailManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IRegionService, RegionManager>();
            services.AddScoped<IShipperService, ShipperManager>();
            services.AddScoped<ISupplierService, SupplierManager>();
            services.AddScoped<ITerritoryService, TerritoryManager>();


            #endregion

            #region RepositorySection
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ICustomerDemographicRepository, CustomerDemographicRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerCustomerDemoRepository, CustomerCustomerDemoRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IShipperRepository, ShipperRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ITerritoryRepository, TerritoryRepository>();


            #endregion

            #region UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NorthwindBupa.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NorthwindBupa.WebApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
