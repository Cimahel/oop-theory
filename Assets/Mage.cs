using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mage : player
{
    public int mana;
    [SerializeField] private Text manatext;
    public override void Attack()
    {
        if (mana >= 10)
        {
            target.TakeDamage(attack);
            mana -= 10;
            UpdateMana();
            Debug.Log("mage used fireball");
        }
        
    }

    public override void TakeDamage(int attack)
    {
        m_health -= attack;
        mana += 5;
        UpdateHealth();
        UpdateMana();
    }

    private void UpdateMana()
    {
        manatext.text = "mana " + mana;
    }
        
}
