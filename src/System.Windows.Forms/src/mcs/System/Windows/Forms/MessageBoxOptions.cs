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
//	Jordi Mas i Hernandez, jordi@ximian.com
//
//


// COMPLETE

namespace System.Windows.Forms
{	
	[Flags]
	public enum MessageBoxOptions
	{

        /// <summary>
        ///  Specifies that the message box is displayed on the active desktop.
        /// </summary>
		DefaultDesktopOnly	= 0x20000,

        /// <summary>
        ///  Specifies that the message box text is right-aligned.
        /// </summary>
		RightAlign 		= 0x80000,

        /// <summary>
        ///  Specifies that the message box text is displayed with Rtl reading order.
        /// </summary>
		RtlReading 		= 0x100000,

        /// <summary>
        ///  Specifies that the message box is displayed on the active desktop.
        /// </summary>
		ServiceNotification 	= 0x200000,
	}
}

