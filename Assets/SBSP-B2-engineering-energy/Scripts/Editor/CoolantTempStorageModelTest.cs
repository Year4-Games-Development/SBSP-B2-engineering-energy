using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class CoolantTempStorageModelTest
{
    [Test]
    public void NoArgConstructorInitializationTest()
    {
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel();
        Assert.AreEqual("", ctsm.GetCoolantType());
        Assert.AreEqual(0.0f, ctsm.GetAvailableCoolant());
        Assert.AreEqual(0.0f, ctsm.GetMinimumStorage());
        Assert.AreEqual(0.0f, ctsm.GetStorageMaxCapacity());
        Assert.AreEqual(false, ctsm.GetStorageAtMaxCapacity());
        Assert.AreEqual(false, ctsm.GetStorageEmpty());
        Assert.AreEqual(false, ctsm.GetCoolantReady());
        Assert.AreEqual(false, ctsm.GetCoolantNeeded());
        Assert.AreEqual(0.0f, ctsm.GetCoolantPackage());
    }

    [Test]
    public void ConstructorWithArgsIntializationTest()
    {
        string type = "test-type";
        float available = 5.0f,
            minStorage = 3.0f,
            maxStorage = 20.0f,
            package = 3.0f;
        bool atMax = false,
            empty = false,
            ready = false,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available, minStorage, maxStorage, atMax, empty, ready, needed, package);
        Assert.AreEqual(type, ctsm.GetCoolantType());
        Assert.AreEqual(available, ctsm.GetAvailableCoolant());
        Assert.AreEqual(minStorage, ctsm.GetMinimumStorage());
        Assert.AreEqual(maxStorage, ctsm.GetStorageMaxCapacity());
        Assert.AreEqual(atMax, ctsm.GetStorageAtMaxCapacity());
        Assert.AreEqual(empty, ctsm.GetStorageEmpty());
        Assert.AreEqual(ready, ctsm.GetCoolantReady());
        Assert.AreEqual(needed, ctsm.GetCoolantNeeded());
        Assert.AreEqual(package, ctsm.GetCoolantPackage());
    }

    [Test]
    public void SetCoolantTypeTest()
    {
        string type1 = "test-type-1",
            type2 = "test-type-2";
        float available = 5.0f,
            minStorage = 3.0f,
            maxStorage = 20.0f,
            package = 3.0f;
        bool atMax = false,
            empty = false,
            ready = false,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type1, available, minStorage, maxStorage, atMax, empty, ready, needed, package);
        ctsm.SetCoolantType(type2);
        Assert.AreEqual(type2, ctsm.GetCoolantType());
    }

    [Test]
    public void SetAvailableCoolantTest()
    {
        string type = "test-type";
        float available1 = 5.0f,
            available2 = 4.4f,
            minStorage = 3.0f,
            maxStorage = 20.0f,
            package = 3.0f;
        bool atMax = false,
            empty = false,
            ready = false,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available1, minStorage, maxStorage, atMax, empty, ready, needed, package);
        ctsm.SetAvailableCoolant(available2);
        Assert.AreEqual(available2, ctsm.GetAvailableCoolant());
    }

    [Test]
    public void SetMinimumStorageTest()
    {
        string type = "test-type";
        float available = 5.0f,
            minStorage1 = 3.0f,
            minStorage2 = 1.0f,
            maxStorage = 20.0f,
            package = 3.0f;
        bool atMax = false,
            empty = false,
            ready = false,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available, minStorage1, maxStorage, atMax, empty, ready, needed, package);
        ctsm.SetMinimumStorage(minStorage2);
        Assert.AreEqual(minStorage2, ctsm.GetMinimumStorage());
    }

    [Test]
    public void SetStorageMaxCapacityTest()
    {
        string type = "test-type";
        float available = 5.0f,
            minStorage = 3.0f,
            maxStorage1 = 20.0f,
            maxStorage2 = 33.3f,
            package = 3.0f;
        bool atMax = false,
            empty = false,
            ready = false,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available, minStorage, maxStorage1, atMax, empty, ready, needed, package);
        ctsm.SetStorageMaxCapacity(maxStorage2);
        Assert.AreEqual(maxStorage2, ctsm.GetStorageMaxCapacity());
    }

    [Test]
    public void SetStorageAtMaxCapacityTest()
    {
        string type = "test-type";
        float available = 5.0f,
            minStorage = 3.0f,
            maxStorage = 20.0f,
            package = 3.0f;
        bool atMax1 = false,
            atMax2 = true,
            empty = false,
            ready = false,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available, minStorage, maxStorage, atMax1, empty, ready, needed, package);
        ctsm.SetStorageAtMaxCapacity(atMax2);
        Assert.AreEqual(atMax2, ctsm.GetStorageAtMaxCapacity());
    }

    [Test]
    public void SetStorageEmptyTest()
    {
        string type = "test-type";
        float available = 5.0f,
            minStorage = 3.0f,
            maxStorage = 20.0f,
            package = 3.0f;
        bool atMax = false,
            empty1 = false,
            empty2 = true,
            ready = false,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available, minStorage, maxStorage, atMax, empty1, ready, needed, package);
        ctsm.SetStorageEmpty(empty2);
        Assert.AreEqual(empty2, ctsm.GetStorageEmpty());
    }

    [Test]
    public void SetCoolantReadyTest()
    {
        string type = "test-type";
        float available = 5.0f,
            minStorage = 3.0f,
            maxStorage = 20.0f,
            package = 3.0f;
        bool atMax = false,
            empty = false,
            ready1 = false,
            ready2 = true,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available, minStorage, maxStorage, atMax, empty, ready1, needed, package);
        ctsm.SetCoolantReady(ready2);
        Assert.AreEqual(ready2, ctsm.GetCoolantReady());
    }

    [Test]
    public void SetCoolantNeededTest()
    {
        string type = "test-type";
        float available = 5.0f,
            minStorage = 3.0f,
            maxStorage = 20.0f,
            package = 3.0f;
        bool atMax = false,
            empty = false,
            ready = false,
            needed1 = false,
            needed2 = true;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available, minStorage, maxStorage, atMax, empty, ready, needed1, package);
        ctsm.SetCoolantNeeded(needed2);
        Assert.AreEqual(needed2, ctsm.GetCoolantNeeded());
    }

    [Test]
    public void SetCoolantPackage()
    {
        string type = "test-type";
        float available = 5.0f,
            minStorage = 3.0f,
            maxStorage = 20.0f,
            package1 = 3.0f,
            package2 = 6.5f;
        bool atMax = false,
            empty = false,
            ready = false,
            needed = false;
        CoolantTempStorageModel ctsm = new CoolantTempStorageModel(type, available, minStorage, maxStorage, atMax, empty, ready, needed, package1);
        ctsm.SetCoolantPackage(package2);
        Assert.AreEqual(package2, ctsm.GetCoolantPackage());
    }
}
