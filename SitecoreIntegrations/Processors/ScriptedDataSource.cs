﻿using Sitecore.Collections;
using Sitecore.Diagnostics;
using Sitecore.Pipelines.GetLookupSourceItems;

namespace Cognifide.PowerShell.SitecoreIntegrations.Processors
{
    public class ScriptedDataSource : BaseScriptedDataSource
    {
        public void Process(GetLookupSourceItemsArgs args)
        {
            Assert.ArgumentNotNull(args, "args");
            if (IsScripted(args.Source))
            {
                var items = new ItemList();
                string source = GetScriptedQueries(args.Source, args.Item, items);
                args.Result.AddRange(items.ToArray());
                if (string.IsNullOrEmpty(source))
                {
                    args.AbortPipeline();
                }
            }
        }
    }
}