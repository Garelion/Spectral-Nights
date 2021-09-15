using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rattling : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void Rattler()
    {
        anim.SetBool("Rattle", false);
    }
}
