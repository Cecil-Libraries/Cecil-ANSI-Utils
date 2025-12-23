using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.ANSI_Utils.Objects;
using System;

namespace Cecil_Libraries.ANSI_Utils.Util
{
	/// <summary>
	/// This is a class containing all of the Displayer's for the various Color Systems provided.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class Displayer
	{
		/// <summary>
		/// Parses through all ANSICodeList's and displays each one in a nice way mainly for purpose of knowing what input associates with what.
		/// </summary>
		/// <return>A displayed console output based on the ANSI Code Lists.</return>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static void DisplayListBased() 
		{
			Console.WriteLine("Let's go through the List's");
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Regular");
			int i = 0;
			foreach (string item in ANSICodeLists.ColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Bold");
			i = 0;
			foreach (string item in ANSICodeLists.BoldColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Darkened");
			i = 0;
			foreach (string item in ANSICodeLists.DarkenedColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Italic");
			i = 0;
			foreach (string item in ANSICodeLists.ItalicColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Underlined");
			i = 0;
			foreach (string item in ANSICodeLists.UnderlineColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Flashy");
			i = 0;
			foreach (string item in ANSICodeLists.FlashyColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Highlighter");
			i = 0;
			foreach (string item in ANSICodeLists.HighlighterColorText)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Invisible");
			i = 0;
			foreach (string item in ANSICodeLists.InvisibleColorText)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Strikethrough");
			i = 0;
			foreach (string item in ANSICodeLists.StrikethroughColorText)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Background");
			i = 0;
			foreach (string item in ANSICodeLists.BackgroundColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Regular");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Bold");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityBoldColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Darkened");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityDarkenedColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Italic");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityItalicColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Underlined");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityUnderlineColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Flashy");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityFlashyColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Highlighter");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityHighlighterColorText)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Invisible");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityInvisibleColorText)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Strikethrough");
			i = 0;
			foreach (string item in ANSICodeLists.HighIntensityStrikethroughColorText)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("High Intensity Background");
			i = 0;
			foreach (string item in ANSICodeLists.HighInstensityBackgroundColorList)
			{
				Console.WriteLine(ANSICodeLists.ResetColor + item + $"Entry {i}" + ANSICodeLists.ResetColor);
				i++;
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
		}

		/// <summary>
		/// Displays all Possible variants of the Color Object, note each one also has a reset.
		/// </summary>
		/// <return>A displayed output based on the possibilities of the Color, each color is shown with each type on the same line</return>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static void DisplayColor()
		{
			Console.WriteLine("Let's go over the Color's available in the Color Object with each mode available");
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Foreground, Regular Intensity");
			for (int i = 0; i < 8; i++)
			{
				Color baseColor = new Color(0, i);
				string LinetoPrint = $"{baseColor.Format()}Entry {i}: ";
				for (int type = 0; type < 10; type++)
				{
					Color typedColor = new Color(type, i);
					LinetoPrint += $"{typedColor.Format()}{typedColor.GetTypeString()}{typedColor.GetReset().Format()} ";
				}
				Console.WriteLine(LinetoPrint + $"{baseColor.GetReset().Format()}");
				if (i % 15 == 0 && i != 0)
				{
					Console.WriteLine("Press Enter to Proceed");
					Console.ReadLine();
				}
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Foreground, High Intensity");
			for (int i = 0; i < 8; i++)
			{
				Color baseColor = new Color(0, i, highIntensity:true);
				string LinetoPrint = $"{baseColor.Format()}Entry {i}: ";
				for (int type = 0; type < 10; type++)
				{
					Color typedColor = new Color(type, i, highIntensity:true);
					LinetoPrint += $"{typedColor.Format()}{typedColor.GetTypeString()}{typedColor.GetReset().Format()} ";
				}
				Console.WriteLine(LinetoPrint + $"{baseColor.GetReset().Format()}");
				if (i % 15 == 0 && i != 0)
				{
					Console.WriteLine("Press Enter to Proceed");
					Console.ReadLine();
				}
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Background, Regular Intensity");
			for (int i = 0; i < 8; i++)
			{
				Color baseColor = new Color(0, i, background:true);
				string LinetoPrint = $"{baseColor.Format()}Entry {i}: ";
				for (int type = 0; type < 10; type++)
				{
					Color typedColor = new Color(type, i, background:true);
					LinetoPrint += $"{typedColor.Format()}{typedColor.GetTypeString()}{typedColor.GetReset().Format()} ";
				}
				Console.WriteLine(LinetoPrint + $"{baseColor.GetReset().Format()}");
				if (i % 15 == 0 && i != 0)
				{
					Console.WriteLine("Press Enter to Proceed");
					Console.ReadLine();
				}
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Background, High Intensity");
			for (int i = 0; i < 8; i++)
			{
				Color baseColor = new Color(0, i, background:true, highIntensity:true);
				string LinetoPrint = $"{baseColor.Format()}Entry {i}: ";
				for (int type = 0; type < 10; type++)
				{
					Color typedColor = new Color(type, i, background:true, highIntensity:true);
					LinetoPrint += $"{typedColor.Format()}{typedColor.GetTypeString()}{typedColor.GetReset().Format()} ";
				}
				Console.WriteLine(LinetoPrint + $"{baseColor.GetReset().Format()}");
				if (i % 15 == 0 && i != 0)
				{
					Console.WriteLine("Press Enter to Proceed");
					Console.ReadLine();
				}
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
		}
		
		/// <summary>
		/// Displays all Possible variants of the Color256 Object, note each one also has a reset.
		/// </summary>
		/// <return>A displayed output based on the possibilities of the Color256, each color is shown with each type on the same line</return>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static void DisplayColor256()
		{
			Console.WriteLine("Let's go over the Color's available in the Color256 Object with each mode available");
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Foreground");
			for (int i = 0; i < 256; i++)
			{
				Color256 baseColor = new Color256(0, i);
				string LinetoPrint = $"{baseColor.Format()}Entry {i}: ";
				for (int type = 0; type < 10; type++)
				{
					Color256 typedColor = new Color256(type, i);
					LinetoPrint += $"{typedColor.Format()}{typedColor.GetTypeString()}{typedColor.GetReset().Format()} ";
				}
				Console.WriteLine(LinetoPrint + $"{baseColor.GetReset().Format()}");
				if (i % 15 == 0 && i != 0)
				{
					Console.WriteLine("Press Enter to Proceed");
					Console.ReadLine();
				}
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Background");
			for (int i = 0; i < 256; i++)
			{
				Color256 baseColor = new Color256(0, i, background:true);
				string LinetoPrint = $"{baseColor.Format()}Entry {i}: ";
				for (int type = 0; type < 10; type++)
				{
					Color256 typedColor = new Color256(type, i, background:true);
					LinetoPrint += $"{typedColor.Format()}{typedColor.GetTypeString()}{typedColor.GetReset().Format()} ";
				}
				Console.WriteLine(LinetoPrint + $"{baseColor.GetReset().Format()}");
				if (i % 15 == 0 && i != 0)
				{
					Console.WriteLine("Press Enter to Proceed");
					Console.ReadLine();
				}
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
		}
		
		/// <summary>
		/// Displays all Possible variants of the ColorRGB Object, note each one also has a reset. DO NOT RUN THIS UNLESS YOUR WILLING TO WAIT A FEW HOURS FOR IT TO FINISH, use a color picker instead.
		/// </summary>
		/// <return>A displayed output based on the possibilities of the ColorRGB, each color is shown with each type on the same line</return>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static void DisplayColorRGB()
		{
			Console.WriteLine("Let's go over the Color's available in the Color256 Object with each mode available");
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Foreground");
			for (int r = 0; r < 256; r++)
			{
				for (int g = 0; g < 256; g++)
				{
					for (int b = 0; b < 256; b++)
					{
						ColorRGB baseColor = new ColorRGB(0, r, g, b);
						string LinetoPrint = $"{baseColor.Format()}Entry {r}, {g}, {b}: ";
						for (int type = 0; type < 10; type++)
						{
							ColorRGB typedColor = new ColorRGB(type, r, g, b);
							LinetoPrint += $"{typedColor.Format()}{typedColor.GetTypeString()}{typedColor.GetReset().Format()} ";
						}
						Console.WriteLine(LinetoPrint + $"{baseColor.GetReset().Format()}");
					}
				}
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
			Console.WriteLine("Background");
			for (int r = 0; r < 256; r++)
			{
				for (int g = 0; g < 256; g++)
				{
					for (int b = 0; b < 256; b++)
					{
						ColorRGB baseColor = new ColorRGB(0, r, g, b, background:true);
						string LinetoPrint = $"{baseColor.Format()}Entry {r}, {g}, {b}: ";
						for (int type = 0; type < 10; type++)
						{
							ColorRGB typedColor = new ColorRGB(type, r, g, b, background:true);
							LinetoPrint += $"{typedColor.Format()}{typedColor.GetTypeString()}{typedColor.GetReset().Format()} ";
						}
						Console.WriteLine(LinetoPrint + $"{baseColor.GetReset().Format()}");
					}
				}
			}
			Console.WriteLine("Press Enter to Proceed");
			Console.ReadLine();
		}
	}
}