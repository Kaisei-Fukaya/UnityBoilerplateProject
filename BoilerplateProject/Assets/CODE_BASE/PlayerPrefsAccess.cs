using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KaiseiBoilerplate
{
	public class PlayerPrefsAccess : Singleton<PlayerPrefsAccess>
	{
        public void SaveIntValue(string keyName, int value)
        {
            PlayerPrefs.SetInt(keyName, value);
        }
        public void SaveFloatValue(string keyName, float value)
        {
            PlayerPrefs.SetFloat(keyName, value);
        }
        public void SaveStringValue(string keyName, string value)
        {
            PlayerPrefs.SetString(keyName, value);
        }
        public int LoadIntValue(string keyName)
        {
            return PlayerPrefs.GetInt(keyName);
        }
        public float LoadFloatValue(string keyName)
        {
            return PlayerPrefs.GetFloat(keyName);
        }
        public string LoadStringValue(string keyName)
        {
            return PlayerPrefs.GetString(keyName);
        }
        public void ClearAllData()
        {
            PlayerPrefs.DeleteAll();
        }
        public void ClearKey(string keyName)
        {
            PlayerPrefs.DeleteKey(keyName);
        }
    }
}
