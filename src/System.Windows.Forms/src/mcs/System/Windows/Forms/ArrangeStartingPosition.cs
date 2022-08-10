// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2005 Novell, Inc. (http://www.novell.com)
//
// Authors:
//	Peter Bartok	pbartok@novell.com
//
//

// COMPLETE

namespace System.Windows.Forms {
	/// <summary>
	///  Specifies the starting position that the system uses to arrange minimized
	///  windows.
	/// </summary>
	[Flags]
	public enum ArrangeStartingPosition {
		/// <summary>
		///  Starts at the lower-left corner of the screen, which is the default position.
		/// </summary>
		BottomLeft = 0,

		/// <summary>
		///  Starts at the lower-right corner of the screen.
		/// </summary>
		BottomRight = 1,

		/// <summary>
		///  Starts at the upper-left corner of the screen.
		/// </summary>
		TopLeft = 2,

		/// <summary>
		///  Starts at the upper-right corner of the screen.
		/// </summary>
		TopRight = 3,

		/// <summary>
		///  Hides minimized windows by moving them off the visible area of the
		///  screen.
		/// </summary>
		Hide = 8
	}
}
