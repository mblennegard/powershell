﻿using System;
using System.Linq.Expressions;
using System.Management.Automation;
using Microsoft.SharePoint.Client;

namespace PnP.PowerShell.Commands.Site
{
    [Cmdlet(VerbsCommon.Get, "PnPSite")]
    public class GetSite : PnPRetrievalsCmdlet<Microsoft.SharePoint.Client.Site>
    {
        protected override void ExecuteCmdlet()
        {
            DefaultRetrievalExpressions = new Expression<Func<Microsoft.SharePoint.Client.Site, object>>[] { s => s.Url, s => s.CompatibilityLevel};
            var site = ClientContext.Site;
            ClientContext.Load(site, RetrievalExpressions);
            ClientContext.ExecuteQueryRetry();
            WriteObject(site);
        }
    }
}
