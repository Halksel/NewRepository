using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : SingletonMonoBehaviourFast<InputManager>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CameraInput(ref float dx,ref float dy)
    {
        dx = Input.GetAxis("Horizontal");
        dy = Input.GetAxis("Vertical");
    }

    public int TowerSelectInput()
    {
        for(int i =0;  i < 10; ++i)
        {
            if(Input.GetKeyDown((KeyCode)(KeyCode.Alpha0 + i))){
                Debug.Log(i);
                return i;
            }
        }
        return -1;
    }
}
