using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMover : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Character character;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (new Vector3(0, 0, 1)) * Time.deltaTime * speed;
    }


}

[Serializable]
public class Character
{
    [SerializeField] private float hp;
    [SerializeField] private float speed;
    [SerializeField] private Weapon weapon;
}

[Serializable]
public class Weapon
{
    [SerializeField] private float atk;
}
