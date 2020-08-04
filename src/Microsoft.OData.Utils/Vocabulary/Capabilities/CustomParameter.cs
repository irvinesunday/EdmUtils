﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// ------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.OData.Utils.Vocabulary.Core;

namespace Microsoft.OData.Utils.Vocabulary.Capabilities
{
    /// <summary>
    /// Complex type: Org.OData.Capabilities.V1.CustomParameter
    /// </summary>
    // [Term("Org.OData.Capabilities.V1.CustomHeaders")]
    // [Term("Org.OData.Capabilities.V1.CustomQueryOptions")]
    internal class CustomParameter
    {
        /// <summary>
        /// Gets/sets the name of the custom parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets/sets the description of the custom parameter.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets/sets the documentationURL of the custom parameter.
        /// </summary>
        public string DocumentationURL { get; set; }

        /// <summary>
        /// Gets/sets the reuired of the custom parameter. true: parameter is required, false or not specified: parameter is optional.
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Gets the list of scopes that can provide access to the resource.
        /// </summary>s
        public IList<PrimitiveExampleValue> ExampleValues { get; set; }
    }
}
