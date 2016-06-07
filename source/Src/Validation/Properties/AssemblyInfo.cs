// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
#if !CORECLR
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;
#endif

[assembly: AssemblyTitle("Enterprise Library Validation Application Block")]
[assembly: AssemblyDescription("Enterprise Library Validation Application Block")]
[assembly: AssemblyVersion("6.0.0.0")]
[assembly: AssemblyFileVersion("6.0.1311.0")]
[assembly: AssemblyInformationalVersion("6.0.1311-prerelease")]

[assembly: SecurityTransparent]

[assembly: ComVisible(false)]

#if !CORECLR
[assembly: HandlesSection(ValidationSettings.SectionName)]
[assembly: AddApplicationBlockCommand(
                ValidationSettings.SectionName,
                typeof(ValidationSettings),
                TitleResourceType = typeof(DesignResources),
                TitleResourceName = "AddValidationSettings")]
#endif