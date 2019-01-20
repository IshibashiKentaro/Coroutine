using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp_One : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(-4, 0, 0);
    }
}
