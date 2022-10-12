using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] float spawnSpeed;
    [SerializeField] bool canSlide;
    [SerializeField] float slideSpeed;

    [Header("Component References")]
    [SerializeField] GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {               
                GameObject g = Instantiate(character, hit.point, Quaternion.identity);
            }
        }

        if (Input.GetMouseButton(0))
        {

        }

        if (Input.GetMouseButtonUp(0))
        {

        }
    }

    void SpawnCharacter(Vector3 pos)
    {

    }
}
