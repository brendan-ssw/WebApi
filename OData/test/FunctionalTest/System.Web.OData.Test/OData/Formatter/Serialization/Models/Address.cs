﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace System.Web.OData.Formatter.Serialization.Models
{
    public class Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }
    }

    public class UsAddress : Address
    {
        public string UsProp { get; set; }
    }

    public class CnAddress : Address
    {
        public Guid CnProp { get; set; }
    }
}
