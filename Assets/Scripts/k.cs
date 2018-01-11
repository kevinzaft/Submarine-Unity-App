using UnityEngine;
using System.Collections;

public class k : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("DoDestory", 2);
	}
	
    void DoDestory()
    {
        Destroy(gameObject);
    }
}
