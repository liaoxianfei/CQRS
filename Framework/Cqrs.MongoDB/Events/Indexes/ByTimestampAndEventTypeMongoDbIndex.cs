﻿#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="cdmdotnet Limited">
// // 	Copyright cdmdotnet Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using System;
using System.Linq.Expressions;
using Cqrs.MongoDB.DataStores.Indexes;

namespace Cqrs.MongoDB.Events.Indexes
{
	public class ByTimestampAndEventTypeMongoDbIndex : MongoDbIndex<MongoDbEventData>
	{
		public ByTimestampAndEventTypeMongoDbIndex()
		{
			Selectors = new Expression<Func<MongoDbEventData, object>>[]
			{
				entity => entity.Timestamp,
				entity => entity.EventType
			};

			IsUnique = false;
		}
	}
}