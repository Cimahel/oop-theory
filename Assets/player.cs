using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class player : MonoBehaviour
{
    [SerializeField]
    protected int m_health;
    public int health
    {
        get {return m_health;}

        set
        {
            if (value > 0)
            {
                m_health = value;
            }
            else
            {
                m_health = 0;
            }
        }
    }

    [SerializeField] private int maxHealth;
    [SerializeField] protected int attack;
    [SerializeField] private Text healthtext;
    public player target;

    public virtual void Attack()
    {
        target.TakeDamage(attack);
    }

    public virtual void TakeDamage(int attack)
    {
        m_health -= attack;
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        healthtext.text = health + "/" + maxHealth;
    }
}
