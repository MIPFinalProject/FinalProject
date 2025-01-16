using System.Diagnostics;

namespace LoggingLibrary
{
    public static class TraceLogger
    {
        private static readonly string LogFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TraceLog.txt");

        static TraceLogger()
        {
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener(LogFilePath));
            Trace.AutoFlush = true;
        }

        public static void LogInfo(string message)
        {
            Trace.WriteLine($"INFO: {DateTime.Now} - {message}");
        }

        public static void LogWarning(string message)
        {
            Trace.WriteLine($"WARNING: {DateTime.Now} - {message}");
        }

        public static void LogError(string message)
        {
            Trace.WriteLine($"ERROR: {DateTime.Now} - {message}");
        }
    }
}
