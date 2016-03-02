using MvvmCross.Platform.IoC;
using PokerHands.Core.ViewModels;

namespace PokerHands.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HandsViewModel>();
        }
    }
}
