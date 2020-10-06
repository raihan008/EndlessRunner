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

        if (Input.GetKey("j"))
        {
            jump = true;
        }

        else {
            jump = false;

        }

        if (Input.GetKey("x"))
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
            transform.Translate(0, 0.4f, 0);
        
        }
        else if (jump == false)
        {
            anim.SetBool("isJump", jump);
           
        }

        if (slide == true)
        {
            anim.SetBool("isSlide", slide);
            transform.Translate(0, 0, 0.2f);

        }
        else if (slide == false)
        {
            anim.SetBool("isSlide", slide);

        }


      if (Input.GetKey("d"))
          {
              transform.Translate(0.1f, 0, 0);
          }
      if (Input.GetKey("a"))
        {
            transform.Translate(-0.1f, 0, 0);
        }


      if (Input.GetKey("w"))
      {
          transform.Translate(0, 0, 0.5f);
      }

      if (Input.GetKey("z"))
      {
          transform.Translate(0, 0, 1);
      }



    }
}
