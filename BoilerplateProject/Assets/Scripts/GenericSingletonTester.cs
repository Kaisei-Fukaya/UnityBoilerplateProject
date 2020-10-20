using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KaiseiBoilerplate;

public class GenericSingletonTester : MonoBehaviour, IUsingTimer
{
    public void TimerFinished()
    {
        print("timer finished");
    }

    // Start is called before the first frame update
    void Start()
    {
        var t1 = TestSingleton.Instance;
        var t2 = TestSingleton.Instance;
        var t3 = TestSingleton.Instance;

        Vector3 vectorStart = Vector3.zero;
        Vector3 vectorTarget = new Vector3(10f, 4f, 19f);

        Vector3 normalizedDirection = vectorStart.GetDirectionTo(vectorTarget);
        Vector3 directionWithLength = vectorStart.GetDirectionToWithLength(vectorTarget);

        Debug.Log(normalizedDirection + " normalized direction");
        Debug.Log(directionWithLength + " direction with length");

        TimerManager timerManager = TimerManager.Instance;
        timerManager.StartTimer(3f, this);
    }
}

public class TestSingleton : Singleton<TestSingleton>
{

}
