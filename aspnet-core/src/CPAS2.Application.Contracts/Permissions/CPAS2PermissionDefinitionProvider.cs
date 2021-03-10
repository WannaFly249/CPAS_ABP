using CPAS2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CPAS2.Permissions
{
    public class CPAS2PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CPAS2Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CPAS2Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CPAS2Resource>(name);
        }
    }
}
