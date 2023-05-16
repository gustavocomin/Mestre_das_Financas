using MF.Application.Commons.Consumirdores;
using MF.Application.Commons.Empresas;
using MF.Application.Commons.ModalidadePagto.CondPagtos;
using MF.Application.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Application.Commons.Usuarios;
using MF.Application.ControleMensal.Despesas;
using MF.Application.ControleMensal.Mercado.Compras;
using MF.Application.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.Commons.Consumirdores;
using MF.Domain.Commons.Empresas;
using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Domain.Commons.Usuarios;
using MF.Domain.Commons.Usuarios.Email;
using MF.Domain.Commons.Usuarios.Validacoes;
using MF.Domain.ControleMensal.Despesas;
using MF.Domain.ControleMensal.Mercado.Compras;
using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Repository.Configurations.Db;
using MF.Repository.Data.Commons.Consumirdores;
using MF.Repository.Data.Commons.Empresas;
using MF.Repository.Data.Commons.ModalidadePagto.CondPagtos;
using MF.Repository.Data.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Repository.Data.Commons.Usuarios;
using MF.Repository.Data.Commons.Usuarios.Email;
using MF.Repository.Data.ControleMensal.Despesas;
using MF.Repository.Data.ControleMensal.Mercado.Compras;
using MF.Repository.Data.ControleMensal.Mercado.Compras.Itens;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

namespace MF.Api
{
    public class Program
    {
        public IConfiguration Configuration { get; }

        public Program(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<DataContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            TestarConexao();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mestre das Finanças" });

                //c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                //{
                //    Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
                //    Name = "Authorization",
                //    In = ParameterLocation.Header,
                //    Type = SecuritySchemeType.ApiKey,
                //    Scheme = "Bearer"
                //});

                //c.AddSecurityRequirement(new OpenApiSecurityRequirement
                //{
                //    {
                //        new OpenApiSecurityScheme
                //        {
                //            Reference = new OpenApiReference
                //            {
                //                Type = ReferenceType.SecurityScheme,
                //                Id = "Bearer"
                //            }
                //        },
                //        Array.Empty<string>()
                //    }
                //});

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            var secret = Encoding.ASCII.GetBytes(new Program(builder.Configuration).Configuration.GetSection("JwtConfigurations:Secret").Value);



            //builder.Services.AddAuthentication(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(x =>
            //{
            //    x.RequireHttpsMetadata = false;
            //    x.SaveToken = true;
            //    x.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(secret),
            //        ValidateIssuer = false,
            //        ValidateAudience = false
            //    };
            //});

            //builder.Services.AddMvc(opt =>
            //{
            //    opt.UseCentralRoutePrefix(new RouteAttribute("a"));
            //}).AddControllersAsServices().AddNewtonsoftJson();

            //builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped<IRepConsumidor, RepConsumidor>();
            builder.Services.AddScoped<IRepUsuario, RepUsuario>();
            builder.Services.AddScoped<IRepEmailProvider, RepEmailProvider>();
            builder.Services.AddScoped<IRepEmpresa, RepEmpresa>();
            builder.Services.AddScoped<IRepCondPagto, RepCondPagto>();
            builder.Services.AddScoped<IRepCondPagtoParcs, RepCondPagtoParcs>();
            builder.Services.AddScoped<IRepDespesa, RepDespesa>();
            builder.Services.AddScoped<IRepCompra, RepCompra>();
            builder.Services.AddScoped<IRepItemCompra, RepItemCompra>();

            builder.Services.AddScoped<IAplicConsumidor, AplicConsumidor>();
            builder.Services.AddScoped<IAplicUsuario, AplicUsuario>();
            builder.Services.AddScoped<IAplicEmpresa, AplicEmpresa>();
            builder.Services.AddScoped<IAplicCondPagto, AplicCondPagto>();
            builder.Services.AddScoped<IAplicCondPagtoParcs, AplicCondPagtoParcs>();
            builder.Services.AddScoped<IAplicDespesa, AplicDespesa>();
            builder.Services.AddScoped<IAplicCompra, AplicCompra>();
            builder.Services.AddScoped<IAplicItemCompra, AplicItemCompra>();

            builder.Services.AddScoped<IValidacoesUsuario, ValidacoesUsuario>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseRouting();

            app.MapControllers();

            app.Run();
        }

        static void TestarConexao()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));

            using var db = new DataContext(optionsBuilder.Options);
            if (!db.TestarConexao())
                throw new Exception("Não foi possível conectar ao banco de dados.");
        }
    }
}