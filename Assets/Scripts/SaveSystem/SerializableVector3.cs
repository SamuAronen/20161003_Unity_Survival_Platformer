﻿using System;
using UnityEngine;
namespace Assets.Scripts.SaveSystem
{
    [Serializable] public class SerializableVector3
    {
        public float X;
        public float Y;
        public float Z;


        public SerializableVector3(Vector3 vector3)
        {
            X = vector3.x;
            Y = vector3.y;
            Z = vector3.z;
        }

        public SerializableVector3(Vector2 vector3)
        {
            X = vector3.x;
            Y = vector3.y;
            Z = 0;
        }

        public static implicit operator SerializableVector3(Vector3 vector)
        {
            return new SerializableVector3(vector);
        }

        public static explicit operator Vector3(SerializableVector3 vector)
        {
            return new Vector3(vector.X, vector.Y, vector.Z);
        }


        public static implicit operator SerializableVector3(Vector2 vector)
        {
            return new SerializableVector3(vector);
        }

        public static explicit operator Vector2(SerializableVector3 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }
    }
}
