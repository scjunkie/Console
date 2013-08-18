﻿using System;
using Cognifide.PowerShell.Console.Services;
using Sitecore.Security;
using Sitecore.Shell.Framework.Commands.Media;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.Web.UI.Sheer;

namespace Cognifide.PowerShell.SitecoreIntegrations.Controls
{
    public class UserPicker : Control
    {

        protected Edit Viewer;
        protected Button PickButton;

        public UserPicker()
        {
			Viewer = new Edit();
			Viewer.ReadOnly = true;
            Viewer.Class = "scUserPickerEdit textEdit clrString";
			PickButton = new Button();
			PickButton.Header = "...";
            PickButton.Class = "scUserPickerButton";
            Controls.Add(Viewer);
			Controls.Add(PickButton);
        }

        public string Click
        {
            get { return PickButton.Click; }
            set { PickButton.Click = value; }
        }


        public override string Value
        {
            get
            {
                return base.Value;
            }
            set
            {
                Viewer.Value = string.Empty;
                string result = string.Empty;
                string[] entries = value.Split('|');
                foreach (var entry in entries)
                {
                    var entryParts = entry.Split('^');
                    Viewer.Value += entryParts[0] + ", ";
                    result += entryParts[0] + "|";
                }
                Viewer.Value = Viewer.Value.TrimEnd(',', ' ');
                result = result.Trim('|');
                base.Value = result;
                SheerResponse.SetAttribute(Viewer.ID, "value", value);
            }
        }

        public bool ExcludeUsers
        {
            get { return GetViewStateBool("ExcludeUsers"); }
            set { SetViewStateBool("ExcludeUsers", value); }
        }

        public bool ExcludeRoles
        {
            get { return GetViewStateBool("ExcludeRoles"); }
            set { SetViewStateBool("ExcludeRoles", value); }
        }

        public string DomainName
        {
            get { return GetViewStateString("DomainName"); }
            set { SetViewStateString("DomainName", value); }
        }

        public bool Multiple
        {
            get { return GetViewStateBool("Multiple"); }
            set { SetViewStateBool("Multiple", value); }
        }

        public void Clicked(ClientPipelineArgs args)
        {
            if (!args.IsPostBack)
            {
                SelectAccountOptions options = new SelectAccountOptions();
                options.Multiple = Multiple;
                options.ExcludeUsers = ExcludeUsers;
                options.ExcludeRoles = ExcludeRoles;
                if (!string.IsNullOrEmpty(DomainName))
                {
                    options.DomainName = DomainName;
                }
                SheerResponse.ShowModalDialog(options.ToUrlString().ToString(), true);
                args.WaitForPostBack();
            }
            else
            {
                if (args.Result != null)
                {
                    Value = args.Result;
                    Sitecore.Context.ClientPage.ClientResponse.Refresh(Parent);
                    Sitecore.Context.ClientPage.ClientResponse.Eval("RefreshPickerSize()");
                }
            }
        }

    }
}