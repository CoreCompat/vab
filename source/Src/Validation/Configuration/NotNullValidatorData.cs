﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Configuration
{
    /// <summary>
    /// Configuration object to describe an instance of class <see cref="NotNullValidator"/>.
    /// </summary>
    [ResourceDescription(typeof(DesignResources), "NotNullValidatorDataDescription")]
    [ResourceDisplayName(typeof(DesignResources), "NotNullValidatorDataDisplayName")]
    public class NotNullValidatorData : ValueValidatorData
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NotNullValidatorData"/> class.</para>
        /// </summary>
        public NotNullValidatorData() { Type = typeof(NotNullValidator); }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NotNullValidatorData"/> class with a name.</para>
        /// </summary>
        /// <param name="name">The name for the instance.</param>
        public NotNullValidatorData(string name)
            : base(name, typeof(NotNullValidator))
        { }

        /// <summary>
        /// Creates the <see cref="NotNullValidator"/> described by the configuration object.
        /// </summary>
        /// <param name="targetType">The type of object that will be validated by the validator.</param>
        /// <returns>The created <see cref="NotNullValidator"/>.</returns>
        protected override Validator DoCreateValidator(Type targetType)
        {
            return new NotNullValidator(Negated);
        }
    }
}
