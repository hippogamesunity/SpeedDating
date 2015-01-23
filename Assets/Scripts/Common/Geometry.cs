using System;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public static class Geometry
    {
        public static bool IntersectionLineCircle(Vector2 center, float radius, Vector2 start, Vector2 end)
        {
            Vector2 i, j;

            var count = FindLineCircleIntersections(center, radius, start, end, out i, out j);

            if (count == 0)
            {
                return false;
            }
            
            if (count == 1)
            {
                return !((start.x > i.x && end.x > i.x)
                    || (start.x < i.x && end.x < i.x)
                    || (start.y > i.y && end.y > i.y)
                    || (start.y < i.y && end.y < i.y));
            }
            
            return !((start.x > i.x && end.x > i.x && start.x > j.x && end.x > j.x
                || (start.x < i.x && end.x < i.x && start.x < j.x && end.x < j.x)
                || (start.y > i.y && end.y > i.y && start.y > j.y && end.y > j.y)
                || (start.y < i.y && end.y < i.y && start.y < j.y && end.y < j.y)));
        }

        public static int FindLineCircleIntersections(Vector2 center, float radius, Vector2 start, Vector2 end, out Vector2 i, out Vector2 j)
        {
            var dx = end.x - start.x;
            var dy = end.y - start.y;
            var a = dx * dx + dy * dy;
            var b = 2 * (dx * (start.x - center.x) + dy * (start.y - center.y));
            var c = (start.x - center.x) * (start.x - center.x) + (start.y - center.y) * (start.y - center.y) - radius * radius;
            var det = b * b - 4 * a * c;

            if ((a <= 0.0000001) || (det < 0))
            {
                i = new Vector2(float.NaN, float.NaN);
                j = new Vector2(float.NaN, float.NaN);

                return 0;
            }

            if (det == 0)
            {
                var t = -b / (2 * a);

                i = new Vector2(start.x + t * dx, start.y + t * dy);
                j = new Vector2(float.NaN, float.NaN);

                return 1;
            }
            else
            {
                var t = (float)((-b + Math.Sqrt(det)) / (2 * a));
                
                i = new Vector2(start.x + t * dx, start.y + t * dy);
                t = (float)((-b - Math.Sqrt(det)) / (2 * a));
                j = new Vector2(start.x + t * dx, start.y + t * dy);

                return 2;
            }
        }
    }
}