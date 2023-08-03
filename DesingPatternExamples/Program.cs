using DesingPatternExamples.CreationalDesingPatterns.AbstractFactory;
using DesingPatternExamples.CreationalDesingPatterns.Builder;
using DesingPatternExamples.CreationalDesingPatterns.Factory;
using DesingPatternExamples.Singleton;

#region Factory
FactoryClient factoryClient = new();
factoryClient.Demo();
#endregion

#region AbstractFactory
AbstractFactoryClient abstractFactoryClient = new();
abstractFactoryClient.Demo();
#endregion

#region Singleton
Singleton vaidSingleton = Singleton.GetInstance();
Singleton notValidSingleton = Singleton.GetInstance();
#endregion

#region Builder
BuilderClient builderClient = new();
builderClient.Demo();
#endregion