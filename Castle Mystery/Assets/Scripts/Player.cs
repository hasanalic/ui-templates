using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _health;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    private int power;
    // getter-setter
    public void SetPower(int power)
    {
        this.power = power;
    }
    public int GetPower()
    {
        return this.power;
    }

    private string name;
    // getter-setter
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return this.name;
    }

    public Player() { }

    public Player(int health, int power, string name)
    {
        Health = health;
        this.power = power;
        this.name = name;
    }

    public virtual void Attack()
    {
        Debug.Log("Player is attacking with fire.");
    }

    public void Info()
    {
        Debug.Log("Health is: + " + Health);
        Debug.Log("Power is: " + power);
        Debug.Log("Name is: " + name);
    }

}
