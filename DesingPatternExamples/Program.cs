using DesingPatternExamples.Factory;

CellPhoneFactory factory = new CellPhoneFactory();

ICellPhone myNewPhone = factory.CreateCellPhone("ios");
myNewPhone?.DownloadApps("Whatsapp");

ICellPhone myNewWorkPhone = factory.CreateCellPhone("android");
myNewPhone?.MakePhotos();


ICellPhone myOldPhone = factory.CreateCellPhone("aaa");
myOldPhone?.MakePhotos();