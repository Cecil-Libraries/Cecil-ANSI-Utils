namespace Cecil_Libraries.ANSI_Utils.Util
{
	/// <summary>
	/// This class contains functions related to getting the proper form of the Type. This contains 2 functions <see cref="ColorBaseTypeSwitchInt"/> and <see cref="ColorBaseTypeSwitchString"/>.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class ColorBaseTypeSwitch
	{
		/// <summary>
		/// The unified get type from string method used by the Object's, this is primarily for internal use!!
		/// </summary>
		/// <param name="reset">A bool determining whether the type should be of a reset or not.</param>
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
		/// <returns></returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static int ColorBaseTypeSwitchString (bool reset, string type)
		{
			int Type = 0;
			if (reset)
	        {
		        switch (type)
		        {
			        case "Regular":
				        Type = 0;
				        break;
			        case "Bold":
				        Type = int.Parse("2" + 2.ToString());
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
			        case "Doubleline":
				        Type = int.Parse("2" + 4.ToString());
				        break;
			        case "Overlined":
				        Type = int.Parse("5" + 5.ToString());
				        break;
			        case "Framed":
				        Type = int.Parse("5" + 4.ToString());
				        break;
			        case "Encircled":
				        Type = int.Parse("5" + 4.ToString());
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
			        case "Doubleline":
				        Type = 21;
				        break;
			        case "Overlined":
						Type = 53;
				        break;
			        case "Framed":
				        Type = 51;
				        break;
			        case "Encircled":
				        Type = 52;
				        break;
		        }
	        }

			return Type;
		}

		/// <summary>
		/// The unified get type from int method used by the Object's, this is primarily for internal use!!
		/// </summary>
		/// <param name="reset">A bool determining whether the type should be of a reset or not.</param>
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
		/// <returns></returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static int ColorBaseTypeSwitchInt(bool reset, int type)
		{
			int Type = 0;
			if (reset)
			{
				switch (type)
				{
					case 0:
						Type = 0;
						break;
					case 1:
						Type = 22;
						break;
					case 21:
						Type = 24;
						break;
					case 51:
					case 52:
						Type = 54;
						break;
					case 53:
						Type = 55;
						break;
					default:
						Type = int.Parse("2" + type.ToString());
						break;
				}
			} else if (!reset)
			{
				Type = type;
			}

			return Type;
		}
	}
}