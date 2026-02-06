using Cecil_Libraries.ANSI_Utils.Util;

namespace Cecil_Libraries.ANSI_Utils.Objects
{
	/// <summary>
	/// A object for 24-Bit or RGB ANSI Colors. A preview can be found within <see cref="Displayer"/>. Supports Background Toggles, Font Settings, and resets.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class ColorRGB : ColorBase
	{
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
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///         </listheader>
		///         <item>
		///             <term>Regular (0)</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold (1)</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled (2)</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic (3)</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined (4)</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink (5)</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid (6)</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight (7)</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight (8)</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough (9)</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///			<item>
		///             <term>Doubleline (21)</term>
		///             <description>This will make the text appear with an underline, and a underline under that underline.</description>
		///			</item>
		///			<item>
		///             <term>Overlined (53)</term>
		///             <description>This will make the text appear with an overline.</description>
		///			</item>
		///			<item>
		///             <term>Framed (51)</term>
		///             <description>This will make the text appear boxed.</description>
		///			</item>
		///			<item>
		///             <term>Encircled (52)</term>
		///             <description>This will make the text appear circled.</description>
		///			</item>
		///     </list>
		/// </param>
		/// <param name="background">Whether the applicant color should be applied to the background or foreground, defaults to foreground.</param>
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB(string type, int red, int green, int blue, bool background = false, bool reset = false)
		{
			Background = background;
			Reset = reset;
			
			int digitStart = GetDigitStart.GetDigitStartColorBase(Background);

			Type = ColorBaseTypeSwitch.ColorBaseTypeSwitchString(Reset, type);
			(BasicShade, Red, Green, Blue) = ColorTypeSwitch.SwitchColorRGBInt(red, green, blue, digitStart);
			Extra = ";2;" + Red + ";" + Green + ";" + Blue;
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
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///         </listheader>
		///         <item>
		///             <term>Regular (0)</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold (1)</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled (2)</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic (3)</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined (4)</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink (5)</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid (6)</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight (7)</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight (8)</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough (9)</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///			<item>
		///             <term>Doubleline (21)</term>
		///             <description>This will make the text appear with an underline, and a underline under that underline.</description>
		///			</item>
		///			<item>
		///             <term>Overlined (53)</term>
		///             <description>This will make the text appear with an overline.</description>
		///			</item>
		///			<item>
		///             <term>Framed (51)</term>
		///             <description>This will make the text appear boxed.</description>
		///			</item>
		///			<item>
		///             <term>Encircled (52)</term>
		///             <description>This will make the text appear circled.</description>
		///			</item>
		///     </list>
		/// </param>
		/// <param name="background">Whether the applicant color should be applied to the background or foreground, defaults to foreground.</param>
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB(int type, int red, int green, int blue, bool background = false, bool reset = false)
		{
			Background = background;
			Reset = reset;
			
			int digitStart = GetDigitStart.GetDigitStartColorBase(Background);

			Type = ColorBaseTypeSwitch.ColorBaseTypeSwitchInt(Reset, type);
			(BasicShade, Red, Green, Blue) = ColorTypeSwitch.SwitchColorRGBInt(red, green, blue, digitStart);
			Extra = ";2;" + Red + ";" + Green + ";" + Blue;
		}
		
		/// <summary>
		/// Constructs a ColorRGB from a passed RGB and a Type, along with overloads for more options.
		/// </summary>
		/// <param name="rgbPair">
		/// The Tupple from the Resultant of a RGB Conversion for Ease of Use.
		/// </param>
		/// <param name="type">
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///         </listheader>
		///         <item>
		///             <term>Regular (0)</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold (1)</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled (2)</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic (3)</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined (4)</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink (5)</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid (6)</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight (7)</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight (8)</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough (9)</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///			<item>
		///             <term>Doubleline (21)</term>
		///             <description>This will make the text appear with an underline, and a underline under that underline.</description>
		///			</item>
		///			<item>
		///             <term>Overlined (53)</term>
		///             <description>This will make the text appear with an overline.</description>
		///			</item>
		///			<item>
		///             <term>Framed (51)</term>
		///             <description>This will make the text appear boxed.</description>
		///			</item>
		///			<item>
		///             <term>Encircled (52)</term>
		///             <description>This will make the text appear circled.</description>
		///			</item>
		///     </list>
		/// </param>
		/// <param name="background">Whether the applicant color should be applied to the background or foreground, defaults to foreground.</param>
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB(string type, (int red, int green, int blue) rgbPair, bool background = false, bool reset = false)
		{
			Background = background;
			Reset = reset;
			
			int digitStart = GetDigitStart.GetDigitStartColorBase(Background);

			Type = ColorBaseTypeSwitch.ColorBaseTypeSwitchString(Reset, type);
			(BasicShade, Red, Green, Blue) = ColorTypeSwitch.SwitchColorRGBInt(rgbPair.red, rgbPair.green, rgbPair.blue, digitStart);
			Extra = ";2;" + Red + ";" + Green + ";" + Blue;
		}
		
		/// <summary>
		/// Constructs a ColorRGB from a passed RGB and a Type, along with overloads for more options.
		/// </summary>
		/// <param name="rgbPair">
		/// The Tupple from the Resultant of a RGB Conversion for Ease of Use.
		/// </param>
		/// <param name="type">
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///         </listheader>
		///         <item>
		///             <term>Regular (0)</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold (1)</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled (2)</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic (3)</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined (4)</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink (5)</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid (6)</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight (7)</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight (8)</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough (9)</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///			<item>
		///             <term>Doubleline (21)</term>
		///             <description>This will make the text appear with an underline, and a underline under that underline.</description>
		///			</item>
		///			<item>
		///             <term>Overlined (53)</term>
		///             <description>This will make the text appear with an overline.</description>
		///			</item>
		///			<item>
		///             <term>Framed (51)</term>
		///             <description>This will make the text appear boxed.</description>
		///			</item>
		///			<item>
		///             <term>Encircled (52)</term>
		///             <description>This will make the text appear circled.</description>
		///			</item>
		///     </list>
		/// </param>
		/// <param name="background">Whether the applicant color should be applied to the background or foreground, defaults to foreground.</param>
		/// <param name="reset">Whether the applicant color should be a reset or not, defaults to not.</param>
		/// <returns>A object representing the given color.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB(int type, (int red, int green, int blue) rgbPair, bool background = false, bool reset = false)
		{
			Background = background;
			Reset = reset;
			
			int digitStart = GetDigitStart.GetDigitStartColorBase(Background);

			Type = ColorBaseTypeSwitch.ColorBaseTypeSwitchInt(Reset, type);
			(BasicShade, Red, Green, Blue) = ColorTypeSwitch.SwitchColorRGBInt(rgbPair.red, rgbPair.green, rgbPair.blue, digitStart);
			Extra = ";2;" + Red + ";" + Green + ";" + Blue;
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
		/// Get's the ColorRGB Object with the passed in Type rather than the Original Type.
		/// </summary>
		/// <param name="type">
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///         </listheader>
		///         <item>
		///             <term>Regular (0)</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold (1)</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled (2)</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic (3)</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined (4)</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink (5)</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid (6)</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight (7)</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight (8)</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough (9)</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///			<item>
		///             <term>Doubleline (21)</term>
		///             <description>This will make the text appear with an underline, and a underline under that underline.</description>
		///			</item>
		///			<item>
		///             <term>Overlined (53)</term>
		///             <description>This will make the text appear with an overline.</description>
		///			</item>
		///			<item>
		///             <term>Framed (51)</term>
		///             <description>This will make the text appear boxed.</description>
		///			</item>
		///			<item>
		///             <term>Encircled (52)</term>
		///             <description>This will make the text appear circled.</description>
		///			</item>
		///     </list>
		/// </param>
		/// <returns>The Color object with the given type passed in rather than the original type.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB GetTypeVariant(string type) 
		{
			ColorRGB color = new ColorRGB(type, Red, Green, Blue, Background, Reset);
			return color;
		}
		
		/// <summary>
		/// Get's the ColorRGB Object with the passed in Type rather than the Original Type.
		/// </summary>
		/// <param name="type">
		///     <list type="table">
		///         <listheader>
		///             <term>Type</term>
		///             <description>What It Does</description>
		///         </listheader>
		///         <item>
		///             <term>Regular (0)</term>
		///             <description>This is essentially just the mundane colors.</description>
		///         </item>
		///         <item>
		///             <term>Bold (1)</term>
		///             <description>This will make the text and color bold and more prominent.</description>
		///         </item>
		///         <item>
		///             <term>Dulled (2)</term>
		///             <description>The opposite of Bold, it will make the text and color dark and less prominent.</description>
		///         </item>
		///         <item>
		///             <term>Italic (3)</term>
		///             <description>This will make the text along with the color Italic.</description>
		///         </item>
		///         <item>
		///             <term>Underlined (4)</term>
		///             <description>This will make the text along with the color Underlined.</description>
		///         </item>
		///         <item>
		///             <term>Blink (5)</term>
		///             <description>This will make the text along with the color Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Rapid (6)</term>
		///             <description>This will make the text along with the color Rapidly Blink on and off.</description>
		///         </item>
		///         <item>
		///             <term>Highlight (7)</term>
		///             <description>This will make the text the shade given and the background behind it the inverse of the shade specified.</description>
		///         </item>
		///         <item>
		///             <term>Underlight (8)</term>
		///             <description>This will make the text invisible along with the color.</description>
		///         </item>
		///         <item>
		///             <term>Strikethrough (9)</term>
		///             <description>This will make the text look like it has a line going through it.</description>
		///         </item>
		///			<item>
		///             <term>Doubleline (21)</term>
		///             <description>This will make the text appear with an underline, and a underline under that underline.</description>
		///			</item>
		///			<item>
		///             <term>Overlined (53)</term>
		///             <description>This will make the text appear with an overline.</description>
		///			</item>
		///			<item>
		///             <term>Framed (51)</term>
		///             <description>This will make the text appear boxed.</description>
		///			</item>
		///			<item>
		///             <term>Encircled (52)</term>
		///             <description>This will make the text appear circled.</description>
		///			</item>
		///     </list>
		/// </param>
		/// <returns>The Color object with the given type passed in rather than the original type.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB GetTypeVariant(int type) 
		{
			ColorRGB color = new ColorRGB(type, Red, Green, Blue, Background, Reset);
			return color;
		}
		
		/// <summary>
		/// Get's the ColorRGB Object with its BaseColor switched out for a different one.
		/// </summary>
		/// <param name="red">The red value in which you want to switch in</param>
		/// <param name="green">The green value in which you want to switch in</param>
		/// <param name="blue">The red value in which you want to switch in</param>
		/// <returns>The Color Object with the Given color switched in.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB GetColorVariant(int red, int green, int blue)
		{
			ColorRGB color = new ColorRGB(Type, red, green, blue, Background, Reset);
			return color;
		}
		
		/// <summary>
		/// Get's the ColorRGB Object with its BaseColor switched out for a different one.
		/// </summary>
		/// <param name="rgbPair">The tupple as a resultant of a RGB Conversion.</param>
		/// <returns>The Color Object with the Given color switched in.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public ColorRGB GetColorVariant((int red, int green, int blue) rgbPair)
		{
			ColorRGB color = new ColorRGB(Type, rgbPair.red, rgbPair.green, rgbPair.blue, Background, Reset);
			return color;
		}
	}
}