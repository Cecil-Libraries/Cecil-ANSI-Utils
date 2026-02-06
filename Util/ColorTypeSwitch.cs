namespace Cecil_Libraries.ANSI_Utils.Util
{
	/// <summary>
	/// This class contains functions related to getting the end of the BasicShade digit. This contains 4 functions, 1 from string <see cref="SwitchColorString"/>, and 3 from int <see cref="SwitchColorInt"/>, <see cref="SwitchColor256Int"/>, <see cref="SwitchColorRGBInt"/>
	/// </summary>
	public class ColorTypeSwitch
	{
		/// <summary>
		/// A function used to convert a string color into its integer variant, and to format the BasicShade accordingly, this is primarily for internal use!!
		/// </summary>
		/// <param name="color">
		/// The colors follow this order; Black, Red, Green, Yellow, Blue, Magenta, Cyan, White, if by number 0-7, otherwise the string as shown.
		/// </param>
		/// <param name="digitStart">This is a variable representing the beginning of the color [e.g. the determiner of background/high intensity and such.</param>
		/// <returns>Two Integers, the BasicShade than the BaseColor in Tupple form.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static (int BasicShade, int BaseColor) SwitchColorString(string color, int digitStart)
		{
			int BasicShade = 0;
			int BaseColor = 0;
			
			switch (color)
			{
				case "Black":
					BasicShade = int.Parse(digitStart.ToString() + "0");
					BaseColor = 0;
					break;
				case "Red": 
					BasicShade = int.Parse(digitStart.ToString() + "1");
					BaseColor = 1;
					break;
				case "Green":
					BasicShade = int.Parse(digitStart.ToString() + "2");
					BaseColor = 2;
					break;
				case "Yellow":
					BasicShade = int.Parse(digitStart.ToString() + "3");
					BaseColor = 3;
					break;
				case "Blue":
					BasicShade = int.Parse(digitStart.ToString() + "4");
					BaseColor = 4;
					break;
				case "Magenta":
					BasicShade = int.Parse(digitStart.ToString() + "5");
					BaseColor = 5;
					break;
				case "Cyan":
					BasicShade = int.Parse(digitStart.ToString() + "6");
					BaseColor = 6;
					break;
				case "White":
					BasicShade = int.Parse(digitStart.ToString() + "7");
					BaseColor = 7;
					break;
				default:
					BasicShade = int.Parse(digitStart.ToString() + "7");
					BaseColor = 7;
					break;
			}
			
			return (BasicShade, BaseColor);
		}

		/// <summary>
		/// A function used to format the BasicShade accordingly, this is primarily for internal use!!
		/// </summary>
		/// <param name="color">
		/// The colors follow this order; Black, Red, Green, Yellow, Blue, Magenta, Cyan, White, if by number 0-7, otherwise the string as shown.
		/// </param>
		/// <param name="digitStart">This is a variable representing the beginning of the color [e.g. the determiner of background/high intensity and such.</param>
		/// <returns>Two Integers, the BasicShade than the BaseColor in Tupple form.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static (int BasicShade, int BaseColor) SwitchColorInt(int color, int digitStart)
		{
			return (int.Parse(digitStart.ToString() + color.ToString()), color);
		}
		
		/// <summary>
		/// A function used to format the BasicShade accordingly, this is primarily for internal use!!
		/// </summary>
		/// <param name="shade">
		/// The 0-255 shade in integer form.
		/// </param>
		/// <param name="digitStart">This is a variable representing the beginning of the color [e.g. the determiner of background/high intensity and such.</param>
		/// <returns>Two Integers, the BasicShade than the Shade256 in Tupple form.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static (int BasicShade, int Shade256) SwitchColor256Int(int shade, int digitStart)
		{
			return (int.Parse(digitStart.ToString() + "8"), shade);
		}

		/// <summary>
		/// A function used to format the BasicShade accordingly, this is primarily for internal use!!
		/// </summary>
		/// <param name="red">
		/// The 0-255 shade in to use as a red value in integer form.
		/// </param>
		/// <param name="green">
		/// The 0-255 shade in to use as a green value in integer form.
		/// </param>
		/// <param name="blue">
		/// The 0-255 shade in to use as a blue value in integer form.
		/// </param>
		/// <param name="digitStart">This is a variable representing the beginning of the color [e.g. the determiner of background/high intensity and such.</param>
		/// <returns>Two Integers, the BasicShade than the red, green, and blue in Tupple form.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static (int BasicShade, int red, int green, int blue) SwitchColorRGBInt(int red, int green, int blue, int digitStart)
		{
			return (int.Parse(digitStart.ToString() + "8"), red, green, blue);
		}
	}
}