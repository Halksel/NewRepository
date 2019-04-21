using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        float dx =0f, dy = 0f;
        InputManager.Instance.CameraInput(ref dx, ref dy);
        transform.Translate(dx, 0.0f, dy);
    }
}
