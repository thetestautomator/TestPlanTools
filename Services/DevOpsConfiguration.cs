using System.Security;

namespace TestPlanTools.Services
{
    public class DevOpsConfiguration
    {
        public string Url { get; set; }
        public string Project { get; set; }
        public string User { get; set; }
        public SecureString Token { get; set; }
    }
}