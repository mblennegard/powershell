---
Module Name: PnP.PowerShell
title: Set-PnPSite
schema: 2.0.0
applicable: SharePoint Online
external help file: PnP.PowerShell.dll-Help.xml
online version: https://pnp.github.io/powershell/cmdlets/Set-PnPSite.html
---
 
# Set-PnPSite

## SYNOPSIS
Sets Site Collection properties.

## SYNTAX

### Set Properties
```powershell
Set-PnPSite [-Identity <String>] [-Classification <String>] [-DisableFlows] [-LogoFilePath <String>]
 [-Sharing <SharingCapabilities>] [-StorageMaximumLevel <Int64>] [-StorageWarningLevel <Int64>]
 [-AllowSelfServiceUpgrade] [-NoScriptSite] [-Owners <System.Collections.Generic.List`1[System.String]>]
 [-CommentsOnSitePagesDisabled] [-DefaultLinkPermission <SharingPermissionType>]
 [-DefaultSharingLinkType <SharingLinkType>] [-DefaultLinkToExistingAccess <Boolean>] [-DefaultLinkToExistingAccessReset] [-DisableAppViews <AppViewsPolicy>]
 [-DisableCompanyWideSharingLinks <CompanyWideSharingLinksPolicy>] [-DisableSharingForNonOwners]
 [-LocaleId <UInt32>] [-RestrictedToGeo <RestrictedToRegion>] [-SocialBarOnSitePagesDisabled]
 [-AnonymousLinkExpirationInDays <Int32>] [-OverrideTenantAnonymousLinkExpirationPolicy]
 [-MediaTranscription <MediaTranscriptionPolicyType>] [-SensitivityLabel <Guid>]
 [-Connection <PnPConnection>] [<CommonParameters>]
```

### Set Lock State
```powershell
Set-PnPSite [-Identity <String>] [-LockState <SiteLockState>] [-Wait] [-Connection <PnPConnection>] [<CommonParameters>]
```

## DESCRIPTION

## EXAMPLES

### EXAMPLE 1
```powershell
Set-PnPSite -Classification "HBI"
```

Sets the current site classification tag to HBI

### EXAMPLE 2
```powershell
Set-PnPSite -Classification $null
```

Unsets the current site classification tag

### EXAMPLE 3
```powershell
Set-PnPSite -DisableFlows
```

Disables Microsoft Flow for this site, and also hides the Flow button from the ribbon

### EXAMPLE 4
```powershell
Set-PnPSite -DisableFlows:$false
```

Enables Microsoft Flow for this site

### EXAMPLE 5
```powershell
Set-PnPSite -LogoFilePath c:\images\mylogo.png
```

Sets the logo if the site is a modern team site

### EXAMPLE 6
```powershell
Set-PnPSite -NoScriptSite $false
```

Allows custom script on a specific site. See [Allow or prevent custom script](https://docs.microsoft.com/sharepoint/allow-or-prevent-custom-script) for more information.

## PARAMETERS

### -AllowSelfServiceUpgrade
Specifies if the site administrator can upgrade the site collection

```yaml
Type: SwitchParameter
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AnonymousLinkExpirationInDays
{{ Fill AnonymousLinkExpirationInDays Description }}

```yaml
Type: Int32
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Classification
The classification tag to set. This is the old classification/labeling method. Set it to $null to remove the classification entirely.

```yaml
Type: String
Parameter Sets: (All)

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SensitivityLabel
The Microsoft Purview sensitivity label to set. This is the new classification/labeling method.

```yaml
Type: String
Parameter Sets: (All)

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommentsOnSitePagesDisabled
Specifies if comments on site pages are enabled or disabled

```yaml
Type: SwitchParameter
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Connection
Optional connection to be used by the cmdlet. Retrieve the value for this parameter by either specifying -ReturnConnection on Connect-PnPOnline or by executing Get-PnPConnection.

```yaml
Type: PnPConnection
Parameter Sets: (All)

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultLinkPermission
Specifies the default link permission for the site collection. None - Respect the organization default link permission. View - Sets the default link permission for the site to "view" permissions. Edit - Sets the default link permission for the site to "edit" permissions

```yaml
Type: SharingPermissionType
Parameter Sets: Set Properties
Accepted values: None, View, Edit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultSharingLinkType
Specifies the default link type for the site collection. None - Respect the organization default sharing link type. AnonymousAccess - Sets the default sharing link for this site to an Anonymous Access or Anyone link. Internal - Sets the default sharing link for this site to the "organization" link or company shareable link. Direct - Sets the default sharing link for this site to the "Specific people" link

```yaml
Type: SharingLinkType
Parameter Sets: Set Properties
Accepted values: None, Direct, Internal, AnonymousAccess

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultLinkToExistingAccess
When set to $true, the DefaultSharingLinkType will be overriden and the default sharing link will be All People with Existing Access link (which does not modify permissions). When set to $false (the default), the default sharing link type is controlled by the DefaultSharingLinkType parameter

```yaml
Type: Boolean
Parameter Sets: Set Properties
Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableAppViews

```yaml
Type: AppViewsPolicy
Parameter Sets: Set Properties
Accepted values: Unknown, Disabled, NotDisabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableCompanyWideSharingLinks

```yaml
Type: CompanyWideSharingLinksPolicy
Parameter Sets: Set Properties
Accepted values: Unknown, Disabled, NotDisabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableFlows
Disables Microsoft Flow for this site

```yaml
Type: SwitchParameter
Parameter Sets: (All)

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableSharingForNonOwners
Specifies to prevent non-owners from inviting new users to the site

```yaml
Type: SwitchParameter
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity

```yaml
Type: String
Parameter Sets: (All)
Aliases: Url

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocaleId
Specifies the language of this site collection.

```yaml
Type: UInt32
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LockState
Sets the lockstate of a site

```yaml
Type: SiteLockState
Parameter Sets: Set Lock State
Accepted values: Unlock, NoAccess, ReadOnly

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogoFilePath
Sets the logo of the site if it concerns a modern team site. Provide a full path to a local image file on your disk which you want to use as the site logo. The logo will be uploaded automatically to SharePoint. If you want to set the logo for a classic site, use Set-PnPWeb -SiteLogoUrl.

```yaml
Type: String
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoScriptSite
Specifies if a site allows custom script or not. See [Allow or prevent custom script](https://docs.microsoft.com/sharepoint/allow-or-prevent-custom-script) for more information.

```yaml
Type: SwitchParameter
Parameter Sets: Set Properties
Aliases: DenyAndAddCustomizePages

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverrideTenantAnonymousLinkExpirationPolicy
{{ Fill OverrideTenantAnonymousLinkExpirationPolicy Description }}

```yaml
Type: SwitchParameter
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owners
Specifies owner(s) to add as site collection administrators. They will be added as additional site collection administrators. Existing administrators will stay. Can be both users and groups.

```yaml
Type: System.Collections.Generic.List`1[System.String]
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestrictedToGeo
Specifies the Geo/Region restrictions of this site.

```yaml
Type: RestrictedToRegion
Parameter Sets: Set Properties
Accepted values: NoRestriction, BlockMoveOnly, BlockFull, Unknown

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sharing
Specifies what the sharing capabilities are for the site. Possible values: Disabled, ExternalUserSharingOnly, ExternalUserAndGuestSharing, ExistingExternalUserSharingOnly

```yaml
Type: SharingCapabilities
Parameter Sets: Set Properties
Accepted values: Disabled, ExternalUserSharingOnly, ExternalUserAndGuestSharing, ExistingExternalUserSharingOnly

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SocialBarOnSitePagesDisabled
Disables or enables the Social Bar for Site Collection.

```yaml
Type: SwitchParameter
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageMaximumLevel
Specifies the storage quota for this site collection in megabytes. This value must not exceed the company's available quota.

```yaml
Type: Int64
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageWarningLevel
Specifies the warning level for the storage quota in megabytes. This value must not exceed the values set for the StorageMaximumLevel parameter

```yaml
Type: Int64
Parameter Sets: Set Properties

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaTranscription
When the feature is enabled, videos can have transcripts generated on demand or generated automatically in certain scenarios. This is the default because the policy is default on. If a video owner decides they don’t want the transcript, they can always hide or delete it from that video. Possible values: `Enabled, Disabled`

```yaml
Type: MediaTranscriptionPolicyType
Parameter Sets: (All)
Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Wait
Wait for the operation to complete

```yaml
Type: SwitchParameter
Parameter Sets: Set Lock State

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

## RELATED LINKS

[Microsoft 365 Patterns and Practices](https://aka.ms/m365pnp)

