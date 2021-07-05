using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811190667_NguyenQuocCuong_BigSchool01.Startup))]
namespace _1811190667_NguyenQuocCuong_BigSchool01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
