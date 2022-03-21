using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warrior : player
{
    [SerializeField]
    private int defense;

    public override void TakeDamage(int attack)
    {
        m_health -= (attack - defense);
        Debug.Log("warrior took "+(attack - defense));
        UpdateHealth();
    }        
}
