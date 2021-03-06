﻿using System.Management.Automation;
using Sitecore.Data.Items;

namespace Cognifide.PowerShell.PowerShellIntegrations.Commandlets
{
    [Cmdlet("Get", "ItemTemplate", DefaultParameterSetName = "Item")]
    [OutputType(new[] { typeof(TemplateItem) })]
    public class GetItemTemplateCommand : BaseCommand
    {
        [Parameter(ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        public Item Item { get; set; }

        [Parameter]
        public SwitchParameter Recurse { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(Item.Template, true);
            if (Recurse.IsPresent)
            {
                WriteObject(Item.Template.BaseTemplates, true);
            }
        }
    }
}