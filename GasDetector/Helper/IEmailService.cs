﻿namespace GasDetector.Helper
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
