/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeTagsResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<Tag> tags;

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public class Tag{

			private string tagKey;

			private string tagValue;

			private ResourceTypeCount_ resourceTypeCount;

			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			public ResourceTypeCount_ ResourceTypeCount
			{
				get
				{
					return resourceTypeCount;
				}
				set	
				{
					resourceTypeCount = value;
				}
			}

			public class ResourceTypeCount_{

				private int? instance;

				private int? disk;

				private int? image;

				private int? snapshot;

				private int? securitygroup;

				public int? Instance
				{
					get
					{
						return instance;
					}
					set	
					{
						instance = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public int? Image
				{
					get
					{
						return image;
					}
					set	
					{
						image = value;
					}
				}

				public int? Snapshot
				{
					get
					{
						return snapshot;
					}
					set	
					{
						snapshot = value;
					}
				}

				public int? Securitygroup
				{
					get
					{
						return securitygroup;
					}
					set	
					{
						securitygroup = value;
					}
				}
			}
		}
	}
}