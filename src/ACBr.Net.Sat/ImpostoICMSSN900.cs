// ***********************************************************************
// Assembly         : ACBr.Net.Sat
// Author           : RFTD
// Created          : 04-29-2016
//
// Last Modified By : RFTD
// Last Modified On : 05-01-2016
// ***********************************************************************
// <copyright file="ImpostoICMSSN900.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining 
// a copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be 
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF 
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;
using ACBr.Net.Sat.Interfaces;
using PropertyChanged;

namespace ACBr.Net.Sat
{
	/// <summary>
	/// Class ImpostoICMSSN900. This class cannot be inherited.
	/// </summary>
	[ImplementPropertyChanged]
	public sealed class ImpostoIcmsSn900 : ICFeIcms
	{
		#region Propriedades

		/// <summary>
		/// Gets or sets the original.
		/// </summary>
		/// <value>The original.</value>
		[DFeElement(TipoCampo.Enum, "Orig", Id = "N06", Min = 1, Max = 1, Ocorrencias = 1)]
		public OrigemMercadoria Orig { get; set; }

		/// <summary>
		/// Gets or sets the csosn.
		/// </summary>
		/// <value>The csosn.</value>
		[DFeElement(TipoCampo.Str, "CSOSN", Id = "N10", Min = 3, Max = 3, Ocorrencias = 1)]
		public string Csosn { get; set; }

		/// <summary>
		/// Gets or sets the p icms.
		/// </summary>
		/// <value>The p icms.</value>
		[DFeElement(TipoCampo.De2, "pICMS", Id = "N08", Min = 3, Max = 5, Ocorrencias = 1)]
		public decimal PIcms { get; set; }

		/// <summary>
		/// Gets or sets the v icms.
		/// </summary>
		/// <value>The v icms.</value>
		[DFeElement(TipoCampo.De2, "vICMS", Id = "N09", Min = 3, Max = 15, Ocorrencias = 1)]
		public decimal VIcms { get; set; }

		#endregion Propriedades

		#region Methods

		private bool ShouldSerializeVIcms()
		{
			return VIcms > 0;
		}

		#endregion Methods
	}
}