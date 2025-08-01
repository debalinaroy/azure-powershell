﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Components;
using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Extensions;
using Microsoft.Azure.Commands.TestFx;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Resources.Test.ScenarioTests
{
    public class ResourcesTestRunner
    {
        protected readonly ITestRunner TestRunner;

        protected ResourcesTestRunner(ITestOutputHelper output)
        {
            TestRunner = TestManager.CreateInstance(output)
                .WithNewPsScriptFilename($"{GetType().Name}.ps1")
                .WithProjectSubfolderForTests("ScenarioTests")
                .WithCommonPsScripts(
                [
                    @"Common.ps1",
                ])
                .WithExtraRmModules(helper => new[]
                {
                    helper.RMResourceModule,
                    helper.GetRMModulePath("Az.Monitor.psd1"),
                    helper.GetRMModulePath("Az.ManagedServiceIdentity.psd1"),
                    // helper.GetRMModulePath("Az.Purview.psd1") // Temporarily commented out due to type loading issue
                })
                .WithRecordMatcher(
                    (ignoreResourcesClient, resourceProviders, userAgentsToIgnore) => new ResourcesRecordMatcher(ignoreResourcesClient, resourceProviders, userAgentsToIgnore)
                )
                .WithNewRecordMatcherArguments(
                    userAgentsToIgnore: [],
                    resourceProviders: new Dictionary<string, string>
                    {
                        {"Microsoft.Resources", null},
                        {"Microsoft.Features", null},
                        {"Microsoft.Authorization", null},
                        {"Providers.Test", null},
                        {"microsoft.web", null },
                        {"Microsoft.Web", null }
                    }
                )
                .WithManagementClients(context =>
                    {
                        var creds = context.GetClientCredentials(AzureEnvironment.Endpoint.ActiveDirectoryServiceEndpointResourceId);
                        HttpClientHelperFactory.Instance = new TestHttpClientHelperFactory(creds);
                        return HttpClientHelperFactory.Instance;
                    }
                )
                .Build();
        }
    }

    #region TestHttpClientHelperFactory

    internal class TestHttpClientHelperFactory : HttpClientHelperFactory
    {
        /// <summary>
        /// The service client credentials.
        /// </summary>
        private readonly ServiceClientCredentials credential;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesController.TestHttpClientHelperFactory"/> class.
        /// </summary>
        /// <param name="credentials"></param>
        public TestHttpClientHelperFactory(ServiceClientCredentials credentials)
        {
            credential = credentials;
        }

        /// <summary>
        /// Creates new instances of the <see cref="HttpClientHelper"/> class.
        /// </summary>
        /// <param name="credentials">The credentials.</param>
        /// <param name="headerValues">The headers.</param>
        public override HttpClientHelper CreateHttpClientHelper(ServiceClientCredentials credentials, IEnumerable<ProductInfoHeaderValue> headerValues, Dictionary<string, string> cmdletHeaderValues)
        {
            return new TestHttpClientHelperFactory.HttpClientHelperImpl(credentials: credential, headerValues: headerValues, cmdletHeaderValues: cmdletHeaderValues);
        }

        /// <summary>
        /// An implementation of the <see cref="HttpClientHelper"/> abstract class.
        /// </summary>
        private class HttpClientHelperImpl : HttpClientHelper
        {
            /// <summary>
            /// Initializes new instances of the <see cref="ResourcesController.TestHttpClientHelperFactory.HttpClientHelperImpl"/> class.
            /// </summary>
            /// <param name="credentials">The credentials.</param>
            /// <param name="headerValues">The headers.</param>
            public HttpClientHelperImpl(ServiceClientCredentials credentials, IEnumerable<ProductInfoHeaderValue> headerValues, Dictionary<string, string> cmdletHeaderValues)
                : base(credentials: credentials, headerValues: headerValues, cmdletHeaderValues: cmdletHeaderValues)
            {
            }

            /// <summary>
            /// Creates an <see cref="HttpClient"/>
            /// </summary>
            /// <param name="primaryHandlers">The handlers that will be added to the top of the chain.</param>
            public override HttpClient CreateHttpClient(params DelegatingHandler[] primaryHandlers)
            {
                return base.CreateHttpClient(HttpMockServer.CreateInstance().AsArray().Concat(primaryHandlers).ToArray());
            }
        }
    }

    #endregion
}
