using DesingPatternExamples.AbstractFactory.Factories;
using DesingPatternExamples.Factory;
using DesingPatternExamples.Singleton;

////
///TODO: Beautify main program
///



void CreateProduct(CellPhoneFactory factory, string os) 
{
    ICellPhone myNewPhone = factory.CreateCellPhone(os);
    myNewPhone?.DownloadApps("Whatsapp");
    myNewPhone?.CallNumber(123456);
    myNewPhone?.MakePhotos();
}

CellPhoneFactory factory = new();
CreateProduct(factory, "android");
CreateProduct(factory, "ios");
CreateProduct(factory, "notValidOption");

Console.WriteLine();
///
///Abstract factory
///


void GetMakeDataFromFactory(IAbstractFactory factory) 
{
    var headphones = factory.CreateHeadphones();
    var washingMachine = factory.CreateWashingMachine();
    var tv = factory.CreateTv();

    headphones.MakeName();
    washingMachine.MakeName();
    tv.MakeName();
}

GetMakeDataFromFactory(new SamsungFactory());

GetMakeDataFromFactory(new LGFactory());

GetMakeDataFromFactory(new SonyFactory());
Console.WriteLine();
/// 
/// Singleton
/// 

Singleton realSingleton =  Singleton.GetInstance();
Singleton realSingleton2 = Singleton.GetInstance();