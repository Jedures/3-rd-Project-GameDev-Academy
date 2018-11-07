using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Animator anim;
    public float HP = 100;

    private void Start() {
        anim = GetComponent<Animator>();
    }

    public void Hit(float damage) {
        HP -= damage;

        if(HP > 0) {
            anim.Play("enemy_hit");
        } else {
            anim.Play("enemy_die");
            gameObject.GetComponent<Rigidbody2D>().simulated = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        }
    }

}
