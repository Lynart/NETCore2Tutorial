﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2._1Tutorial.Services
{
    public class NullMailService : IMailService
    {
        private ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string to, string subject, string body)
        {
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");

        }
    }
}
