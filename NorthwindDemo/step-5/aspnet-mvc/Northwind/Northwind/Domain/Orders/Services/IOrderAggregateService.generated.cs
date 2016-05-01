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
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Cqrs.Authentication;
using Cqrs.Services;

namespace Northwind.Domain.Orders.Services
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	[ServiceContract(Namespace="https://cqrs.co.nz/Domain/Orders/1001/")]
	public partial interface IOrderService : IEventService<Cqrs.Authentication.ISingleSignOnToken>
	{

		/// <summary>
		/// Create a new instance of the <see cref="Entities.OrderEntity"/>
		/// </summary>
		[OperationContract]
		IServiceResponseWithResultData<Entities.OrderEntity> CreateOrder(IServiceRequestWithData<Cqrs.Authentication.ISingleSignOnToken, Entities.OrderEntity> serviceRequest);

		/// <summary>
		/// Update an existing instance of the <see cref="Entities.OrderEntity"/>
		/// </summary>
		[OperationContract]
		IServiceResponseWithResultData<Entities.OrderEntity> UpdateOrder(IServiceRequestWithData<Cqrs.Authentication.ISingleSignOnToken, Entities.OrderEntity> serviceRequest);

		/// <summary>
		/// Logically delete an existing instance of the <see cref="Entities.OrderEntity"/>
		/// </summary>
		[OperationContract]
		IServiceResponse DeleteOrder(IServiceRequestWithData<Cqrs.Authentication.ISingleSignOnToken, Entities.OrderEntity> serviceRequest);
	}
}
