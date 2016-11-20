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
using Northwind.Domain.Orders.Events;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Commands;
using Cqrs.Domain;

namespace Northwind.Domain.Orders.Commands.Handlers
{

	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	public  partial class UpdateOrderCommandHandler
		
		: ICommandHandler<Cqrs.Authentication.ISingleSignOnToken, UpdateOrderCommand>
	{
		protected IUnitOfWork<Cqrs.Authentication.ISingleSignOnToken> UnitOfWork { get; private set; }


		public UpdateOrderCommandHandler(IUnitOfWork<Cqrs.Authentication.ISingleSignOnToken> unitOfWork)
		{
			UnitOfWork = unitOfWork;
		}

		#region Implementation of ICommandHandler<in UpdateOrderCommand>

		public void Handle(UpdateOrderCommand command)
		{
			Order item = null;
			OnUpdateOrder(command, ref item);
			if (item == null)
				item = UnitOfWork.Get<Order>(command.Rsn);
			item.UpdateOrder(command.OrderId, command.CustomerId, command.EmployeeId, command.OrderDate, command.RequiredDate, command.ShippedDate, command.ShipViaId, command.Freight, command.ShipName, command.ShipAddress, command.ShipCity, command.ShipRegion, command.ShipPostalCode, command.ShipCountry);
			OnUpdatedOrder(command, item);
			OnCommit(command, item);
			UnitOfWork.Commit();
			OnCommited(command, item);
		}

		#endregion

		partial void OnUpdateOrder(UpdateOrderCommand command, ref Order item);

		partial void OnUpdatedOrder(UpdateOrderCommand command, Order item);

		partial void OnCommit(UpdateOrderCommand command, Order item);

		partial void OnCommited(UpdateOrderCommand command, Order item);
	}
}
