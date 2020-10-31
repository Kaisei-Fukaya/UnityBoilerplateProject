using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KaiseiBoilerplate
{
    public interface IUsingTimer
    {
        void TimerFinished();
    }

    public class Timers
	{
		public IEnumerator Timer(float timeLength, IUsingTimer timerUser)
        {
            float time = 0f;

            //Debug.Log("Timer Started");

            while (time < timeLength)
            {
                time += Time.deltaTime;
                yield return null;
            }
            timerUser.TimerFinished();
        }
	}

    public class StopWatch
    {
        public float time { get; private set; } = 0f;
        bool _isGoing;

        public IEnumerator Begin(IUsingTimer timerUser)
        {
            _isGoing = true;

            while (_isGoing)
            {
                time += Time.deltaTime;
                yield return null;
            }
        }

        public void Pause()
        {
            _isGoing = false;
        }

        public void Resume()
        {
            _isGoing = true;
        }

        public void Reset()
        {
            time = 0f;
            _isGoing = false;
        }
    }
}
