﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using Microsoft.TestCommon;

namespace System.Web.Http.OData.Query
{
    [PartialTrustRunner]
    public class PartialTrustTest : QueryCompositionTests
    {
        [Fact]
        public override void QueryableUsesConfiguredAssembliesResolver()
        {
            // NO-OP
            // Moq doesn't work in partial trust
        }
    }
}
