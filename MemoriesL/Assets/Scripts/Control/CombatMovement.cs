using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMovement : MonoBehaviour
{
    public GameObject sprite;
    private Animator anim;
    private string path;

    public CombatMovement(string path)
    {
        this.path = path;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = sprite.GetComponent<Animator>();
        anim.runtimeAnimatorController = Resources.Load("Controllers/"+path) as RuntimeAnimatorController;
    }
}
