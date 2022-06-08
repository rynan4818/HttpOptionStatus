using BeatSaberMarkupLanguage;
using HMUI;

namespace HttpOptionStatus.Views
{
    internal class HOSSettingFlowCoordinator : FlowCoordinator
    {
        public HOSSettingViewController _view = null;
        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (firstActivation)
            {
                SetTitle("Http Option Status");
                showBackButton = true;

                if (_view == null)
                    _view = BeatSaberUI.CreateViewController<HOSSettingViewController>();

                ProvideInitialViewControllers(_view);
            }
        }
        protected override void BackButtonWasPressed(ViewController topViewController)
        {
            BeatSaberUI.MainFlowCoordinator.DismissFlowCoordinator(this, null, ViewController.AnimationDirection.Horizontal);
        }
        public void ShowFlow()
        {
            var _parentFlow = BeatSaberUI.MainFlowCoordinator.YoungestChildFlowCoordinatorOrSelf();
            BeatSaberUI.PresentFlowCoordinator(_parentFlow, this);
        }

    }
}
