using System.Collections;
using UnityEngine;
using System.Collections.Generic;

namespace Complete {
    public class GateManager : MonoBehaviour {
        public float m_Probability;
        public float m_CoolTime;
        public Vector3 m_Offset;
        public GameObject m_FailedPoint;
        public float m_Duration;
        public Gate[] m_Gates;
        private float m_TimeCount;
        public Shader m_Blinker;
        // Use this for initialization
        void Start() {
            for (int i = 0; i < m_Gates.Length; ++i)
            {
                m_Gates[i].id = i;
                m_Gates[i].m_Manager = this;
            }
            m_TimeCount = m_CoolTime;
            var ud = new TankData();
            var data = new Dictionary<int, Vector3>();
            data.Add( 0, Vector3.zero);
            ud.d = data;
            var str = JsonUtility.ToJson(ud);
            var json = JsonUtility.FromJson<TankData>(str);
            Debug.Log(json.d);
        }

        // Update is called once per frame
        void Update() {
            m_TimeCount += Time.deltaTime;
        }
        public IEnumerator Warp(int id, GameObject obj)
        {
            if (m_TimeCount < m_CoolTime) yield break;
            MeshRenderer[] mats = obj.GetComponentsInChildren<MeshRenderer>();
            Dictionary<Material, Shader> dic = new Dictionary<Material,Shader>();
            foreach(var mat in mats)
            {
                foreach (var m in mat.materials) {
                    dic.Add( m,m.shader);
                    m.shader = m_Blinker;
                }
            }
            SetBoolInObject(obj, false);
            yield return new WaitForSeconds(m_Duration);
            SetBoolInObject(obj, true);
            foreach(var mat in mats)
            {
                foreach (var m in mat.materials) {
                    m.shader = dic[m];
                }
            }
            var y = obj.transform.position.y;
            obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
            if (Random.Range(0f, 1f) < m_Probability)
            {

                obj.transform.position = m_FailedPoint.transform.position;
            }
            else
            {
                obj.transform.position = m_Gates[1 - id].gameObject.transform.position + m_Offset;
            }
            obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
            obj.transform.position = new Vector3(obj.transform.position.x, y, obj.transform.position.z);
            m_TimeCount = 0f;
            yield return null;
        }
        private void SetBoolInObject(GameObject obj, bool f) {
            obj.GetComponent<TankMovement>().IsMove   = f;
            obj.GetComponent<TankShooting>().IsFire   = f;
            obj.GetComponent<TankHealth>().IsHurt     = f;
            obj.GetComponent<Rigidbody>().isKinematic = !f;
        }
    }
}
