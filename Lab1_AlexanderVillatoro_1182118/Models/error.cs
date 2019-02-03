using System;

namespace Lab1_AlexanderVillatoro_1182118.Models
{
    public class Error
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}