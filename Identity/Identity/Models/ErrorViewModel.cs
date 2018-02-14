using System;

namespace Identity.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        // checking to see if the id that is requested is in database?
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}