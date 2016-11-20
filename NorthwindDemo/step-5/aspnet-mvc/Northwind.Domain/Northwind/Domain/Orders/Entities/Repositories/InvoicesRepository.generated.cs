﻿










//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Cqrs.Repositories;
using Northwind.Domain.Factories;

using Northwind.Domain.Orders.Repositories.Queries.Strategies;

namespace Northwind.Domain.Orders.Entities.Repositories
{

	[GeneratedCode("CQRS UML Code Generator", "1.601.909")]
	public partial class InvoicesRepository : Repository<InvoicesQueryStrategy, InvoicesQueryStrategyBuilder, Entities.InvoicesEntity>, IInvoicesRepository
	{
		public InvoicesRepository(IDomainDataStoreFactory dataStoreFactory, InvoicesQueryStrategyBuilder invoicesQueryBuilder)
			: base(dataStoreFactory.GetInvoicesDataStore, invoicesQueryBuilder)
		{
		}
	}
}
