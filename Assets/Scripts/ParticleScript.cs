using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public int delay;
    void Start()
    {
        StartCoroutine(deadCount());
    }

    private IEnumerator deadCount()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
