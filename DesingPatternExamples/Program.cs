using DesingPatternExamples.AbstractFactory.Factories;
using DesingPatternExamples.Factory;

CellPhoneFactory factory = new CellPhoneFactory();

ICellPhone myNewPhone = factory.CreateCellPhone("ios");
myNewPhone?.DownloadApps("Whatsapp");

ICellPhone myNewWorkPhone = factory.CreateCellPhone("android");
myNewPhone?.MakePhotos();


ICellPhone myOldPhone = factory.CreateCellPhone("aaa");
myOldPhone?.MakePhotos();


////////
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