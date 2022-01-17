using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Animator anim;
    public GameObject leftT;
    public GameObject rightT;
    private bool moveRight = true;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        transform.position = leftT.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.LookAt(rightT.transform);
            transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);
            if(Vector3.Distance(transform.position, rightT.transform.position) <= .5f)
            {
                moveRight = false;
            }
        }
        else
        {
            transform.LookAt(leftT.transform);
            transform.position = new Vector3(transform.position.x + (-speed * Time.deltaTime), transform.position.y, transform.position.z);
            if (Vector3.Distance(transform.position, leftT.transform.position) <= .5f)
            {
                moveRight = true;
            }
        }
    }
}
