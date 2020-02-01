using SFML;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace pokemon_clone
{
    class Utils
    {
        public static Vector2f Vi2f(Vector2i v)
        {
            return new Vector2f(v.X, v.Y);
        }
        public static Vector2u Vi2u(Vector2i v)
        {
            return new Vector2u((uint)v.X, (uint)v.Y);
        }

        public static Vector2f Vu2f(Vector2u v)
        {
            return new Vector2f(v.X, v.Y);
        }

        public static Vector2i Vf2i(Vector2f v)
        {
            return new Vector2i((int)v.X, (int)v.Y);
        }

        public static Vector2f RoundV(Vector2f v)
        {
            return new Vector2f((float)Math.Round(v.X), (float)Math.Round(v.Y));
        }

        public static float AngleBetween (Vector2f a, Vector2f b)
        {
            var delta = b - a;
            return (float)Math.Atan2(delta.Y, delta.X);
        }

        public static float DistanceBetween(Vector2f a, Vector2f b)
        {
            var term1 = Math.Pow(b.X - a.X, 2);
            var term2 = Math.Pow(b.Y - a.Y, 2);
            float dist = (float)Math.Sqrt(term1 + term2);
            return dist;
        }

        public static Vector2f VectorFromAngle(float angle)
        {
            return new Vector2f((float)Math.Cos(angle), (float)Math.Sin(angle));
        }

        // https://stackoverflow.com/questions/2752725/finding-whether-a-point-lies-inside-a-rectangle-or-not/37865332#37865332
        public static bool PointInRectangle(Vector2f point, Vector2f[] rect)
        {
            var AB = VectorDiff(rect[0], rect[1]);
            var AM = VectorDiff(rect[0], point);
            var BC = VectorDiff(rect[1], rect[2]);
            var BM = VectorDiff(rect[1], point);
            var dotABAM = Dot(AB, AM);
            var dotABAB = Dot(AB, AB);
            var dotBCBM = Dot(BC, BM);
            var dotBCBC = Dot(BC, BC);
            return 0 <= dotABAM && dotABAM <= dotABAB && 0 <= dotBCBM && dotBCBM <= dotBCBC;
        }

        private static Vector2f VectorDiff(Vector2f p1, Vector2f p2)
        {
            return p2 - p1;
        }

        public static float Dot(Vector2f u, Vector2f v)
        {
            return u.X * v.X + u.Y * v.Y;
        }

        public static bool PointIsInRect(Vector2i point, RectangleShape rect)
        {
            RectangleShape translatedRect = new RectangleShape(rect);
            translatedRect.Position -= rect.Origin;

            return point.X >= translatedRect.Position.X && point.X <= translatedRect.Position.X + translatedRect.Size.X &&
                point.Y >= translatedRect.Position.Y && point.Y <= translatedRect.Position.Y + translatedRect.Size.Y;
        }
}
}
