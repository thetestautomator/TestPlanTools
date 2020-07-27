using Serilog;
using Serilog.Core;
using TPTools.Services;
using TPTools.Tools;

namespace TPTools
{
    public class TestPlanTools
    {
        public Logger Logger;
        private DevOpsConfiguration _config;

        public TestPlanTools(DevOpsConfiguration config)
        {
            _config = config;
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            Logger = (Logger)Log.Logger;
        }

        public void AssociateTestCases(bool forceUpdate = false)
        {
            var associatedTestCases = new TestCaseAssociation().AssociateTestCases();
            var client = new TestCaseClient(_config);

            foreach (var atc in associatedTestCases)
            {
                client.UpdateTestCaseAssociation(atc, forceUpdate);
            }
        }
    }
}