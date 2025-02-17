using Models;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Core.DI
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            Debug.Log("GameLifetimeScope started");
            //Register GridSystem as singleton
            builder.Register<GridSystem>(Lifetime.Singleton);
            
            //Register GameManager as Entry Point
            builder.RegisterEntryPoint<GameManager>();
        }
    }
}
