using GraphQL.Http;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.Therapy.Core;
using GraphQL.Therapy.Core.Models;
using GraphQL.Therapy.Core.Models.Types;
using GraphQL.Therapy.Models;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.Therapy
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();

            services.AddSingleton<BlogData>();
            services.AddSingleton<BlogQuery>();
            services.AddSingleton<GraphQLQuery>();
            services.AddSingleton<PostType>();
            services.AddSingleton<AuthorType>();
            services.AddSingleton<ReaderType>();
            services.AddSingleton<UserInterface>();
            services.AddSingleton<ISchema, BlogSchema>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddGraphQL(_ =>
            {
                _.EnableMetrics = true;
                _.ExposeExceptions = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                Path = "/ui/playground"
            });

            app.UseMvc();

        }
    }
}
