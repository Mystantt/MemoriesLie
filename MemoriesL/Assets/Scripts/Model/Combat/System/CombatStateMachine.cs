using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStateMachine : MonoBehaviour
{
    private BattleState state;
    private Hero player;
    private Hero enemy;
    private int roll;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.COMBATROLL;
        player = GenerationAlgo.GenerateHero();
        enemy = GenerationAlgo.GenerateHero();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case BattleState.COMBATROLL:
                System.Random rnd = new System.Random();
                roll = rnd.Next(1,100);
                if(roll < 50)
                {
                    state = BattleState.ENEMYTURN;
                    Debug.Log("Enemy turn, roll : " + roll + "Turn of : "+ enemy.Name);
                }
                else
                {
                    state = BattleState.PARTYTURN;
                    Debug.Log("Your turn, roll : " + roll + "Turn of : " + player.Name);
                }
                break;
            case BattleState.PARTYTURN:
                break;
            case BattleState.ENEMYTURN:
                break;
            case BattleState.DEATH:
                break;
            case BattleState.VICTORY:
                break;
        }
    }
}
