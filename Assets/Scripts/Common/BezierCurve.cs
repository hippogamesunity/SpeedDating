using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public static class BezierCurve
    {
        public static List<Vector2> Build(IList<Vector2> controlVectors, int steps)
        {
            var curve = new List<Vector2>();

            for (var i = 0; i < steps; i++)
            {
                curve.Add(Vector2.zero);

                for (var j = 0; j < controlVectors.Count; j++)
                {
                    curve[curve.Count - 1] += controlVectors[j] * GetBezierBasis(j, controlVectors.Count - 1, (float)i / (steps - 1));
                }
            }

            return curve;
        }

        private static float GetBezierBasis(int i, int n, float t)
        {
            Func<int, float> f = null;

            f = x => x <= 1 ? 1 : x * f(x - 1);

            return (f(n) / (f(i) * f(n - i))) * Mathf.Pow(t, i) * Mathf.Pow(1 - t, n - i);
        }
    }
}
