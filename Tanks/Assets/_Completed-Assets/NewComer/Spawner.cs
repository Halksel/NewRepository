using System;
using System.Collections;
using UnityEngine;

namespace Complete
{
    public class Spawner : MonoBehaviour
    {
        public GameObject m_SpawnItem;
        public GameObject m_SpawnPoint;
        public Vector3 m_offset;
        public int m_SpawnInterval = 0;


        private Transform[] m_Points;

        // Use this for initialization
        void Start()
        {
            m_Points = m_SpawnPoint.GetComponentsInChildrenWithoutSelf<Transform>();
            StartCoroutine(Spawn());
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator Spawn()
        {
            while (true)
            {
                if (m_SpawnInterval <= 0)
                {
                    throw new ArgumentOutOfRangeException("m_SpawnInterval", "not Positive number");
                }
                yield return new WaitForSeconds(m_SpawnInterval);
                var obj = Instantiate(m_SpawnItem);
                obj.transform.position = m_Points.GetRandomItem<Transform>().position + m_offset;
            }
        }
    }
}
