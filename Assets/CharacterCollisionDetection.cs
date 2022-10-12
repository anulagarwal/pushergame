using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisionDetection : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        if(collision.gameObject.tag == "EnemyBase")
        {
            collision.gameObject.GetComponent<EnemyBase>().ReduceHealth(1);
            Destroy(gameObject);
        }
    }
}
