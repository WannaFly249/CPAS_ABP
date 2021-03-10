using Volo.Abp.Settings;

namespace CPAS2.Settings
{
    public class CPAS2SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CPAS2Settings.MySetting1));
        }
    }
}
