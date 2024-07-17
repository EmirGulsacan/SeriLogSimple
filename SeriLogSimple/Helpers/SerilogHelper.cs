using Serilog;

namespace SeriLogSimple.Helpers
{
    public class SerilogHelper : ILogHelper
    {
        private readonly Serilog.ILogger _logger;

        public SerilogHelper()
        {
            _logger = Log.ForContext<SerilogHelper>(); ;
        }

        public void LogInformation(string message)
        {
            _logger.Information(message);
        }

        public void LogError(string message, Exception ex = null)
        {
            if (ex != null)
            {
                _logger.Error(ex, message);
            }
            else
            {
                _logger.Error(message);
            }
        }
    }
}
