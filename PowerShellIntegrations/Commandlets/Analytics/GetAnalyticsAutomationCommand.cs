﻿using System.Data.Objects;
using System.Management.Automation;

namespace Cognifide.PowerShell.PowerShellIntegrations.Commandlets.Analytics
{
    [Cmdlet("Get", "AnalyticsAutomation")]
    [OutputType(new[] { typeof(Automations) })]
    public class GetAnalyticsAutomationCommand : AnalyticsBaseCommand
    {
        protected override void ProcessRecord()
        {
            ObjectQuery<Automations> automations = Context.Automations;

            PipeQuery(automations);
        }
    }
}