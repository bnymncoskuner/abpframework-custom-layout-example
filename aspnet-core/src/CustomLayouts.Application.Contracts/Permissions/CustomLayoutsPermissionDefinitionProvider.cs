using CustomLayouts.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CustomLayouts.Permissions
{
    public class CustomLayoutsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CustomLayoutsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CustomLayoutsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CustomLayoutsResource>(name);
        }
    }
}
