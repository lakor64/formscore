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

namespace System.Windows.Forms
{
    /// <summary>
    ///  Specifies the type of action used to raise the <see cref='ScrollBar.Scroll'/> event.
    /// </summary>
	public enum ScrollEventType
	{
        /// <summary>
        ///  The scroll box was moved a small distance. The user clicked the
        ///  left (horizontal) or top (vertical) scroll arrow or pressed
        ///  the UP ARROW
        /// </summary>
		SmallDecrement	= 0,

        /// <summary>
        ///  The scroll box was moved a small distance. The user clicked the
        ///  right (horizontal) or bottom (vertical) scroll arrow or pressed
        ///  the DOWN ARROW key.
        /// </summary>
		SmallIncrement	= 1,

		/// <summary>
        ///  The scroll box moved a large distance. The user clicked the scroll bar
        ///  to the left (horizontal) or above (vertical) the scroll box, or pressed
        ///  the PAGE UP key.
        /// </summary>
		LargeDecrement	= 2,

        /// <summary>
        ///  The scroll box moved a large distance. The user clicked the scroll bar
        ///  to the right (horizontal) or below (vertical) the scroll box, or pressed
        ///  the PAGE DOWN key.
        /// </summary>
		LargeIncrement	= 3,

        /// <summary>
        ///  The scroll box was moved.
        /// </summary>
		ThumbPosition	= 4,

        /// <summary>
        ///  The scroll box is currently being moved.
        /// </summary>
		ThumbTrack	= 5,

        /// <summary>
        ///  The scroll box was moved to the <see cref='ScrollBar.Minimum'/>
        ///  position.
        /// </summary>
		First		= 6,

        /// <summary>
        ///  The scroll box was moved to the <see cref='ScrollBar.Maximum'/>
        ///  position.
        /// </summary>
		Last		= 7,

        /// <summary>
        ///  The scroll box has stopped moving.
        /// </summary>
		EndScroll	= 8,
	}
}
