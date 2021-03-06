﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevApp
{
    public class AppConfig
    {
        /// <summary>
        /// The base url of the application, by default automatically discovered.
        /// </summary>
        public string BaseUrl { get; set; } = HalcyonConventionOptions.HostVariable;

        /// <summary>
        /// The connection string for the app's primary database.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// True to turn on detailed error messages.
        /// </summary>
        public bool DetailedErrors { get; set; }

        /// <summary>
        /// The base path the app lives on. Used for cookie paths and to enforce the url spelling.
        /// Can be null to live on the root path.
        /// </summary>
        public string PathBase { get; set; }

        /// <summary>
        /// Should the api explorer be accessible, false by default. The api explorer is pure client side
        /// and will not expose methods the user cannot access on the service, so if I hit the explorer page
        /// logged in vs logged out it will behave differently. That said it is probably best to leave this
        /// off in production.
        /// </summary>
        public bool AllowApiExplorer { get; set; }

        /// <summary>
        /// Set this to true to use asset bundles instead of individual client side files.
        /// </summary>
        public bool UseAssetBundles { get; set; } = false;

        /// <summary>
        /// Set this to true to have the app write 
        /// </summary>
        public bool UpdateConfigSchema { get; set; } = false;
    }
}
