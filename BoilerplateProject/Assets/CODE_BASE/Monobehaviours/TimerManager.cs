using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KaiseiBoilerplate
{
    public class TimerManager : MonoBehaviourSingleton<TimerManager>
    {
        Timers timers;
        StopWatch stopWatch;

        private void Update()
        {
            print(stopWatch.time);
        }

        void Initailize()
        {
            timers = new Timers();
            stopWatch = new StopWatch();
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

        public void StartStopWatch(IUsingTimer timerUser)
        {
            if (stopWatch == null)
            {
                Initailize();
            }

            StartCoroutine(stopWatch.Begin(timerUser));
        }
    }
}
