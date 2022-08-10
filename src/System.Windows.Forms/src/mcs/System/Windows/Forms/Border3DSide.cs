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
// Copyright (c) 2004-2005 Novell, Inc.
//
// Authors:
//	Peter Bartok	pbartok@novell.com
//


// COMPLETE

using System.Runtime.InteropServices;

namespace System.Windows.Forms {

    /// <summary>
    ///  Specifies the sides of a rectangle to apply a three-dimensional border to.
    /// </summary>
	[Flags]
	public enum Border3DSide {
        /// <summary>
        ///  A three-dimensional border on the left edge of the control.
        /// </summary>
		Left	= 0x00000001,

        /// <summary>
        ///  A three-dimensional border on the top edge of the rectangle.
        /// </summary>
		Top	= 0x00000002,

        /// <summary>
        ///  A three-dimensional border on the right side of the rectangle.
        /// </summary>
		Right	= 0x00000004,

        /// <summary>
        ///  A three-dimensional border on the bottom side of the rectangle.
        /// </summary>
		Bottom	= 0x00000008,

		/// <summary>
        ///  The interior of the rectangle is filled with the color defined for
        ///  three-dimensional controls instead of the background color for the form.
        /// </summary>
		Middle	= 0x00000800,

        /// <summary>
        ///  A three-dimensional border on all four edges and fill the middle of
        ///  the rectangle with the color defined for three-dimensional controls.
        /// </summary>
        All = Left | Top | Right | Bottom | Middle,
	}
}
