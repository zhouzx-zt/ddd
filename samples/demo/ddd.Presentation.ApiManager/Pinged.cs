using ddd.Infrastructure.MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ddd.Presentation.ApiManager
{
    public class Pinged:INotification
    {
    }


    public class PingedHandler : INotificationHandler<Pinged>
    {
        private readonly ILogger<PingedHandler> _logger;
        public PingedHandler(ILogger<PingedHandler> logger)
        {
            _logger = logger;
        }
        public async Task Handle(Pinged notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("hallo");
            await Unit.Task;
        }
    }
}
