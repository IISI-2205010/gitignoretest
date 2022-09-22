using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService1
{
    public class HookerService : HookProvider.HookProviderBase
    {
        private readonly ILogger<HookerService> _logger;
        public HookerService(ILogger<HookerService> logger)
        {
            _logger = logger;
        }

        public override Task<EmptySuccess> OnClientConnect(ClientConnectRequest request, ServerCallContext context)
        {
            return Task.FromResult(new EmptySuccess
            {
                Message = "Hello " + request.Meta
            });
        }
    }
}
