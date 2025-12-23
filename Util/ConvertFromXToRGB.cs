using System;

namespace Cecil_Libraries.ANSI_Utils.Util
{
	/// <summary>
	/// This class contains a bunch of conversions into RGB, namely Hex, Gray, HSL, HSV.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class ConvertFromXToRGB
	{
		/// <summary>
		/// Converts the passed Hex Code into a RGB Key utilizing a String Code
		/// </summary>
		/// <param name="Code">The hex code to parse to a RGB</param>
		/// <returns>3 Integers, a Red, Green and Blue value from 0-255</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static (int red, int green, int blue) ConverToRGBFromHex(string Code)
		{
			Code = Code.TrimStart('#');

			int red = Convert.ToInt32(Code.Substring(0, 2), 16);
			int green = Convert.ToInt32(Code.Substring(2, 2), 16);
			int blue = Convert.ToInt32(Code.Substring(4, 2), 16);

			return (red, green, blue);
		}
		
		/// <summary>
		/// Converts the passed Grayscale into a RGB Key, if a reversal method is found lmk and ill obsolete this and replace it with a proper reversal.
		/// </summary>
		/// <param name="Gray">The Grayscale value to parse to a RGB</param>
		/// <returns>3 Integers, a Red, Green and Blue value from 0-255</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static (int red, int green, int blue) ConvertToRGBFromGrayscale(int Gray)
		{
			return (Gray, Gray, Gray);
		}
		
		/// <summary>
		/// Converts the passed HSV Key into a RGB Key.
		/// </summary>
		/// <param name="hue">The hue value to parse into the RGB Key</param>
		/// <param name="shade">The shade value to parse into the RGB Key</param>
		/// <param name="value">The value value to parse into the RGB Key</param>
		/// <returns>3 Integers, a Red, Green and Blue value from 0-255</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static (int red, int green, int blue) ConvertToRGBFromHueShadeValue (int hue, int shade, int value)
		{
			float shadeiest = shade / 100f;
			float valiant = value / 100f;
			
			float difference = shadeiest * valiant;
			float X = difference * (1 - Math.Abs(((hue / 60f) % 2) - 1));
			float missing = valiant - difference;
			
			if (hue < 60 && hue >= 0)
			{
				return BackToRGB(difference + missing, X + missing, 0+missing);
			} else if (hue < 120 && hue >= 60)
			{
				return BackToRGB(X + missing, difference + missing, 0+missing);
			} else if (hue < 180 && hue >= 120)
			{
				return BackToRGB(0+missing, difference + missing, X + missing);
			} else if (hue < 240 && hue >= 180)
			{
				return BackToRGB(0+missing, X + missing, difference + missing);
			} else if (hue < 300 && hue >= 240)
			{
				return BackToRGB(X + missing, 0+missing, difference + missing);
			} else if (hue < 360 && hue >= 300)
			{
				return BackToRGB(difference + missing, 0+missing, X + missing);
			}
			
			return (0, 0, 0);
		}

		/// <summary>
		/// Converts the passed HSL Key into a RGB Key.
		/// </summary>
		/// <param name="hue">The hue value to parse into the RGB Key</param>
		/// <param name="saturation">The saturation value to parse into the RGB Key</param>
		/// <param name="lightness">The lightness value to parse into the RGB Key</param>
		/// <returns>3 Integers, a Red, Green and Blue value from 0-255</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static (int red, int green, int blue) ConvertToRGBFromHueSaturationLightness(int hue, int saturation, int lightness)
		{
			float sat = saturation / 100f;
			float light = lightness / 100f;
			
			float difference = (1 - Math.Abs((2*light) - 1)) * sat;
			float X = difference * (1 - Math.Abs(((hue / 60f) % 2) - 1));
			float missing = light - (difference/2);
			
			if (hue < 60 && hue >= 0)
			{
				return BackToRGB(difference + missing, X + missing, 0+missing);
			} else if (hue < 120 && hue >= 60)
			{
				return BackToRGB(X + missing, difference + missing, 0+missing);
			} else if (hue < 180 && hue >= 120)
			{
				return BackToRGB(0+missing, difference + missing, X + missing);
			} else if (hue < 240 && hue >= 180)
			{
				return BackToRGB(0+missing, X + missing, difference + missing);
			} else if (hue < 300 && hue >= 240)
			{
				return BackToRGB(X + missing, 0+missing, difference + missing);
			} else if (hue < 360 && hue >= 300)
			{
				return BackToRGB(difference + missing, 0+missing, X + missing);
			}
			
			return (0, 0, 0);
		}

		/// <summary>
		/// Converts decimal rgb between 0-1 back to regular RGB
		/// </summary>
		/// <param name="r">A decimal Red</param>
		/// <param name="g">A decimal Green</param>
		/// <param name="b">A decimal Blue</param>
		/// <returns></returns>
		private static (int red, int green, int blue) BackToRGB(float r, float g, float b)
		{
			return ((int)Math.Round(Math.Min(Math.Max(r, 0f), 1f) * 255), (int)Math.Round(Math.Min(Math.Max(g, 0f), 1f) * 255), (int)Math.Round(Math.Min(Math.Max(b, 0f), 1f) * 255));
		}
	}
}