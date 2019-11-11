using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[Serializable]
public struct Creature : IComponentData
{
    public int Hp;
}
