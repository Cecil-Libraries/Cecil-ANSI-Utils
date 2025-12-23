using Cecil_Libraries.ANSI_Utils.Lists;
using System.Linq;

namespace Cecil_Libraries.ANSI_Utils.Objects
{
	/// <summary>
	/// A object for 24-Bit or RGB ANSI Colors there will be a reference of ID's on the GitHub for this packages README.md with the ID's, Foreground Background, Font Settings and Associated Resets.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class ColorRGB
	{
		/// <summary>
		/// The BaseString of the ANSI Code
		/// </summary>
		public string BaseString = "\u001b[";
		/// <summary>
		/// The ColorRGB's Type
		/// </summary>
		public int Type { get; set; }
		/// <summary>
		/// The ColorRGB's Shade Type
		/// </summary>
		public int BasicShade { get; set; }
		/// <summary>
		/// The Red Shade
		/// </summary>
		public int Red { get; set; }
		/// <summary>
		/// The Green Shade
		/// </summary>
		public int Green { get; set; }
		/// <summary>
		/// The Blue Shade
		/// </summary>
		public int Blue { get; set; }
		/// <summary>
		/// Whether the ColorRGB is a Reset or not.
		/// </summary>
		public bool Reset { get; set; }
		/// <summary>
		/// Whether the Color is a Background or Foreground.
		/// </summary>
		public bool Background { get; set; }

		/// <summary>
		/// Constructs a ColorRGB from a passed RGB and a Type, along with overloads for more options.
		/// </summary>
		/// <param name="red">
		/// A int from 0 to 255.
		/// </param>
		/// <param name="green">
		/// A int from 0 to 255.
		/// </param>
		/// <param name="blue">
		/// A int from 0 to 255.
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
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB(string type, int red, int green, int blue, bool background = false, bool reset = false)
		{
			Background = background;
			
			int digitStart = 0;
			
			if (background)
				digitStart = 4;
			else if (!background)
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
			
			BasicShade = int.Parse(digitStart.ToString() + "8");
			Red = red;
			Green = green;
			Blue = blue;
			Reset = reset;
		}
		
		/// <summary>
		/// Constructs a ColorRGB from a passed RGB and a Type, along with overloads for more options.
		/// </summary>
		/// <param name="red">
		/// A int from 0 to 255.
		/// </param>
		/// <param name="green">
		/// A int from 0 to 255.
		/// </param>
		/// <param name="blue">
		/// A int from 0 to 255.
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
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB(int type, int red, int green, int blue, bool background = false, bool reset = false)
		{
			Background = background;
			
			int digitStart = 0;
			
			if (background)
				digitStart = 4;
			else if (!background)
				digitStart = 3;
			
			if (reset)
			{
				if (type != 0)
					Type = int.Parse("2" + type.ToString());
			} else if (!reset)
			{
				Type = type;
			}
			
			BasicShade = int.Parse(digitStart.ToString() + "8");
			Red = red;
			Green = green;
			Blue = blue;
			Reset = reset;
		}

		/// <summary>
		/// This is a function that basically just formats the Color into a string.
		/// </summary>
		/// <returns>A formatted ANSI Color String</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public string Format()
		{
			if ((Reset && Type == 0) && (BasicShade.ToString().Length == 2 && BasicShade.ToString().StartsWith("3")))
			{
				return ANSICodeLists.ResetForeground;
			} else if ((Reset && Type == 0) && (BasicShade.ToString().Length == 2 && BasicShade.ToString().StartsWith("4")))
			{
				return ANSICodeLists.ResetBackground;
			}
			else
			{
				return this.BaseString + this.Type + ";" + this.BasicShade + ";2;" + this.Red + ";" + this.Green + ";" + this.Blue + "m";
			}
		}
		
		/// <summary>
		/// This will get the Reset from the Original ColorRGB Object, note using it on a Reset will just spit back the same Reset
		/// </summary>
		/// <returns>A reset version of the ColorRGB</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB GetReset()
		{
			ColorRGB color = new ColorRGB(Type, Red, Green, Blue, Background, reset: true);
			return color;
		}
		
		/// <summary>
		/// Gets the ColorRGB's Type as a String for the case you want to print it for some reason [this is mainly here for the Displayer]
		/// </summary>
		/// <returns>A string of the ColorRGB's Type</returns>
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