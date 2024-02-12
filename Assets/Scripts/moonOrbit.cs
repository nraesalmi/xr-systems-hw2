using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonOrbit : MonoBehaviour
{

    public Transform planet;

    void Update()
    {
        planet.Rotate(Vector3.up, 10f * Time.deltaTime);
    }
}
