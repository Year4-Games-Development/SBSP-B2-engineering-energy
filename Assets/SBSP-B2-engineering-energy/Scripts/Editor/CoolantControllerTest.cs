using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class CoolantControllerTest
{
    /*[Test]
    public void CoolantTypeBeingUsedTest()
    {
        CoolantController cc = new CoolantController();
        string type = cc.coolant.GetCoolantType();
        cc.coolantTypeBeingUsed();
        Assert.AreEqual(type, cc.tempStorage.GetCoolantType());
    }

    [Test]
    public void CoolantTempStroageInfoWithMaxCapacityTest()
    {
        CoolantController cc = new CoolantController();
        float maxCap = 100f;
        float available = maxCap;
        cc.tempStorage.SetStorageMaxCapacity(maxCap);
        cc.tempStorage.SetAvailableCoolant(available);

        cc.coolantTempStroageInfo();

        Assert.IsTrue(cc.tempStorage.GetStorageAtMaxCapacity());
    }

    [Test]
    public void CoolantNeededCalcWithCoolantNeededTest()
    {
        CoolantController cc = new CoolantController();
        float available = 100f,
            needed = 30f;
        cc.tempStorage.SetAvailableCoolant(available);
        cc.tempStorage.SetCoolantNeeded(true);
        cc.neededCoolant = needed;
        float remaining = available - needed;

        cc.coolantNeededCalc();

        Assert.AreEqual(remaining, cc.tempStorage.GetAvailableCoolant());
        Assert.IsFalse(cc.tempStorage.GetCoolantNeeded());
    }

    [Test]
    public void CoolantNeededCalcWithCoolantNotNeededTest()
    {
        CoolantController cc = new CoolantController();
        float available = 100f,
            needed = 30f;
        cc.tempStorage.SetAvailableCoolant(available);
        cc.tempStorage.SetCoolantNeeded(false);
        cc.neededCoolant = needed;

        cc.coolantNeededCalc();

        Assert.AreEqual(available, cc.tempStorage.GetAvailableCoolant());
        Assert.IsFalse(cc.tempStorage.GetCoolantNeeded());
    }

    [Test]
    public void RetrieveCoolantFromTempStoresWithEmptyStorageTest()
    {
        CoolantController cc = new CoolantController();
        float min = 1f,
            available = 0f;
        cc.tempStorage.SetMinimumStorage(min);
        cc.tempStorage.SetAvailableCoolant(available);

        cc.retrieveCoolantFromTempStores();

        Assert.AreEqual(min, cc.tempStorage.GetAvailableCoolant());
        Assert.IsTrue(cc.tempStorage.GetStorageEmpty());
    }

    [Test]
    public void RetrieveCoolantFromTempStoresWithStorageNotEmptyPackageSizeBelow50Test()
    {
        CoolantController cc = new CoolantController();
        float available = 100f,
            needed = 20f,
            package = 10f;
        cc.tempStorage.SetAvailableCoolant(available);
        cc.tempStorage.SetCoolantPackage(package);

        cc.exampleOutsideConsumerMethod();
        cc.neededCoolant = needed;
        cc.retrieveCoolantFromTempStores();

        float newNeeded = needed - 1f,
            newPackage = package + 1f;

        Assert.AreEqual(newNeeded, cc.neededCoolant);
        Assert.AreEqual(newPackage, cc.tempStorage.GetCoolantPackage());
    }

    [Test]
    public void RetrieveCoolantFromTempStoresWithStorageNotEmptyPackageSizeAbove50Test()
    {
        CoolantController cc = new CoolantController();
        float available = 100f,
            package = 55f;
        cc.tempStorage.SetAvailableCoolant(available);
        cc.tempStorage.SetCoolantPackage(package);

        cc.exampleOutsideConsumerMethod();
        cc.retrieveCoolantFromTempStores();

        float newNeeded = 49f,
            newPackage = package + 1f;

        Assert.AreEqual(newNeeded, cc.neededCoolant);
        Assert.AreEqual(newPackage, cc.tempStorage.GetCoolantPackage());
        Assert.IsTrue(cc.tempStorage.GetCoolantReady());
    }*/
}
