using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Complete
{
    public class Mine : MonoBehaviour
    {
        public float m_ExplosionRange;
        public float m_Damage;
        private int m_MinedPlayer = 0; 
        private List<GameObject> m_Players;
        private GameObject m_Owner;
        // Use this for initialization
        void Start()
        {
            m_Players = new List<GameObject>();
            m_Players = GameObject.FindGameObjectsWithTag("Player").ToList();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) {
                Explode();
            }
            transform.rotation = Quaternion.LookRotation(m_Owner.transform.position);
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Untagged") return;
            Explode();
        }
        private void Explode() {
            foreach (var player in m_Players)
            {
                var distance = Vector3.Distance(transform.position, player.transform.position);
                if (distance > m_ExplosionRange) continue;
                player.SafeGetComponent<TankHealth>().TakeDamage(m_Damage * (1f - distance / m_ExplosionRange));
            }
                Destroy(gameObject);
        }
        public void OwnerRegisterd(int id, GameObject _player) {
            m_MinedPlayer = id;
            m_Owner = _player;
            gameObject.layer = LayerMask.NameToLayer("Player" + id.ToString() + "View");
        }
    }
}
