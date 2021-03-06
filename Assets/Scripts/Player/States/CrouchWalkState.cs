﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CrouchWalkState", menuName = "PlayerState/CrouchWalk", order = 1)]
public class CrouchWalkState : PlayerState
{
    [SerializeField]
    private float movementSpeed = 0.5f;

    protected override void CustomStartState()
    {
        // TODO: Change the collider while crouched?
    }

    protected override void CustomStateUpdate()
    {
        float multiplier = IsMirrored ? -1.0f : 1.0f;
        playerRigidBody.velocity = new Vector3(movementSpeed * multiplier, .0f, .0f);
    }
}