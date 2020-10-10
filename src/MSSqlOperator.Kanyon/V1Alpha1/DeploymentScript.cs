﻿using System;
using System.Collections.Generic;
using System.Text;
using Kanyon.Core;
using Newtonsoft.Json;

namespace MSSqlOperator.Kapitan.V1Alpha1
{
    public class DeploymentScript : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "mssql-operator.github.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "DeploymentScript";

        public DeploymentScriptSpec spec { get; set; }
    }
}