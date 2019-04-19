using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

	[SerializeField]
	private int _cost;
	public int cost{
		set { _cost = value;}
		get { return _cost; }
	}
	[SerializeField]
	private int _upgradeCost;
	public int upgradeCost{
		get { return (int)(_upgradeCost * (1 + 0.1f * level)); }
	}
	[SerializeField]
	private int _attack;
	public int attack{
		get { return (int)(_attack * (1 + 0.1f * level)); }
	}
	[SerializeField]
	private int _fireRate;
	public int fireRate{
		get { return (int)(_fireRate * (1 + 0.1f * level)); }
	}
	public bool isFire = false;
	public int level = 1;
	private SphereCollider range;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void AttackEnemy(){

	}

	IEnumerator FireControl(){
		 yield return new WaitForSeconds (1.0f);
	}
}
