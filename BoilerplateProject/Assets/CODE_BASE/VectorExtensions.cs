using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KaiseiBoilerplate
{
    public static class Vector3Extensions
    {
        public static Vector3 GetDirectionTo(this Vector3 vector, Vector3 targetVector)
        {
            return (targetVector - vector).normalized;
        }

        public static Vector3 GetDirectionToWithLength(this Vector3 vector, Vector3 targetVector)
        {
            return (targetVector - vector);
        }
    }
}
