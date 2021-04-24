using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidyBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidyBody = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFacingRight())
        { 
            myRigidyBody.velocity = new Vector2(moveSpeed, 0f);
        }
        else 
        {
            myRigidyBody.velocity = new Vector2(-moveSpeed, 0f);
        }
        
    }
    bool isFacingRight()
    {
        return transform.localScale.x > 0;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidyBody.velocity.x)), 1f);

    }


}
