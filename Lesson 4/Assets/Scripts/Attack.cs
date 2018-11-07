using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    public float damage = 20;

    void OnTriggerEnter2D(Collider2D collision) { 
        if(collision.gameObject.tag == "Enemy") {
            collision.gameObject.GetComponent<EnemyController>().Hit(damage);   
        }
    }

}
