namespace SeriLogSimple.Helpers
{
    public interface ILogHelper
    {
        void LogInformation(string message);
        void LogError(string message, Exception ex = null);
    }
}
