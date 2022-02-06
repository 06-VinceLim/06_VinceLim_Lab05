using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPartical : MonoBehaviour
{

    public GameObject Peffects;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(Peffects, transform.position, transform.rotation);
        }
    }
}
