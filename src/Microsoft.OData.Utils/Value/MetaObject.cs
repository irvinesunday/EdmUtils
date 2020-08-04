// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.Utils.Value
{
    internal class MetaObject : Dictionary<string, IMetaValue>, IMetaValue
    {
        public MetaValueKind Kind => MetaValueKind.MObject;

    }
}