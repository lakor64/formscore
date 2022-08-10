//
// AutoCompleteMode.cs
//
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
// Copyright (c) 2006 Novell, Inc.
//
// Authors:
//	Jonathan Pobst (monkey@jpobst.com)
//

namespace System.Windows.Forms
{
	/// <summary>
	///  Specifies the autocomplete mode for ComboBox and TextBox AutoComplete Feature.
	/// </summary>
	public enum AutoCompleteMode
	{
		/// <summary>
		///  Disables the AutoComplete Feature for ComboBox and TextBox.
		/// </summary>
		None = 0,

		/// <summary>
		///  Displays the auxiliary drop-down list associated with the edit control,
		///  this drop-down is populated with one or more suggested completed strings.
		/// </summary>
		Suggest = 1,

		/// <summary>
		///  Appends the remainder of the most likely candidate string to the existing
		///  characters, highlighting the appended characters.
		/// </summary>
		Append = 2,

		/// <summary>
		///  The AutoSuggest and AutoAppend are applied in conjuction.
		/// </summary>
		SuggestAppend = Suggest | Append
	}
}
