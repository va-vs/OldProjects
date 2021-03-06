﻿using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace VSProject.PlanManager
{
    [ToolboxItemAttribute(false)]
    public class PlanManager : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/15/VSProject/PlanManager/PlanManagerUserControl.ascx";

        protected override void CreateChildControls()
        {
            PlanManagerUserControl control = Page.LoadControl(_ascxPath) as PlanManagerUserControl;
            if (control != null)
                control.webObj = this;
            Controls.Add(control);
        }
    }
}
