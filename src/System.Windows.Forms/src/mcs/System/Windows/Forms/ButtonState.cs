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
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Peter Bartok	pbartok@novell.com
//


// COMPLETE

namespace System.Windows.Forms {

    /// <summary>
    ///  Specifies the appearance of a button.
    /// </summary>
	[Flags]
	public enum ButtonState {
        /// <summary>
        ///  The button has its normal appearance (three-dimensional and not pressed).
        /// </summary>
		Normal		= 0x00000000,

        /// <summary>
        ///  The button is inactive (grayed).
        /// </summary>
		Inactive	= 0x00000100,

        /// <summary>
        ///  The button is currently pressed.
        /// </summary>
		Pushed		= 0x00000200,

        /// <summary>
        ///  The button has a checked or latched appearance. Use this appearance to
        ///  show that a toggle button has been pressed.
        /// </summary>
		Checked		= 0x00000400,

        /// <summary>
        ///  The button has a flat, two-dimensional appearance.
        /// </summary>
		Flat		= 0x00004000,

        /// <summary>
        ///  All viable flags in the bit mask are used.
        /// </summary>
        All = Flat | Checked | Pushed | Inactive,
	}
}
