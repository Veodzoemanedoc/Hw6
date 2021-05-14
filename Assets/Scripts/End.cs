using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<player>();
        if (player != null)
        {
            Application.Quit();
        }

    }
}
