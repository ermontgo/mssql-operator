﻿using System;
using k8s;
using Microsoft.Extensions.Logging;
using OperatorSharp;

namespace MSSqlOperator.DatabaseServers
{
    public class DatabaseServerOperator : Operator<DatabaseServerResource>
    {
        public DatabaseServerOperator(IKubernetes client, ILogger<Operator<DatabaseServerResource>> logger) : base(client, logger)
        {
        }

        public override void HandleException(Exception ex)
        {
            throw new NotImplementedException();
        }

        public override void HandleItem(WatchEventType eventType, DatabaseServerResource item)
        {

        }
    }
}
