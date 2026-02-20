using Cecil_Libraries.ANSI_Utils.Objects;

namespace Cecil_Libraries.ANSI_Utils.Lists.DefaultLists.ResetColorObjects
{
	/// <summary>
	/// This is a List of Defaults related to Color Object Resets, so that you don't need to make Objects yourself that are often common.
	/// </summary>
	/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
	public class Defaults
	{
		/// <summary>
		/// A Reset of the Foreground, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetForeground => new Color("Regular", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Foreground, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetBackground => new Color("Regular", "White", background:true, reset:true);
		
		/// <summary>
		/// A Reset of the Bold Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetBold => new Color("Bold", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Dulled Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetDulled => new Color("Dulled", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Italic Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetItalic => new Color("Italic", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Underlined Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetUnderlined => new Color("Underlined", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Blink Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetBlink => new Color("Blink", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Rapid Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetRapid => new Color("Rapid", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Highlight Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetHighlight => new Color("Highlight", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Underlight Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetUnderlight => new Color("Underlight", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Strikethrough Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetStrikethrough => new Color("Strikethrough", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Doubleline Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetDoubleline => new Color("Doubleline", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Overline Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetOverline => new Color("Overline", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Framed Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetFramed => new Color("Framed", "White", reset:true);
		
		/// <summary>
		/// A Reset of the Encircled Text Processing Mode, all normal Color Operations still work.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static Color ResetEncircled => new Color("Encircled", "White", reset:true);
	}
}