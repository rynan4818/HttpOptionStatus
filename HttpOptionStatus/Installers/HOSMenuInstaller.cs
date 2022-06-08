using HttpOptionStatus.Views;
using HttpOptionStatus.Models;
using Zenject;

namespace HttpOptionStatus.Installers
{
    public class HOSMenuInstaller : Installer
    {
        public override void InstallBindings()
        {
            //this.Container.BindInterfacesAndSelfTo<HttpOptionStatusController>().FromNewComponentOnNewGameObject().AsCached().NonLazy();
            this.Container.BindInterfacesAndSelfTo<HOSSettingUI>().AsSingle().NonLazy();
        }
    }
}
