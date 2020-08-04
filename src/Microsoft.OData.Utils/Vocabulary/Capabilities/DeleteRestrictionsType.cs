﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// ------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.Utils.Vocabulary.Capabilities
{
    /// <summary>
    /// Complex Type: Org.OData.Capabilities.V1.DeleteRestrictionsType
    /// </summary>
    // [Term("Org.OData.Capabilities.V1.DeleteRestrictions")]
    internal class DeleteRestrictionsType
    {
        /// <summary>
        /// Gets the Deletable value.
        /// </summary>
        public bool? Deletable { get; private set; }

        /// <summary>
        /// Gets the navigation properties which do not allow DeleteLink requests.
        /// </summary>
        public IList<string> NonDeletableNavigationProperties { get; private set; }

        /// <summary>
        /// Gets the maximum number of navigation properties that can be traversed.
        /// </summary>
        public int? MaxLevels { get; private set; }

        /// <summary>
        /// Gets the Members of collections can be updated via a PATCH request with a `/$filter(...)/$each` segment.
        /// </summary>
        public bool? FilterSegmentSupported { get; private set; }

        /// <summary>
        /// Gets the Members of collections can be updated via a PATCH request with a type-cast segment and a `/$each` segment.
        /// </summary>
        public bool? TypecastSegmentSupported { get; private set; }

        /// <summary>
        /// Gets the required scopes to perform the insert.
        /// </summary>
        public IList<PermissionType> Permissions { get; private set; }

        /// <summary>
        /// Gets the Supported or required custom headers.
        /// </summary>
        public IList<CustomParameter> CustomHeaders { get; private set; }

        /// <summary>
        /// Gets the Supported or required custom query options.
        /// </summary>
        public IList<CustomParameter> CustomQueryOptions { get; private set; }

        /// <summary>
        /// Gets A brief description of the request.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets A lengthy description of the request.
        /// </summary>
        public string LongDescription { get; private set; }

        /// <summary>
        /// Test the target supports delete.
        /// </summary>
        /// <returns>True/false.</returns>
        public bool IsDeletable => Deletable == null || Deletable.Value;

        /// <summary>
        /// Test the input navigation property do not allow DeleteLink requests.
        /// </summary>
        /// <param name="navigationPropertyPath">The input navigation property path.</param>
        /// <returns>True/False.</returns>
        public bool IsNonDeletableNavigationProperty(string navigationPropertyPath)
        {
            return NonDeletableNavigationProperties != null ?
                NonDeletableNavigationProperties.Any(a => a == navigationPropertyPath) :
                false;
        }
    }
}
