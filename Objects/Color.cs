using Cecil_Libraries.ANSI_Utils.Lists;
using System.Linq;

namespace Cecil_Libraries.ANSI_Utils.Objects
{
	/// <summary>
	/// A object for regular ANSI Colors e.g. Black, Red, Green, Yellow, Blue, Magenta, Cyan, White, Foreground Background, Font Settings and Associated Resets.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class Color
	{
		/// <summary>
		/// The BaseString of the ANSI Code
		/// </summary>
		public string BaseString = "\u001b[";
		/// <summary>
		/// The Color's Type
		/// </summary>
		public int Type { get; set; }
		/// <summary>
		/// The Color's Shade
		/// </summary>
        public int BasicShade { get; set; }
		/// <summary>
		/// Whether the Color is a Reset or not.
		/// </summary>
        public bool Reset { get; set; }
		/// <summary>
		/// Whether the Color is a Background or Foreground.
		/// </summary>
		public bool Background { get; set; }
		/// <summary>
		/// Whether the Color is a High or Normal Intensity.
		/// </summary>
		public bool HighIntensity { get; set; }
		/// <summary>
		/// The basic color passed into the function
		/// </summary>
		public int BaseColor { get; set; }
        
        /// <summary>
		/// Constructs a Color from a passed Color and Type, along with overloads for more options.
		/// </summary>
		/// <param name="color">
		/// The colors follow this order; Black, Red, Green, Yellow, Blue, Magenta, Cyan, White, if by number 0-7, otherwise the string as shown.
		/// </param>
		/// <param name="type">
		///		If by number, follow the order given in the table starting with 0, it's a 0-9 value.
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///             <term2>What To Enter</term2>
		///         </listheader>
		///         <item>
		///             <term>Regular</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="background">Whether the applicant color should be applied to the background or foreground, defaults to foreground.</param>
		/// <param name="highIntensity">Whether the applicant color should be applied to the high or low intensity, defaults to low.</param>
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public Color (string type, string color, bool background = false, bool highIntensity = false, bool reset = false)
        {
	        Background = background;
	        HighIntensity = highIntensity;
	        
	        int digitStart = 0;

	        if (background && highIntensity)
		        digitStart = 10;
	        else if (background && !highIntensity)
		        digitStart = 4;
	        else if (!background && highIntensity)
		        digitStart = 9;
	        else if (!background && !highIntensity)
		        digitStart = 3;
	        
	        if (reset)
	        {
		        switch (type)
		        {
			        case "Regular":
				        Type = 0;
				        break;
			        case "Bold":
				        Type = int.Parse("2" + 1.ToString());
				        break;
			        case "Dulled":
				        Type = int.Parse("2" + 2.ToString());
				        break;
			        case "Italic":
				        Type = int.Parse("2" + 3.ToString());
				        break;
			        case "Underlined":
				        Type = int.Parse("2" + 4.ToString());
				        break;
			        case "Blink":
				        Type = int.Parse("2" + 5.ToString());
				        break;
			        case "Rapid":
				        Type = int.Parse("2" + 6.ToString());
				        break;
			        case "Highlight":
				        Type = int.Parse("2" + 7.ToString());
				        break;
			        case "Underlight":
				        Type = int.Parse("2" + 8.ToString());
				        break;
			        case "Strikethrough":
				        Type = int.Parse("2" + 9.ToString());
				        break;
		        }
	        } else if (!reset)
	        {
		        switch (type)
		        {
			        case "Regular":
				        Type = 0;
				        break;
			        case "Bold":
				        Type = 1;
				        break;
			        case "Dulled":
				        Type = 2;
				        break;
			        case "Italic":
				        Type = 3;
				        break;
			        case "Underlined":
				        Type = 4;
				        break;
			        case "Blink":
				        Type = 5;
				        break;
			        case "Rapid":
				        Type = 6;
				        break;
			        case "Highlight":
				        Type = 7;
				        break;
			        case "Underlight":
				        Type = 8;
				        break;
			        case "Strikethrough":
				        Type = 9;
				        break;
		        }
	        }

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
	        
	        Reset = reset;
        }
        
        /// <summary>
		/// Constructs a Color from a passed Color and Type, along with overloads for more options.
		/// </summary>
		/// <param name="color">
		/// The colors follow this order; Black, Red, Green, Yellow, Blue, Magenta, Cyan, White, if by number 0-7, otherwise the string as shown.
		/// </param>
		/// <param name="type">
		///		If by number, follow the order given in the table starting with 0, it's a 0-9 value.
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///             <term2>What To Enter</term2>
		///         </listheader>
		///         <item>
		///             <term>Regular</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="background">Whether the applicant color should be applied to the background or foreground, defaults to foreground.</param>
		/// <param name="highIntensity">Whether the applicant color should be applied to the high or low intensity, defaults to low.</param>
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public Color (int type, string color, bool background = false, bool highIntensity = false, bool reset = false)
        {
	        Background = background;
	        HighIntensity = highIntensity;
	        
	        int digitStart = 0;

	        if (background && highIntensity)
		        digitStart = 10;
	        else if (background && !highIntensity)
		        digitStart = 4;
	        else if (!background && highIntensity)
		        digitStart = 9;
	        else if (!background && !highIntensity)
		        digitStart = 3;
	        
	        if (reset)
	        {
		        if (type != 0)
			        Type = int.Parse("2" + type.ToString());
	        } else if (!reset)
	        {
		        Type = type;
	        }

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
	        
	        Reset = reset;
        }
		
        /// <summary>
		/// Constructs a Color from a passed Color and Type, along with overloads for more options.
		/// </summary>
		/// <param name="color">
		/// The colors follow this order; Black, Red, Green, Yellow, Blue, Magenta, Cyan, White, if by number 0-7, otherwise the string as shown.
		/// </param>
		/// <param name="type">
		///		If by number, follow the order given in the table starting with 0, it's a 0-9 value.
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///             <term2>What To Enter</term2>
		///         </listheader>
		///         <item>
		///             <term>Regular</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="background">Whether the applicant color should be applied to the background or foreground, defaults to foreground.</param>
		/// <param name="highIntensity">Whether the applicant color should be applied to the high or low intensity, defaults to low.</param>
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public Color (string type, int color, bool background = false, bool highIntensity = false, bool reset = false)
        {
	        BaseColor = color;
	        Background = background;
	        HighIntensity = highIntensity;
	        
	        int digitStart = 0;

	        if (background && highIntensity)
		        digitStart = 10;
	        else if (background && !highIntensity)
		        digitStart = 4;
	        else if (!background && highIntensity)
		        digitStart = 9;
	        else if (!background && !highIntensity)
		        digitStart = 3;
	        
	        if (reset)
	        {
		        switch (type)
		        {
			        case "Regular":
				        Type = 0;
				        break;
			        case "Bold":
				        Type = int.Parse("2" + 1.ToString());
				        break;
			        case "Dulled":
				        Type = int.Parse("2" + 2.ToString());
				        break;
			        case "Italic":
				        Type = int.Parse("2" + 3.ToString());
				        break;
			        case "Underlined":
				        Type = int.Parse("2" + 4.ToString());
				        break;
			        case "Blink":
				        Type = int.Parse("2" + 5.ToString());
				        break;
			        case "Rapid":
				        Type = int.Parse("2" + 6.ToString());
				        break;
			        case "Highlight":
				        Type = int.Parse("2" + 7.ToString());
				        break;
			        case "Underlight":
				        Type = int.Parse("2" + 8.ToString());
				        break;
			        case "Strikethrough":
				        Type = int.Parse("2" + 9.ToString());
				        break;
		        }
	        } else if (!reset)
	        {
		        switch (type)
		        {
			        case "Regular":
				        Type = 0;
				        break;
			        case "Bold":
				        Type = 1;
				        break;
			        case "Dulled":
				        Type = 2;
				        break;
			        case "Italic":
				        Type = 3;
				        break;
			        case "Underlined":
				        Type = 4;
				        break;
			        case "Blink":
				        Type = 5;
				        break;
			        case "Rapid":
				        Type = 6;
				        break;
			        case "Highlight":
				        Type = 7;
				        break;
			        case "Underlight":
				        Type = 8;
				        break;
			        case "Strikethrough":
				        Type = 9;
				        break;
		        }
	        }

	        BasicShade = int.Parse(digitStart.ToString() + color.ToString());
	        
	        Reset = reset;
        }
		
        /// <summary>
		/// Constructs a Color from a passed Color and Type, along with overloads for more options.
		/// </summary>
		/// <param name="color">
		/// The colors follow this order; Black, Red, Green, Yellow, Blue, Magenta, Cyan, White, if by number 0-7, otherwise the string as shown.
		/// </param>
		/// <param name="type">
		///		If by number, follow the order given in the table starting with 0, it's a 0-9 value.
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///             <term2>What To Enter</term2>
		///         </listheader>
		///         <item>
		///             <term>Regular</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="background">Whether the applicant color should be applied to the background or foreground, defaults to foreground.</param>
		/// <param name="highIntensity">Whether the applicant color should be applied to the high or low intensity, defaults to low.</param>
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public Color (int type, int color, bool background = false, bool highIntensity = false, bool reset = false)
		{
			BaseColor = color;
			Background = background;
			HighIntensity = highIntensity;
			
			int digitStart = 0;

			if (background && highIntensity)
				digitStart = 10;
			else if (background && !highIntensity)
				digitStart = 4;
			else if (!background && highIntensity)
				digitStart = 9;
			else if (!background && !highIntensity)
				digitStart = 3;

			if (reset)
			{
				if (type != 0)
					Type = int.Parse("2" + type.ToString());
			} else if (!reset)
			{
				Type = type;
			}
			
			BasicShade = int.Parse(digitStart.ToString() + color.ToString());

			Reset = reset;
		}

        /// <summary>
        /// This is a function that basically just formats the Color into a string.
        /// </summary>
        /// <returns>A formatted ANSI Color String</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public string Format()
		{
			if ((Reset && Type == 0) && ((BasicShade.ToString().Length == 2 && BasicShade.ToString().StartsWith("3")) || (BasicShade.ToString().Length == 2 && BasicShade.ToString().StartsWith("9"))))
			{
				//Console.WriteLine($"DEBUG MAKE SURE TO REMOVE; {ANSICodeLists.ResetForeground.Replace(BaseString, "")}");
				return ANSICodeLists.ResetForeground;
			} else if ((Reset && Type == 0) && ((BasicShade.ToString().Length == 2 && BasicShade.ToString().StartsWith("4")) || (BasicShade.ToString().Length == 3 && BasicShade.ToString().StartsWith("10"))))
			{
				//Console.WriteLine($"DEBUG MAKE SURE TO REMOVE; {ANSICodeLists.ResetBackground.Replace(BaseString, "")}");
				return ANSICodeLists.ResetBackground;
			}
			else
			{
				//Console.WriteLine($"DEBUG MAKE SURE TO REMOVE; {this.Type + ";" + this.BasicShade + "m"}");
				return this.BaseString + this.Type + ";" + this.BasicShade + "m";
			}
		}
        
		/// <summary>
		/// This will get the Reset from the Original Color Object, note using it on a Reset will just spit back the same Reset
		/// </summary>
		/// <returns>A reset version of the Color</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public Color GetReset()
		{
			Color color = new Color(Type, BaseColor, Background, HighIntensity, reset: true);
			return color;
		}
		
		/// <summary>
		/// Gets the Color's Type as a String for the case you want to print it for some reason [this is mainly here for the Displayer]
		/// </summary>
		/// <returns>A string of the Color's Type</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public string GetTypeString() 
		{
			switch (Type.ToString().Last())
			{
				case '0':
					return "Regular";
				case '1':
					return "Bold";
				case '2':
					return "Dulled";
				case '3':
					return "Italic";
				case '4':
					return "Underlined";
				case '5':
					return "Blink";
				case '6':
					return "Rapid";
				case '7':
					return "Highlight";
				case '8':
					return "Underlight";
				case '9':
					return "Strikethrough";
			}
			return $"Failed to get a Valid Type please verify {Type}, if its valid contact @thincreator3483 on discord.";
		}
	}
}