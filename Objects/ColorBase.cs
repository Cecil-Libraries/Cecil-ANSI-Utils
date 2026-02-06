using Cecil_Libraries.ANSI_Utils.Lists;
using System;

namespace Cecil_Libraries.ANSI_Utils.Objects
{
	/// <summary>
	/// The base color object used by Color, Color256, and ColorRGB.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class ColorBase
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
		/// Whether the Color is a Reset or not.
		/// </summary>
		public bool Reset { get; set; }
		/// <summary>
		/// Whether the Color is a Background or Foreground.
		/// </summary>
		public bool Background { get; set; }
		/// <summary>
		/// Additional peices needed to format the Child Object's color.
		/// </summary>
		public string Extra { get; set; }
		
		/// <summary>
		/// This is a function that basically just formats the Color into a string.
		/// </summary>
		/// <returns>A formatted ANSI Color String</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public string Format()
		{
			if ((Reset && Type == 0) && ((BasicShade.ToString().Length == 2 && BasicShade.ToString().StartsWith("3")) || (BasicShade.ToString().Length == 2 && BasicShade.ToString().StartsWith("9"))))
			{
				return ANSICodeLists.ResetForeground;
			} else if ((Reset && Type == 0) && ((BasicShade.ToString().Length == 2 && BasicShade.ToString().StartsWith("4")) || (BasicShade.ToString().Length == 3 && BasicShade.ToString().StartsWith("10"))))
			{
				return ANSICodeLists.ResetBackground;
			}
			else
			{
				return this.BaseString + this.Type + ";" + this.BasicShade + (!String.IsNullOrWhiteSpace(Extra) ? Extra : "") + "m";
			}
		}
		
		/// <summary>
		/// Gets the ColorBase's Type as a String for the case you want to print it for some reason [this is mainly here for the Displayer]
		/// </summary>
		/// <returns>A string of the ColorBase's Type</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public string GetTypeString() 
		{
			switch (Type)
			{
				case 0:
					return "Regular";
				case 1:
					return "Bold";
				case 2:
					return "Dulled";
				case 3:
					return "Italic";
				case 4:
					return "Underlined";
				case 5:
					return "Blink";
				case 6:
					return "Rapid";
				case 7:
					return "Highlight";
				case 8:
					return "Underlight";
				case 9:
					return "Strikethrough";
				case 21:
					return "Doubleline";
				case 53:
					return "Overlined";
				case 51:
					return "Framed";
				case 52:
					return "Encircled";
			}
			return $"Failed to get a Valid Type please verify {Type}, if its valid contact @thincreator3483 on discord.";
		}
		
		/// <summary>
		/// A function to toggle the Background/Foreground switch from its previous state.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public void ToggleBackground()
		{
			Background = !Background;
		}
	}
}