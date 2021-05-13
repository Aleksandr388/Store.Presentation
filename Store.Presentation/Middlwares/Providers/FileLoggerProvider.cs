﻿using Microsoft.Extensions.Logging;

namespace Store.Presentation.Middlewares.Providers
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private readonly string _path;
        public FileLoggerProvider(string path)
        {
            _path = path;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(_path);
        }
        public void Dispose()
        {
        }
    }
}