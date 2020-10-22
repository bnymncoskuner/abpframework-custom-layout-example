using Volo.Abp.Settings;

namespace CustomLayouts.Settings
{
    public class CustomLayoutsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CustomLayoutsSettings.MySetting1));
        }
    }
}
