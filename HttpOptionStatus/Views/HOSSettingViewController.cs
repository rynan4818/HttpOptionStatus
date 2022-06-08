using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using HttpOptionStatus.Configuration;

namespace HttpOptionStatus.Views
{
    [HotReload(RelativePathToLayout = @"./HOSSettingViewController.bsml")]
    [ViewDefinition("HttpOptionStatus.Views.HOSSettingViewController.bsml")]
    internal class HOSSettingViewController : BSMLAutomaticViewController
    {
        PluginConfig config = PluginConfig.Instance;
    }
}
