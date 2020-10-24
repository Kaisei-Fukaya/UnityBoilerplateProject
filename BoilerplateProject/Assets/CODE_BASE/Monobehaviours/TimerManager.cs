using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KaiseiBoilerplate
{
    public class TimerManager : MonoBehaviourSingleton<TimerManager>
    {
        Timers timers;

        void Initailize()
        {
            timers = new Timers();
            //print("Timers initialized");
        }

        public void ClearAllTimers()
        {
            StopAllCoroutines();
        }

        public void StartTimer(float timeLength, IUsingTimer timerUser)
        {
            if (timers == null)
            {
                Initailize();
            }

            StartCoroutine(timers.Timer(timeLength, timerUser));
        }
    }
}
