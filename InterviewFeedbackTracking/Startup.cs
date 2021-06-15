using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterviewFeedbackTracking.Startup))]
namespace InterviewFeedbackTracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
