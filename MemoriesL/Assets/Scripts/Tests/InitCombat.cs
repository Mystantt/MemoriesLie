using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCombat : MonoBehaviour
{
    private Hero player;
    private Hero enemy;

    // Start is called before the first frame update
    void Start()
    {
        player = GenerationAlgo.GenerateHero();
        enemy = GenerationAlgo.GenerateHero();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
