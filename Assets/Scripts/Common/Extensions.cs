using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public static class Extensions
    {
        public static string ToPriceLong(this long value)
        {
            return string.Format("{0,2:N0}", value).Replace(",", ".").Replace(" ", "");
        }

        public static void SetText(this UILabel label, string text, params object[] args)
        {
            if (text != null)
            {
                text = string.Format(text, args);

                text = text.Replace("[red]", "[FF0000]");
                text = text.Replace("[green]", "[00FF00]");
                text = text.Replace("[blue]", "[00D0FF]");
                text = text.Replace("[yellow]", "[FFFF00]");
                text = text.Replace("[pink]", "[FF6699]");
            }

            var scale = label.transform.localScale;

            label.text = text;
            label.transform.localScale = scale;
        }

        public static void SetText(this UILabel label, float value)
        {
            label.SetText(Convert.ToString(value));
        }

        public static void SetLocalizedText(this UILabel label, string text, params object[] args)
        {
            foreach (Match match in new Regex("%.+?%").Matches(text))
            {
                text = text.Replace(match.Value, Localization.Get(match.Value));
            }

            label.SetText(text, args);
        }

        public static void SetLocalizedText(this UILabel label, float value)
        {
            label.SetLocalizedText(Convert.ToString(value));
        }

        public static bool HasComponent<T>(this GameObject component) where  T : Component
        {
            return component.GetComponent<T>() != null;
        }

        public static long RoundToLong(this float value)
        {
            return (long) Math.Round(value);
        }

        public static long RoundToLong(this double value)
        {
            return (long) Math.Round(value);
        }

        public static T ToEnum<T>(this string value)
        {
            return (T) Enum.Parse(typeof(T), value);
        }

        public static List<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(i => CRandom.GetRandom(100000)).ToList();
        }
    }
}