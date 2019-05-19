using UnityEngine;
namespace Complete
{
    public class Gate : MonoBehaviour
    {
        public GateManager m_Manager;
        public int id;
        // Use this for initialization
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                StartCoroutine(routine: m_Manager.Warp(id, collision.gameObject));
            }
        }
    }
}
