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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class ForbidLiveStreamRequest : RpcAcsRequest<ForbidLiveStreamResponse>
    {
        public ForbidLiveStreamRequest()
            : base("Cdn", "2014-11-11", "ForbidLiveStream")
        {
        }

		private long? ownerId;

		private string securityToken;

		private string domainName;

		private string liveStreamType;

		private string appName;

		private string streamName;

		private string resumeTime;

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string LiveStreamType
		{
			get
			{
				return liveStreamType;
			}
			set	
			{
				liveStreamType = value;
				DictionaryUtil.Add(QueryParameters, "LiveStreamType", value);
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string StreamName
		{
			get
			{
				return streamName;
			}
			set	
			{
				streamName = value;
				DictionaryUtil.Add(QueryParameters, "StreamName", value);
			}
		}

		public string ResumeTime
		{
			get
			{
				return resumeTime;
			}
			set	
			{
				resumeTime = value;
				DictionaryUtil.Add(QueryParameters, "ResumeTime", value);
			}
		}

        public override ForbidLiveStreamResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ForbidLiveStreamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}