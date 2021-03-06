﻿using System.Management.Automation;
using Sitecore.Data.Items;
using Sitecore.Workflows;
using Sitecore.Workflows.Simple;

namespace Cognifide.PowerShell.PowerShellIntegrations.Commandlets.Workflows
{
    [Cmdlet("Get", "ItemWorkflowEvent")]
    [OutputType(new[] { typeof(WorkflowEvent) })]
    public class GetItemWorkflowEventCommand : BaseCommand
    {
        [Parameter(ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        public Item Item { get; set; }

        [Parameter]
        [Alias("FullName", "FileName")]
        public string Path { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string UserName { get; set; }

        protected override void ProcessRecord()
        {
            Item = FindItemFromParameters(Item, Path, Id);

            WorkflowEvent[] workflowHistory =
                ((WorkflowProvider) Item.Database.WorkflowProvider).HistoryStore.GetHistory(Item);
            foreach (WorkflowEvent workflowEvent in workflowHistory)
            {
                WriteObject(workflowEvent);
            }
        }
    }
}