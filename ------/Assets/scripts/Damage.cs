using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{
    public GameObject Enemy;
    // Use this for initialization
    void OntriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "theBullet")
        {
            Destroy(Enemy);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}