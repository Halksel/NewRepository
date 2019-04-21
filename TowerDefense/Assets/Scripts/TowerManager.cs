using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : SingletonMonoBehaviourFast<TowerManager> {

	public List<Tower> towers;
	public List<GameObject> templeteTowers;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        InputManager.Instance.TowerSelectInput();
	}
	public void Spawn(){
        var obj = Instantiate(templeteTowers[0]);
        obj.transform.position = new Vector3(0.0f,0.0f,0.0f);
        var tower = obj.GetComponent<Tower>();
        towers.Add(tower);
	}
}
