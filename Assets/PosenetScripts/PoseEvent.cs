﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoseEvent {
    public PosePosition nose;
    public PosePosition head;
    public PosePosition leftEye;
    public PosePosition rightEye;
    public PosePosition leftEar;
    public PosePosition rightEar;
    public PosePosition leftShoulder;
    public PosePosition rightShoulder;
    public PosePosition leftElbow;
    public PosePosition rightElbow;
    public PosePosition leftWrist;
    public PosePosition rightWrist;
    public PosePosition root; // mid-point between hips (pelvis)
    public PosePosition leftHip;
    public PosePosition rightHip;
    public PosePosition leftKnee;
    public PosePosition rightKnee;
    public PosePosition leftFoot;
    public PosePosition rightFoot;

    // The ones below are extras for more detailed models

    public PosePosition spine1;
    public PosePosition spine2;
    public PosePosition spine3;
    public PosePosition spine4;
    public PosePosition spine5;
    public PosePosition spine6;
    public PosePosition spine7;

    public PosePosition neck1;
    public PosePosition neck2;
    public PosePosition neck3;
    public PosePosition neck4;

    public PosePosition jaw;
    public PosePosition chin;

    // Right Hand
    public PosePosition rightHandThumbStart;
    public PosePosition rightHandThumbJoint1;
    public PosePosition rightHandThumbJoint2;
    public PosePosition rightHandThumbEnd;

    public PosePosition rightHandIndexStart;
    public PosePosition rightHandIndexJoint1;
    public PosePosition rightHandTIndexJoint2;
    public PosePosition rightHandTIndexJoint3;
    public PosePosition rightHandIndexEnd;

    public PosePosition rightHandMidStart;
    public PosePosition rightHandMidJoint1;
    public PosePosition rightHandTMidJoint2;
    public PosePosition rightHandTMidJoint3;
    public PosePosition rightHandMidEnd;

    public PosePosition rightHandRingStart;
    public PosePosition rightHandRingJoint1;
    public PosePosition rightHandTRingJoint2;
    public PosePosition rightHandTRingJoint3;
    public PosePosition rightHandRingEnd;

    public PosePosition rightHandPinkyStart;
    public PosePosition rightHandPinkyJoint1;
    public PosePosition rightHandTPinkyJoint2;
    public PosePosition rightHandTPinkyJoint3;
    public PosePosition rightHandPinkyEnd;

    // Left Hand
    public PosePosition leftHandThumbStart;
    public PosePosition leftHandThumbJoint1;
    public PosePosition leftHandThumbJoint2;
    public PosePosition leftHandThumbEnd;

    public PosePosition leftHandIndexStart;
    public PosePosition leftHandIndexJoint1;
    public PosePosition leftHandTIndexJoint2;
    public PosePosition leftHandTIndexJoint3;
    public PosePosition leftHandIndexEnd;

    public PosePosition leftHandMidStart;
    public PosePosition leftHandMidJoint1;
    public PosePosition leftHandTMidJoint2;
    public PosePosition leftHandTMidJoint3;
    public PosePosition leftHandMidEnd;

    public PosePosition leftHandRingStart;
    public PosePosition leftHandRingJoint1;
    public PosePosition leftHandTRingJoint2;
    public PosePosition leftHandTRingJoint3;
    public PosePosition leftHandRingEnd;

    public PosePosition leftHandPinkyStart;
    public PosePosition leftHandPinkyJoint1;
    public PosePosition leftHandTPinkyJoint2;
    public PosePosition leftHandTPinkyJoint3;
    public PosePosition leftHandPinkyEnd;

    // Right foot
    public PosePosition rightToes;
    public PosePosition rightToesEnd;

    // Left foot
    public PosePosition leftToes;
    public PosePosition leftToesEnd;

    public static PoseEvent CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PoseEvent>(jsonString);
    }
}
