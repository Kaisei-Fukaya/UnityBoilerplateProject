using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using KaiseiBoilerplate;

namespace Tests
{
    public class SingletonTests
    {

        [Test]
        public void Singleton_InstanceAccess_ReturnsSameInstanceEachTime()
        {
            TestSingleton referenceCall_1 = TestSingleton.Instance;
            TestSingleton referenceCall_2 = TestSingleton.Instance;

            Assert.AreSame(referenceCall_1, referenceCall_2);
        }
    }
}
