﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace PhysicsEngine
{
    public struct BoxCollider : IComponentData
    {
        public float3 HalfSize;
    }
}