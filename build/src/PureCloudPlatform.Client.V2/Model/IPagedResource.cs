using System;
using System.Collections.Generic;
using PureCloudPlatform.Client.V2.Model;
using WebSocketSharp;

namespace PureCloudPlatform.Client.V2.Model
{
	///<Summary>
        /// Interface for Paged Resource
        ///</Summary>
        public interface IPagedResource<T>
	{
                ///<Summary>
                /// Page Size
                ///</Summary>
                int? PageSize { get; set; }
                ///<Summary>
                /// Page Number
                ///</Summary>
                int? PageNumber { get; set; }
                ///<Summary>
                /// Total
                ///</Summary>
                long? Total { get; set; }
                ///<Summary>
                /// Self Uri
                ///</Summary>
                string SelfUri { get; set; }
                ///<Summary>
                /// First Uri
                ///</Summary>
                string FirstUri { get; set; }
                ///<Summary>
                /// Previous Uri
                ///</Summary>
                string PreviousUri { get; set; }
                ///<Summary>
                /// Next Uri
                ///</Summary>
                string NextUri { get; set; }
                ///<Summary>
                /// Last Uri
                ///</Summary>
                string LastUri { get; set; }
                ///<Summary>
                /// Page Count
                ///</Summary>
                int? PageCount { get; set; }
                ///<Summary>
                /// Entities
                ///</Summary>
                List<T> Entities { get; set; }
	}
}