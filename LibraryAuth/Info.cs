﻿using Microsoft.OpenApi.Models;

namespace LibraryAuth
{
    internal class Info : OpenApiInfo
    {
        public new string Title { get; set; }
        public new string Version { get; set; }
    }
}