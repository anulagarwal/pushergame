using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisionDetection : MonoBehaviour
{
    [SerializeField] CharacterType c;

    private void Start()
    {
        c = GetComponent<Character>().type;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "EnemyBase")
        {
            collision.gameObject.GetComponent<EnemyBase>().ReduceHealth(1);
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Tower")
        {
           // collision.gameObject.GetComponent<Tower>().AddCharacter(c);
           // Destroy(gameObject);
        }
    }
}
