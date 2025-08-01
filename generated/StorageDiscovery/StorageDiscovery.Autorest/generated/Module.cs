// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Extensions;
    using SendAsyncStepDelegate = global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>;
    using PipelineChangeDelegate = global::System.Action<global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>>;
    using GetParameterDelegate = global::System.Func<string, string, global::System.Management.Automation.InvocationInfo, string, string, object>;
    using ModuleLoadPipelineDelegate = global::System.Action<string, string, global::System.Action<global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>>, global::System.Action<global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>>>;
    using ArgumentCompleterDelegate = global::System.Func<string, global::System.Management.Automation.InvocationInfo, string, string[], string[], string[]>;
    using GetTelemetryIdDelegate = global::System.Func<string>;
    using TelemetryDelegate = global::System.Action<string, global::System.Management.Automation.InvocationInfo, string, global::System.Management.Automation.PSCmdlet>;
    using NewRequestPipelineDelegate = global::System.Action<global::System.Management.Automation.InvocationInfo, string, string, global::System.Action<global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>>, global::System.Action<global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>>>;
    using SignalDelegate = global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>;
    using EventListenerDelegate = global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Management.Automation.InvocationInfo, string, string, string, global::System.Exception, global::System.Threading.Tasks.Task>;
    using NextDelegate = global::System.Func<global::System.Net.Http.HttpRequestMessage, global::System.Threading.CancellationToken, global::System.Action, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Func<global::System.EventArgs>, global::System.Threading.Tasks.Task>, global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage>>;
    using SanitizerDelegate = global::System.Action<object, string>;
    using GetTelemetryInfoDelegate = global::System.Func<string, global::System.Collections.Generic.Dictionary<global::System.String,global::System.String>>;

    /// <summary>A class that contains the module-common code and data.</summary>
    public partial class Module
    {
        /// <summary>The currently selected profile.</summary>
        public string Profile = global::System.String.Empty;

        public global::System.Net.Http.HttpClientHandler _handler = new global::System.Net.Http.HttpClientHandler();

        private static bool _init = false;

        private static readonly global::System.Object _initLock = new global::System.Object();

        private static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Module _instance;

        /// <summary>the ISendAsync pipeline instance</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline _pipeline;

        /// <summary>the ISendAsync pipeline instance (when proxy is enabled)</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline _pipelineWithProxy;

        private static readonly global::System.Object _singletonLock = new global::System.Object();

        public bool _useProxy = false;

        public global::System.Net.WebProxy _webProxy = new global::System.Net.WebProxy();

        /// <summary>Gets completion data for azure specific fields</summary>
        public ArgumentCompleterDelegate ArgumentCompleter { get; set; }

        /// <summary>The instance of the Client API</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.StorageDiscoveryClient ClientAPI { get; set; }

        /// <summary>A delegate that gets called for each signalled event</summary>
        public EventListenerDelegate EventListener { get; set; }

        /// <summary>The delegate to call to get parameter data from a common module.</summary>
        public GetParameterDelegate GetParameterValue { get; set; }

        /// <summary>The delegate to get the telemetry Id.</summary>
        public GetTelemetryIdDelegate GetTelemetryId { get; set; }

        /// <summary>The delegate to get the telemetry info.</summary>
        public GetTelemetryInfoDelegate GetTelemetryInfo { get; set; }

        /// <summary>the singleton of this module class</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Module Instance { get { if (_instance == null) { lock (_singletonLock) { if (_instance == null) { _instance = new Module(); }}} return _instance; } }

        /// <summary>The Name of this module</summary>
        public string Name => @"Az.StorageDiscovery";

        /// <summary>The delegate to call when this module is loaded (supporting a commmon module).</summary>
        public ModuleLoadPipelineDelegate OnModuleLoad { get; set; }

        /// <summary>The delegate to call before each new request (supporting a commmon module).</summary>
        public NewRequestPipelineDelegate OnNewRequest { get; set; }

        /// <summary>The name of the currently selected Azure profile</summary>
        public global::System.String ProfileName { get; set; }

        /// <summary>The ResourceID for this module (azure arm).</summary>
        public string ResourceId => @"Az.StorageDiscovery";

        /// <summary>The delegate to call in WriteObject to sanitize the output object.</summary>
        public SanitizerDelegate SanitizeOutput { get; set; }

        /// <summary>The delegate for creating a telemetry.</summary>
        public TelemetryDelegate Telemetry { get; set; }

        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>

        partial void AfterCreatePipeline(global::System.Management.Automation.InvocationInfo invocationInfo, ref Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline pipeline);

        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>

        partial void BeforeCreatePipeline(global::System.Management.Automation.InvocationInfo invocationInfo, ref Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline pipeline);

        partial void CustomInit();

        /// <summary>Creates an instance of the HttpPipeline for each call.</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="correlationId">the cmdlet's correlation id.</param>
        /// <param name="processRecordId">the cmdlet's process record correlation id.</param>
        /// <param name="parameterSetName">the cmdlet's parameterset name.</param>
        /// <param name="extensibleParameters">a dict for extensible parameters</param>
        /// <returns>An instance of Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline for the remote call.</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline CreatePipeline(global::System.Management.Automation.InvocationInfo invocationInfo, string correlationId, string processRecordId, string parameterSetName = null, global::System.Collections.Generic.IDictionary<string,object> extensibleParameters = null)
        {
            Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline pipeline = null;
            BeforeCreatePipeline(invocationInfo, ref pipeline);
            pipeline = (pipeline ?? (_useProxy ? _pipelineWithProxy : _pipeline)).Clone();
            AfterCreatePipeline(invocationInfo, ref pipeline);
            pipeline.Append(new Runtime.CmdInfoHandler(processRecordId, invocationInfo, parameterSetName).SendAsync);
            OnNewRequest?.Invoke( invocationInfo, correlationId,processRecordId, (step)=> { pipeline.Prepend(step); } , (step)=> { pipeline.Append(step); } );
            return pipeline;
        }

        /// <summary>Gets parameters from a common module.</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="correlationId">the cmdlet's correlation id.</param>
        /// <param name="parameterName">The name of the parameter to get the value for.</param>
        /// <returns>
        /// The parameter value from the common module. (Note: this should be type converted on the way back)
        /// </returns>
        public object GetParameter(global::System.Management.Automation.InvocationInfo invocationInfo, string correlationId, string parameterName) => GetParameterValue?.Invoke( ResourceId, Name, invocationInfo, correlationId,parameterName );

        /// <summary>Initialization steps performed after the module is loaded.</summary>
        public void Init()
        {
            if (_init == false)
            {
                lock (_initLock) {
                    if (_init == false) {
                        OnModuleLoad?.Invoke( ResourceId, Name ,(step)=> { _pipeline.Prepend(step); } , (step)=> { _pipeline.Append(step); } );
                        OnModuleLoad?.Invoke( ResourceId, Name ,(step)=> { _pipelineWithProxy.Prepend(step); } , (step)=> { _pipelineWithProxy.Append(step); } );
                        CustomInit();
                        _init = true;
                    }
                }
            }
        }

        /// <summary>Creates the module instance.</summary>
        private Module()
        {
            // constructor
            ClientAPI = new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.StorageDiscoveryClient();
            _handler.Proxy = _webProxy;
            _pipeline = new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline(new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpClientFactory(new global::System.Net.Http.HttpClient()));
            _pipelineWithProxy = new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpPipeline(new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.HttpClientFactory(new global::System.Net.Http.HttpClient(_handler)));
        }

        /// <param name="proxy">The HTTP Proxy to use.</param>
        /// <param name="proxyCredential">The HTTP Proxy Credentials</param>
        /// <param name="proxyUseDefaultCredentials">True if the proxy should use default credentials</param>
        public void SetProxyConfiguration(global::System.Uri proxy, global::System.Management.Automation.PSCredential proxyCredential, bool proxyUseDefaultCredentials)
        {
            _useProxy = proxy != null;
            if (proxy == null)
            {
                return;
            }
            // set the proxy configuration
            _webProxy.Address = proxy;
            _webProxy.BypassProxyOnLocal = false;
            if (proxyUseDefaultCredentials)
            {
                _webProxy.Credentials = null;
                _webProxy.UseDefaultCredentials = true;
            }
            else
            {
                _webProxy.UseDefaultCredentials = false;
                _webProxy.Credentials = proxyCredential ?.GetNetworkCredential();
            }
        }

        /// <summary>Called to dispatch events to the common module listener</summary>
        /// <param name="id">The ID of the event </param>
        /// <param name="token">The cancellation token for the event </param>
        /// <param name="getEventData">A delegate to get the detailed event data</param>
        /// <param name="signal">The callback for the event dispatcher </param>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="parameterSetName">the cmdlet's parameterset name.</param>
        /// <param name="correlationId">the cmdlet's correlation id.</param>
        /// <param name="processRecordId">the cmdlet's process record correlation id.</param>
        /// <param name="exception">the exception that is being thrown (if available)</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the event is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<global::System.EventArgs> getEventData, SignalDelegate signal, global::System.Management.Automation.InvocationInfo invocationInfo, string parameterSetName, string correlationId, string processRecordId, global::System.Exception exception)
        {
            using( NoSynchronizationContext )
            {
                await EventListener?.Invoke(id,token,getEventData, signal, invocationInfo, parameterSetName, correlationId,processRecordId,exception);
            }
        }
    }
}