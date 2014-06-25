﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MD.DevTools.NotificationSender
{
    public class Data
    {
        public int Page { get; set; }
        public int NumberOfItems { get; set; }

        public int TotalPages { get; set; }
        public int TotalItems { get; set; }

        public string[] RawContent { get; set; }
        public MD.CloudConnect.MDData[] Content { get; set; }
    }
}
