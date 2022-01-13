using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{

    public GameObject nonDistorted;
    public GameObject distorted;
    public GameObject door;

   
    void OnTriggerEnter(Collider other)
    {
        nonDistorted.SetActive(true);
        distorted.SetActive(false);
        door.SetActive(false);
    }
}
