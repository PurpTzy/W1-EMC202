using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    protected float experience;
    protected string name;
    protected float health;
}

public Mage()
{
    experience = 0.0f;
    name = "";
}   health = 100.0f;

public string GetProperties()
{
    var properties = 
        $"{nameof(name)}:{name}, {nameof(experience)}:{experience}, {nameof(health)}:{health}";

    return properties;
}