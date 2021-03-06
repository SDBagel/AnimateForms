﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AnimateForms.Core
{
    public static class Helpers
    {
        public struct HSV
        {
            public HSV(float h, float s, float v)
            {
                Hue = h;
                Saturation = s;
                Value = v;
            }

            public float Hue;
            public float Saturation;
            public float Value;
        }


        public static Control[] CollectionToArray(Control.ControlCollection controlCollection)
        {
            IEnumerable<Control> controls = controlCollection.OfType<Control>();
            return controls.ToArray();
        }

        public static Control[] SortCollectionByName(Control.ControlCollection controlCollection)
        {
            IEnumerable<Control> controls = controlCollection.OfType<Control>();
            Control[] controlsArray = controls.ToArray();
            Array.Sort(controlsArray, delegate (Control a, Control b) {
                return a.Name.CompareTo(b.Name);
            });
            return controlsArray;
        }

        public static HSV RGBtoHSV(Color rgb)
        {
            int max = Math.Max(rgb.R, Math.Max(rgb.G, rgb.B));
            int min = Math.Min(rgb.R, Math.Min(rgb.G, rgb.B));

            HSV hsv = new HSV
            {
                Hue = rgb.GetHue(),
                Saturation = (max == 0) ? 0 : 1f - (1f * min / max),
                Value = max / 255f
            };

            return hsv;
        }

        private static double HSVtoRGBHelper(double h, double s, double v, int n)
        {
            double k = (n + h / 60d) % 6;
            return v - v * s * Math.Max(Math.Min(k, Math.Min(4d - k, 1d)), 0);
        }

        public static Color HSVtoRGB(HSV hsv)
        {
            return Color.FromArgb((int)(HSVtoRGBHelper(hsv.Hue, hsv.Saturation, hsv.Value, 5) * 255),
                                  (int)(HSVtoRGBHelper(hsv.Hue, hsv.Saturation, hsv.Value, 3) * 255),
                                  (int)(HSVtoRGBHelper(hsv.Hue, hsv.Saturation, hsv.Value, 1) * 255));
        }
    }
}
