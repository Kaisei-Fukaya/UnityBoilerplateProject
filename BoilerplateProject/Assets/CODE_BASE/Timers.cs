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
}
