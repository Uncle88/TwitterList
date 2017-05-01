using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using TwitterList.Authentication;
using TwitterList.ViewModels;

namespace TwitterList
{
    public class App : MvxApplication
    {
        public App()
        {
            //Mvx.RegisterType<IAuthenticationService, CoreAuthenticationService>();
            //Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<AuthViewModel>());

            //var auth = Mvx.IocConstruct()

            //CreatableTypes()
            //.EndingWith("Service")
            //.AsInterfaces()
            //.RegisterAsLazySingleton();

            //RegisterAppStart<ViewModels.AuthViewModel>;
            //Mvx.RegisterType<IAuthenticationService>();

            //Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<AuthViewModel>());
        }

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<ViewModels.AuthViewModel>();
            Mvx.RegisterSingleton(() =>
{
    var provider = Mvx.IocConstruct<IAuthenticationService>();
    return provider;
});
        }
    }
}
