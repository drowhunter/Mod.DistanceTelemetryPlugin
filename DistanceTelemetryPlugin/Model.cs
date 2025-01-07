﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using UnityEngine;

namespace DistanceTelemetryPlugin
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TelemetryData
    {
        public fixed char Sender_ID[38];
        public fixed char Race_ID[38];
        public string Level;
        public string Mode;
        public DateTime RealTime;
        public double Time;
        public string Event;
        public float Speed_KPH;
        public float Speed_MPH;
        public float Heat;
        public Vector3 Pos;
        public Vector3 Rot;
        public Vector3 Vel;
        public Vector3 AngVel;
        public Inputs Inputs;
        public bool Grav;
        public float Drag;
        public float AngularDrag;
        public bool Wings;
        public bool HasWings;
        public bool AllWheelsContacting;
        public Tires Tires;
        public float DriveWheelAvgRotVel;
        public float DriveWheelAvgRPM;
    }

    public struct Inputs
    {
        public bool Boost;
        public float Steer;
        public bool Grip;
        public float Gas;
        public float Brake;
        public Vector3 Rotation;
    }

    public struct Tire
    {
        public float Pos;
        public bool Contact;
        public float Suspension;
    }

    public struct Tires
    {
        public Tire TireFL;
        public Tire TireFR;
        public Tire TireBL;
        public Tire TireBR;
    }
}