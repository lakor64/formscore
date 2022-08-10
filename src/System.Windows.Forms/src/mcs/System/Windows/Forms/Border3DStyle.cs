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
    ///  Specifies the style of a three-dimensional border.
    /// </summary>
	public enum Border3DStyle {

        /// <summary>
        ///  The border has a with a raised outer edge and no inner edge.
        /// </summary>
		RaisedOuter	= 1,

        /// <summary>
        ///  The border has a with a sunken outer edge and no inner edge.
        /// </summary>
		SunkenOuter	= 2,

        /// <summary>
        ///  The border has a with a raised inner edge and no outer edge.
        /// </summary>
		RaisedInner	= 4,

        /// <summary>
        ///  The border has a with raised inner and outer edges.
        /// </summary>
		Raised		= 5,

        /// <summary>
        ///  The border has a with a sunken inner edge and a raised outer edge.
        /// </summary>
		Etched		= 6,

        /// <summary>
        ///  The border has a with a sunken inner edge and no outer edge.
        /// </summary>
		SunkenInner	= 8,

        /// <summary>
        ///  The border has a raised outer edge and a sunken inner edge.
        /// </summary>
		Bump		= 9,

        /// <summary>
        ///  The border has a with sunken inner and outer edges.
        /// </summary>
		Sunken		= 10,

        /// <summary>
        ///  The border is drawn outside the specified rectangle, preserving the
        ///  dimensions of the rectangle for drawing.
        /// </summary>
		Adjust		= 8192,

        /// <summary>
        ///  The border has a with no three-dimensional effects.
        /// </summary>
		Flat		= 16394
	}
}
