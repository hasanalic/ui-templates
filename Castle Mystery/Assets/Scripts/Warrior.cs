using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player
{
    public Warrior(int health, int power, string name)
    {
        Health = health;
        SetPower(power);
        SetName(name);
    }

    public override void Attack()
    {
        Debug.Log("Warrior is attacking with an axe");
    }
}
