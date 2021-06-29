using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(deadCount());
    }

    private IEnumerator deadCount()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
