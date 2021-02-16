using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 6.0f;
    public float damage = 25;
    private float downBorder = -6;
    private PlayerController playerScript;

    private void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void FixedUpdate()
    {
        if (!playerScript.gameIsOver)
        {
            gameObject.transform.Translate(Vector3.down * (Time.deltaTime * speed));
            if (gameObject.transform.position.y < downBorder) Destroy(gameObject);
        }
    }
}
