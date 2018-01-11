using UnityEngine;
using System.Collections;

public class MissileController : MonoBehaviour {
    public float speed;
    public int distance;
    public GameObject explosion;
    public GameObject flash;

    // Use this for initialization
    void Start () {
        Instantiate(flash, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * speed;
        distance++;

        if (distance > 420)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(other.gameObject);
            int amountLeft = GameObject.FindGameObjectsWithTag("Destroy").Length - 1;
            
            if (amountLeft < 1)
            {
                UIHelper.ChangeText("You Win!");
            }
            else
            {
                UIHelper.ChangeText(amountLeft + " Bombs Left");
            }
        }
        Destroy(gameObject);
    }
}
