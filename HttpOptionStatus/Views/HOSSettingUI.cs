using BeatSaberMarkupLanguage.MenuButtons;
using BeatSaberMarkupLanguage;
using Zenject;
using System;

namespace HttpOptionStatus.Views
{
    internal class HOSSettingUI : IInitializable, IDisposable
    {
        private bool _disposedValue;
        public static MenuButton theButton;
        public static HOSSettingFlowCoordinator flow = null;
        public void Initialize()
        {
            MenuButtons.instance.RegisterButton(theButton ??= new MenuButton("Http Option Status", "HTTPStatus Option", () =>
            {
                if (flow == null)
                    flow = BeatSaberUI.CreateFlowCoordinator<HOSSettingFlowCoordinator>();
                flow.ShowFlow();
            }, true));
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposedValue)
            {
                if (disposing)
                {
                    if (theButton != null)
                        MenuButtons.instance.UnregisterButton(theButton);
                }
                this._disposedValue = true;
            }
        }
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを 'Dispose(bool disposing)' メソッドに記述します
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
