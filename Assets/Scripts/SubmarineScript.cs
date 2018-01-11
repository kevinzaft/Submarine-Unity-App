using UnityEngine;
using System.Collections;

public class SubmarineScript : MonoBehaviour {
    private CharacterController cControl;
    public Transform submarineHolder;
    public float speed;
    public float rotationSpeed;
    public Transform fireSpot;
    public GameObject missile;
	// Use this for initialization
	void Start () {
        cControl = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        cControl.Move(speed * submarineHolder.forward * Time.deltaTime); //we multiply by deltaTime to set speed by time
                                                                         //and not how fast the machine can go
        submarineHolder.rotation = Quaternion.Slerp(submarineHolder.rotation, Camera.main.transform.rotation, Time.deltaTime * rotationSpeed);

        if (GvrViewer.Instance.Triggered)
        {
            Instantiate(missile, fireSpot.position, fireSpot.rotation);
        }

    }
}
