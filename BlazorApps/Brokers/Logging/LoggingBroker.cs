// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using Microsoft.Extensions.Logging;
using System;

namespace BlazorApps.Brokers.Logging
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger _logger;

        public LoggingBroker(ILogger logger)
        {
            _logger = logger;
        }

        public void LogCritical(Exception exception)
        {
            _logger.LogCritical(exception, exception.Message);
        }

        public void LogDebug(string message)
        {
            _logger.LogDebug(message);
        }

        public void LogError(Exception exception)
        {
            _logger.LogError(exception, exception.Message);
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogTrace(string message)
        {
            _logger.LogTrace(message);
        }

        public void LogWarning(string message)
        {
            _logger.LogWarning(message);
        }
    }
}
