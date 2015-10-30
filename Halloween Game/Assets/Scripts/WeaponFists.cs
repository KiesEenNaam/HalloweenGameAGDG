﻿using UnityEngine;
using System.Collections;

public class WeaponFists : WeaponBase {

    public override void OnMove()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    public override void OnDie()
    {
        base.OnDie();
    }

    public override void PlayLeftClickAnimation(Animator a)
    {
        a.SetTrigger("PunchLeft");
    }

    public override void PlayRightClickAnimation(Animator a)
    {
        a.SetTrigger("PunchRight");
    }
}