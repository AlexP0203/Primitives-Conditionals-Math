using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] string characterName = "Aelinor";
    [SerializeField] int proficiency = 3;
    [SerializeField] bool finesseWeapon = false;
    [SerializeField][Range(-5, 5)] int STR = 3;
    [SerializeField][Range(-5, 5)] int DEX = 4;

    int attackRoll;
    int enemyAC;
    int hitModifier;

    // Start is called before the first frame update
    void Start()
    {
        if ((finesseWeapon == true) && (DEX > STR))
        {
            hitModifier = proficiency + DEX;
        }
        else
        {
            hitModifier = proficiency + STR;
        }

        attackRoll = Random.Range(0, 21);
        enemyAC = Random.Range(10, 21);

        Debug.Log(characterName + "'s hit modifier is +" + hitModifier);
        Debug.Log("Enemy AC is " + enemyAC);
        Debug.Log(characterName + " rolled a " + attackRoll);

        if((attackRoll + hitModifier) >= enemyAC)
        {
            Debug.Log("Enemy is hit!");
        }
        else
        {
            Debug.Log("Attack missed!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
