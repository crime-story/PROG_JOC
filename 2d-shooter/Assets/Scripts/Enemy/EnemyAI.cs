using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Gives an EnemyBehaviour to an enemy
public class EnemyAI : MonoBehaviour
{
    // EnemyBehaviour set from Unity Editor
    public EnemyBehaviour enemyBehaviour;

    public float repetableBehaviourCooldown = 1f;

    // On start init the enemyBehaviour
    void Start()
    {
        enemyBehaviour = Instantiate(enemyBehaviour);

        enemyBehaviour.Init(this);

        InvokeRepeating("InvokeRepetableBehaviour", 0, repetableBehaviourCooldown);
    }

    // On fixed update call the enemyBehaviour think method
    void FixedUpdate()
    {
        enemyBehaviour.Think(this);
    }

    public void InvokeRepetableBehaviour() {
        enemyBehaviour.RepetableBehaviour(this);
    }
}
