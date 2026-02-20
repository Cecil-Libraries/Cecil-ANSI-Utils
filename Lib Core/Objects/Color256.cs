using Cecil_Libraries.ANSI_Utils.Util;

namespace Cecil_Libraries.ANSI_Utils.Objects
{
	/// <summary>
	/// A object for 256 ANSI Colors. A preview can be found within <see cref="Displayer"/>. Supports Background Toggles, Font Settings, and resets.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class Color256 : ColorBase
	{
		/// <summary>
		/// The Color256's Shade
		/// </summary>
		public int Shade256 { get; set; }
		
		/// <summary>
		/// Constructs a Color256 from a passed int Shade and a Type, along with overloads for more options.
		/// </summary>
		/// <param name="shade">
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
		public Color256(string type, int shade, bool background = false, bool reset = false)
		{
			Background = background;
			Reset = reset;
			
			int digitStart = GetDigitStart.GetDigitStartColorBase(Background);

			Type = ColorBaseTypeSwitch.ColorBaseTypeSwitchString(Reset, type);
			(BasicShade, Shade256) = ColorTypeSwitch.SwitchColor256Int(shade, digitStart);
			Extra = ";5;" + Shade256;
		}
		
		/// <summary>
		/// Constructs a Color256 from a passed int Shade and a Type, along with overloads for more options.
		/// </summary>
		/// <param name="shade">
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
		public Color256(int type, int shade, bool background = false, bool reset = false)
		{
			Background = background;
			Reset = reset;
			
			int digitStart = GetDigitStart.GetDigitStartColorBase(Background);
			
			Type = ColorBaseTypeSwitch.ColorBaseTypeSwitchInt(Reset, type);
			(BasicShade, Shade256) = ColorTypeSwitch.SwitchColor256Int(shade, digitStart);
			Extra = ";5;" + Shade256;
		}
		
		/// <summary>
		/// This will get the Reset from the Original Color256 Object, note using it on a Reset will just spit back the same Reset
		/// </summary>
		/// <returns>A reset version of the Color256</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public Color256 GetReset()
		{
			Color256 color = new Color256(Type, Shade256, Background, reset: true);
			return color;
		}
		
		/// <summary>
		/// Get's the Color256 Object with the passed in Type rather than the Original Type.
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
		public Color256 GetTypeVariant(string type) 
		{
			Color256 color = new Color256(type, Shade256, Background, Reset);
			return color;
		}
		
		/// <summary>
		/// Get's the Color256 Object with the passed in Type rather than the Original Type.
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
		public Color256 GetTypeVariant(int type) 
		{
			Color256 color = new Color256(type, Shade256, Background, Reset);
			return color;
		}
		
		/// <summary>
		/// Get's the Color256 Object with its BaseColor switched out for a different one.
		/// </summary>
		/// <param name="shade">A int from 0 to 255.</param>
		/// <returns>The Color Object with the Given color switched in.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public Color256 GetColorVariant(int shade)
		{
			Color256 color = new Color256(Type, shade, Background, Reset);
			return color;
		}
	}
}