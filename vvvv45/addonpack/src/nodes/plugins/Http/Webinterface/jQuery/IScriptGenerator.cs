using System;
using System.Collections.Generic;
using System.Text;

namespace VVVV.Nodes.jQuery
{
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Interface for any class that will generate script. </summary>
	///
	/// <remarks>	Administrator, 10/20/2009. </remarks>
	////////////////////////////////////////////////////////////////////////////////////////////////////

	interface IScriptGenerator
	{
		////////////////////////////////////////////////////////////////////////////////////////////////////
		/// <summary>	 Returns all generated script as a string. </summary>
		////////////////////////////////////////////////////////////////////////////////////////////////////

		string PScript
		{
			get;
		}
	}
}