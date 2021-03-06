// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Cognifide")]
[assembly:
    SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters",
        MessageId =
            "Sitecore.Web.UI.Sheer.ClientResponse.Input(System.String,System.String,System.String,System.String,System.Int32)"
        , Scope = "member",
        Target =
            "Cognifide.PowerShell.Shell.Commands.SetHostPropertyCommand.#Run(Sitecore.Web.UI.Sheer.ClientPipelineArgs)")
]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.ConfirmChoice.#Text")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.ConfirmChoice.#Buttons")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
        Target =
            "Cognifide.PowerShell.Console.Applications.ConfirmChoice.#ButtonClick(Sitecore.Web.UI.Sheer.ClientPipelineArgs)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#HasFile")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#RibbonPanel")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#Result")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#DataContext")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#Databases")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#DataSource")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#Monitor")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIseNew.#ScriptDataContext")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#Editor")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIseNew.#Filename")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIseNew.#Treeview")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIseNew.#Dialog")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellRunner.#Result")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellRunner.#Monitor")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Services.PowerShellWebService+Result.#status")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Services.PowerShellWebService+Result.#handle")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Services.PowerShellWebService+Result.#result")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Services.PowerShellWebService+Result.#prompt")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
        Target =
            "Cognifide.PowerShell.Tasks.ExecuteScriptTask.#Update(Sitecore.Data.Items.Item[],Sitecore.Tasks.CommandItem,Sitecore.Tasks.ScheduleItem)"
        )]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "schedule", Scope = "member",
        Target =
            "Cognifide.PowerShell.Tasks.ExecuteScriptTask.#Update(Sitecore.Data.Items.Item[],Sitecore.Tasks.CommandItem,Sitecore.Tasks.ScheduleItem)"
        )]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "command", Scope = "member",
        Target =
            "Cognifide.PowerShell.Tasks.ExecuteScriptTask.#Update(Sitecore.Data.Items.Item[],Sitecore.Tasks.CommandItem,Sitecore.Tasks.ScheduleItem)"
        )]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "args", Scope = "member",
        Target =
            "Cognifide.PowerShell.Console.Applications.PowerShellIse.#ReloadItem(Sitecore.Web.UI.Sheer.ClientPipelineArgs)"
        )]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "args", Scope = "member",
        Target = "Cognifide.PowerShell.Shell.Provider.PsSitecoreItemProvider.#LogInfo(System.String,System.Object[])")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "format", Scope = "member",
        Target = "Cognifide.PowerShell.Shell.Provider.PsSitecoreItemProvider.#LogInfo(System.String,System.Object[])")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "args", Scope = "member",
        Target =
            "Cognifide.PowerShell.WorkflowAction.ScriptAction.#Process(Sitecore.Workflows.Simple.WorkflowPipelineArgs)")
]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
        Target =
            "Cognifide.PowerShell.SitecoreCommands.ExecutePowerShellScript.#ConfirmScriptExecution(Sitecore.Web.UI.Sheer.ClientPipelineArgs)"
        )]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#ItemID")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
        Target = "Cognifide.PowerShell.Console.Services.PowerShellWebService.#GetJobID(System.String,System.String)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type",
        Target = "Cognifide.PowerShell.Shell.ItemExtensions+ItemEditArgs")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
        Target = "Cognifide.PowerShell.Shell.Provider.PsSitecoreItemProvider.#LogInfo(System.String,System.Object[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Cognifide.PowerShell.Console.Applications.PowerShellRunner.#ExecuteInternal(System.Object[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#FieldEditor(Sitecore.Web.UI.Sheer.ClientPipelineArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Cognifide.PowerShell.Console.Applications.PowerShellIse.#ClientExecute(Sitecore.Web.UI.Sheer.ClientPipelineArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Cognifide.PowerShell.Processors.ScriptedDataSource.#Process(Sitecore.Pipelines.GetLookupSourceItems.GetLookupSourceItemsArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Cognifide.PowerShell.Processors.ScriptedRenderingDataSourceRoots.#Process(Sitecore.Pipelines.GetRenderingDatasource.GetRenderingDatasourceArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Cognifide.PowerShell.Processors.ScriptedRenderingDataSourceResolve.#Process(Sitecore.Pipelines.ResolveRenderingDatasource.ResolveRenderingDatasourceArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Processors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Shell.Commands.Serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Shell.Provider")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Tasks")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.WorkflowAction")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Shell.Settings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Shell.Commands.Workflows")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Shell")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Console.Services")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Console.Layouts")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.SitecoreIntegrations.Tasks")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.SitecoreIntegrations.Workflows")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.SitecoreIntegrations.Processors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Cognifide.PowerShell.Shell.Commands.Interactive")]
