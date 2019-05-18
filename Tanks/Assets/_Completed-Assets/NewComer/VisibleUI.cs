using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class VisibleUI : MonoBehaviour
    {
        public bool  m_EnabledUI;
        private Image m_Image;
        // Use this for initialization
        void Start()
        {
            m_Image = gameObject.GetComponent<Image>();
        }

        // Update is called once per frame
        void Update()
        {
            m_Image.enabled = m_EnabledUI;
        }
    }
}