﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.FinalIK;

public class LimbIKTargeter : MonoBehaviour
{
    public AimIK aimIK; // Reference to the AimIK component
    public Transform pin; // The hitting point as in the animation

    void LateUpdate()
    {
        // Rotate the aim Transform to look at the point, where the fist hits it's target in the animation.
        // This will set the animated hit direction as the default starting point for Aim IK (direction for which Aim IK has to do nothing).
        aimIK.solver.transform.LookAt(pin.position);

        // Set myself as IK target
        aimIK.solver.IKPosition = transform.position;
    }
}
