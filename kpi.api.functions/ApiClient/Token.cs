﻿using System;

namespace kpi.api.functions.ApiClient
{
    public class Token
    {
        public string Value { get; set; }

        public DateTime ExpiresAtUtc { get; set; }
    }
}
