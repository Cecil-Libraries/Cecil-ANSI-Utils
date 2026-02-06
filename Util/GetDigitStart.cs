namespace Cecil_Libraries.ANSI_Utils.Util
{
	/// <summary>
	/// This class contains functions related to getting the start of the BasicShade digit. There are two functions <see cref="GetDigitStartColor"/>, <see cref="GetDigitStart"/>.
	/// </summary>
	public class GetDigitStart
	{
		/// <summary>
		/// Gets the digit start for the color from the Background and HighIntensity, this is primarily for internal use!!
		/// </summary>
		/// <param name="background">A bool determining if it is a background/foreground.</param>
		/// <param name="highIntensity">A bool determining if it is a low/high intensity.</param>
		/// <returns>A int representing the start of the color for the BasicShade.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static int GetDigitStartColor(bool background, bool highIntensity)
		{
			int digitStart = 0;

			if (background && highIntensity)
				digitStart = 10;
			else if (background && !highIntensity)
				digitStart = 4;
			else if (!background && highIntensity)
				digitStart = 9;
			else if (!background && !highIntensity)
				digitStart = 3;
			
			return digitStart;
		}

		/// <summary>
		/// Gets the digit start for the color from the Background and HighIntensity, this is primarily for internal use!!
		/// </summary>
		/// <param name="background">A bool determining if it is a background/foreground.</param>
		/// <returns>A int representing the start of the color for the BasicShade.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static int GetDigitStartColorBase(bool background)
		{
			int digitStart = 0;
			
			if (background)
				digitStart = 4;
			else if (!background)
				digitStart = 3;

			return digitStart;
		}
	}
}