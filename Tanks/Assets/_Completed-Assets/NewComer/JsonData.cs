using UnityEngine;
using System.Collections.Generic;


namespace Complete
{
    [System.Serializable]
    public class TankData : ISerializationCallbackReceiver
    {
        [SerializeField]
        public Vector3[] TanksPosition;
        [SerializeField]
        public Quaternion[] TanksRotation;
        [SerializeField]
        public Vector3[] ShellsPosition;
        [SerializeField]
        public Quaternion[] ShellsRotation;
        [SerializeField]
        public string[] UsersID;
        [SerializeField]
        public string[] UsersName;
        public Dictionary<int, Vector3> d;
        [SerializeField]
        public List<int> d_keys;
        [SerializeField]
        public List<Vector3> d_values;

        public void OnBeforeSerialize()
        {
            d_keys = new List<int>(d.Keys);
            d_values = new List<Vector3>(d.Values);
        }

        public void OnAfterDeserialize()
        {
            var count = Mathf.Min(d_keys.Count, d_values.Count);
            d = new Dictionary<int, Vector3>();
            for (int i = 0; i < count; ++i) {
                d.Add(d_keys[i],d_values[i]);
            }
        }
    }

    [System.Serializable]
    public class UserData
    {
        [SerializeField]
        public string UserID;
        [SerializeField]
        public string UserName;
        [SerializeField]
        public int WinCount;
        [SerializeField]
        public int LoseCount;
        [SerializeField]
        public int MaxRank;
        public int CompareTo(object obj)
        {
            UserData ud = obj as UserData;
            return this.WinCount.CompareTo(ud.WinCount);
        }
    }
}
