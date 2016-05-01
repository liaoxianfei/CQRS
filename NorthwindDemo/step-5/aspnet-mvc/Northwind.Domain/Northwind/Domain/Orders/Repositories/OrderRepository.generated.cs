﻿//------------------------------------------------------------------------------
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

namespace Northwind.Domain.Orders.Repositories
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	public partial class OrderRepository : Repository<OrderQueryStrategy, OrderQueryStrategyBuilder, Entities.OrderEntity>, IOrderRepository
	{
		public OrderRepository(IDomainDataStoreFactory dataStoreFactory, OrderQueryStrategyBuilder orderQueryBuilder)
			: base(dataStoreFactory.GetOrderDataStore, orderQueryBuilder)
		{
		}
	}
}
