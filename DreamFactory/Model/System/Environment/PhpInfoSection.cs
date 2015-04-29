﻿// ReSharper disable InconsistentNaming
namespace DreamFactory.Model.System.Environment
{
    using global::System.Collections.Generic;

    /// <summary>
    /// PhpInfoSection.
    /// </summary>
    public class PhpInfoSection
    {
        /// <summary>
        /// name.
        /// </summary>
        public Dictionary<string, object> info { get; set; }
    }
}