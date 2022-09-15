using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterCombat
{
    public void Fire(GameObject Bullet, Transform Position)
    {
        GameObject bullet = GameObject.Instantiate(Bullet, Position);
        bullet.transform.SetParent(null);
    }
}
