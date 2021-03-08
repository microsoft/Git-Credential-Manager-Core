// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
using System;

namespace Microsoft.AzureRepos
{
    internal static class AzureDevOpsConstants
    {
        // AAD environment authority base URL
        public const string AadAuthorityBaseUrl = "https://login.microsoftonline.com";

        // Azure DevOps's app ID + default scopes
        public static readonly string[] AzureDevOpsDefaultScopes = {"499b84ac-1321-427f-aa17-267ca6975798/.default"};

        // Visual Studio's client ID
        // We share this to be able to consume existing access tokens from the VS caches
        public const string AadClientId = "872cd9fa-d31f-45e0-9eab-6e460a02d1f1";

        // Redirect URI specified by the Visual Studio application configuration
        public static readonly Uri AadRedirectUri = new Uri("http://localhost");

        public const string VstsHostSuffix = ".visualstudio.com";
        public const string AzureDevOpsHost = "dev.azure.com";

        public const string VssResourceTenantHeader = "X-VSS-ResourceTenant";

        public static class PersonalAccessTokenScopes
        {
            public const string ReposWrite = "vso.code_write";
            public const string ArtifactsRead = "vso.packaging";
            public static readonly string[] DefaultScopes = new string[] {ReposWrite, ArtifactsRead};
        }

        public static class EnvironmentVariables
        {
            public const string DevAadClientId = "GCM_DEV_AZREPOS_CLIENTID";
            public const string DevAadRedirectUri = "GCM_DEV_AZREPOS_REDIRECTURI";
            public const string DevAadAuthorityBaseUri = "GCM_DEV_AZREPOS_AUTHORITYBASEURI";
            public const string GcmVstsScope = "GCM_VSTS_SCOPE";
            public const string GcmDevOpsScope = "GCM_DEVOPS_SCOPE";
        }

        public static class GitConfiguration
        {
            public static class Credential
            {
                public const string DevAadClientId = "azreposDevClientId";
                public const string DevAadRedirectUri = "azreposDevRedirectUri";
                public const string DevAadAuthorityBaseUri = "azreposDevAuthorityBaseUri";
                public const string DevOpsScope = "devopsScope";
                public const string VstsScope = "vstsScope";
            }
        }
    }
}
