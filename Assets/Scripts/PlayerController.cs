using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool jump = false;
    public bool slide = false;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (0,0,0.1f);

        if (Input.GetKey("a"))
        {
            jump = true;
        }

        else {
            jump = false;

        }

        if (Input.GetKey("s"))
        {
            slide = true;
        }

        else
        {
            slide = false;

        }


        if (jump == true)
        {
            anim.SetBool("isJump", jump);
            transform.Translate(0, 0.4f, 0.1f);
        
        }
        else if (jump == false)
        {
            anim.SetBool("isJump", jump);
           
        }

        if (slide == true)
        {
            anim.SetBool("isSlide", slide);
            transform.Translate(0, 0, 0.1f);

        }
        else if (slide == false)
        {
            anim.SetBool("isSlide", slide);

        }
    }
}
