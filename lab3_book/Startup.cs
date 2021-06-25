using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3_book.Startup))]
namespace lab3_book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
