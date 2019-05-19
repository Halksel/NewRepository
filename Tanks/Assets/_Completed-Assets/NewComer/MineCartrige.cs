using System.Collections;
using UnityEngine;

namespace Complete {
    public class MineCartrige : MonoBehaviour
    {

        private Material m_Material;
        public int m_BlinkTime;
        public int m_VanishTime;
        public Shader m_Blinker;
        // Use this for initialization
        void Start()
        {
            this.m_Material = GetComponent<Renderer>().material;

            StartCoroutine(Blink());
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Player")
            {
                var tankShooting = collision.gameObject.GetComponent<TankShooting>();
                tankShooting.AddMine();
                Destroy(gameObject);
            }
        }

        IEnumerator Blink()
        {
            yield return new WaitForSeconds(m_BlinkTime);
            var col = m_Material.color;
            var mat = GetComponent<MeshRenderer>().material.shader = m_Blinker;
            yield return new WaitForSeconds(m_VanishTime);
            Destroy(gameObject);
        }
    }
}
