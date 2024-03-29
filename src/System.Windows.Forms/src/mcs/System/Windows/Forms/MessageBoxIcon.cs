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
	public enum MessageBoxIcon
	{
        /// <summary>
        ///  Specifies that the message box contain no symbols.
        /// </summary>
		None 		= 0x0000,

        /// <summary>
        ///  Specifies that the message box contains a hand icon.
        /// </summary>
        Error = Hand,

        /// <summary>
        ///  Specifies that the message box contains a hand symbol.
        /// </summary>
		Hand 		= 0x0010,

        /// <summary>
        ///  Specifies that the message box contains a hand icon. This field is
        ///  constant.
        /// </summary>
        Stop = Hand,

        /// <summary>
        ///  Specifies that the message box contains a question mark symbol.
        /// </summary>
		Question 	= 0x0020,

        /// <summary>
        ///  Specifies that the message box contains an exclamation symbol.
        /// </summary>
		Exclamation 	= 0x0030,

        /// <summary>
        ///  Specifies that the message box contains an exclamation icon.
        /// </summary>
        Warning = Exclamation,

        /// <summary>
        ///  Specifies that the message box contains an asterisk symbol.
        /// </summary>
		Asterisk 	= 0x0040,
		
        /// <summary>
        ///  Specifies that the message box contains an asterisk icon.
        /// </summary>
        Information = Asterisk,
	}
}
