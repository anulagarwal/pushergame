using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Attribues")]
    [SerializeField] float moveSpeed;
    [SerializeField] bool canMove;
    [SerializeField] Vector3 moveVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.Translate(moveVector * moveSpeed * Time.deltaTime);
        }
    }
}
