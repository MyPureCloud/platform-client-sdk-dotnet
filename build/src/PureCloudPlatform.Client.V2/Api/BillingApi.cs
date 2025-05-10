using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBillingApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get billing contract
        /// </summary>
        /// <remarks>
        /// Retrieve a single contract from the system.
        /// GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <returns>BillingContract</returns>
        
        BillingContract GetBillingContract (string contractId);

        /// <summary>
        /// Get billing contract
        /// </summary>
        /// <remarks>
        /// Retrieve a single contract from the system.
        /// GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <returns>ApiResponse of BillingContract</returns>
        
        ApiResponse<BillingContract> GetBillingContractWithHttpInfo (string contractId);

        /// <summary>
        /// Get contract billing period
        /// </summary>
        /// <remarks>
        /// Fetch the billing information for a given Organization by billing period.
        /// GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <param name="billingPeriodId">The Billing Period Id for the Org.</param>
        /// <returns>BillingContractPeriodDetail</returns>
        
        BillingContractPeriodDetail GetBillingContractBillingperiod (string contractId, string billingPeriodId);

        /// <summary>
        /// Get contract billing period
        /// </summary>
        /// <remarks>
        /// Fetch the billing information for a given Organization by billing period.
        /// GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <param name="billingPeriodId">The Billing Period Id for the Org.</param>
        /// <returns>ApiResponse of BillingContractPeriodDetail</returns>
        
        ApiResponse<BillingContractPeriodDetail> GetBillingContractBillingperiodWithHttpInfo (string contractId, string billingPeriodId);

        /// <summary>
        /// Get billing contracts
        /// </summary>
        /// <remarks>
        /// Retrieve a list of contracts stored in the system.
        /// GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="status">Filter by the status of contracts (optional)</param>
        /// <param name="externalNumber">Filter by the unique external number. (optional)</param>
        /// <returns>BillingContractListing</returns>
        
        BillingContractListing GetBillingContracts (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null);

        /// <summary>
        /// Get billing contracts
        /// </summary>
        /// <remarks>
        /// Retrieve a list of contracts stored in the system.
        /// GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="status">Filter by the status of contracts (optional)</param>
        /// <param name="externalNumber">Filter by the unique external number. (optional)</param>
        /// <returns>ApiResponse of BillingContractListing</returns>
        
        ApiResponse<BillingContractListing> GetBillingContractsWithHttpInfo (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null);

        /// <summary>
        /// Get invoice document
        /// </summary>
        /// <remarks>
        /// Fetch the document for a specific invoice.
        /// GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <returns>UrlResponse</returns>
        
        UrlResponse GetBillingContractsInvoiceDocument (string invoiceId);

        /// <summary>
        /// Get invoice document
        /// </summary>
        /// <remarks>
        /// Fetch the document for a specific invoice.
        /// GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        
        ApiResponse<UrlResponse> GetBillingContractsInvoiceDocumentWithHttpInfo (string invoiceId);

        /// <summary>
        /// Get invoice lines
        /// </summary>
        /// <remarks>
        /// Fetch a list of all bills for the specified account.
        /// GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>BillingInvoiceItemListing</returns>
        
        BillingInvoiceItemListing GetBillingContractsInvoiceLines (string invoiceId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get invoice lines
        /// </summary>
        /// <remarks>
        /// Fetch a list of all bills for the specified account.
        /// GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>ApiResponse of BillingInvoiceItemListing</returns>
        
        ApiResponse<BillingInvoiceItemListing> GetBillingContractsInvoiceLinesWithHttpInfo (string invoiceId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get invoices
        /// </summary>
        /// <remarks>
        /// Retrieve a list of invoices stored in the system.
        /// GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="paymentStatus">Payment Status (optional)</param>
        /// <returns>BillingInvoiceListing</returns>
        
        BillingInvoiceListing GetBillingContractsInvoices (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null);

        /// <summary>
        /// Get invoices
        /// </summary>
        /// <remarks>
        /// Retrieve a list of invoices stored in the system.
        /// GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="paymentStatus">Payment Status (optional)</param>
        /// <returns>ApiResponse of BillingInvoiceListing</returns>
        
        ApiResponse<BillingInvoiceListing> GetBillingContractsInvoicesWithHttpInfo (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null);

        /// <summary>
        /// Get a report of the billable license usages
        /// </summary>
        /// <remarks>
        /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <returns>BillingUsageReport</returns>
        
        BillingUsageReport GetBillingReportsBillableusage (DateTime? startDate, DateTime? endDate);

        /// <summary>
        /// Get a report of the billable license usages
        /// </summary>
        /// <remarks>
        /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <returns>ApiResponse of BillingUsageReport</returns>
        
        ApiResponse<BillingUsageReport> GetBillingReportsBillableusageWithHttpInfo (DateTime? startDate, DateTime? endDate);

        /// <summary>
        /// Get the billing overview for an organization that is managed by a partner.
        /// </summary>
        /// <remarks>
        /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
        /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
        /// <returns>TrusteeBillingOverview</returns>
        
        TrusteeBillingOverview GetBillingTrusteebillingoverviewTrustorOrgId (string trustorOrgId, int? billingPeriodIndex = null);

        /// <summary>
        /// Get the billing overview for an organization that is managed by a partner.
        /// </summary>
        /// <remarks>
        /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
        /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
        /// <returns>ApiResponse of TrusteeBillingOverview</returns>
        
        ApiResponse<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdWithHttpInfo (string trustorOrgId, int? billingPeriodIndex = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get billing contract
        /// </summary>
        /// <remarks>
        /// Retrieve a single contract from the system.
        /// GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <returns>Task of BillingContract</returns>
        
        System.Threading.Tasks.Task<BillingContract> GetBillingContractAsync (string contractId);

        /// <summary>
        /// Get billing contract
        /// </summary>
        /// <remarks>
        /// Retrieve a single contract from the system.
        /// GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <returns>Task of ApiResponse (BillingContract)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BillingContract>> GetBillingContractAsyncWithHttpInfo (string contractId);

        /// <summary>
        /// Get contract billing period
        /// </summary>
        /// <remarks>
        /// Fetch the billing information for a given Organization by billing period.
        /// GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <param name="billingPeriodId">The Billing Period Id for the Org.</param>
        /// <returns>Task of BillingContractPeriodDetail</returns>
        
        System.Threading.Tasks.Task<BillingContractPeriodDetail> GetBillingContractBillingperiodAsync (string contractId, string billingPeriodId);

        /// <summary>
        /// Get contract billing period
        /// </summary>
        /// <remarks>
        /// Fetch the billing information for a given Organization by billing period.
        /// GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <param name="billingPeriodId">The Billing Period Id for the Org.</param>
        /// <returns>Task of ApiResponse (BillingContractPeriodDetail)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BillingContractPeriodDetail>> GetBillingContractBillingperiodAsyncWithHttpInfo (string contractId, string billingPeriodId);

        /// <summary>
        /// Get billing contracts
        /// </summary>
        /// <remarks>
        /// Retrieve a list of contracts stored in the system.
        /// GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="status">Filter by the status of contracts (optional)</param>
        /// <param name="externalNumber">Filter by the unique external number. (optional)</param>
        /// <returns>Task of BillingContractListing</returns>
        
        System.Threading.Tasks.Task<BillingContractListing> GetBillingContractsAsync (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null);

        /// <summary>
        /// Get billing contracts
        /// </summary>
        /// <remarks>
        /// Retrieve a list of contracts stored in the system.
        /// GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="status">Filter by the status of contracts (optional)</param>
        /// <param name="externalNumber">Filter by the unique external number. (optional)</param>
        /// <returns>Task of ApiResponse (BillingContractListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BillingContractListing>> GetBillingContractsAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null);

        /// <summary>
        /// Get invoice document
        /// </summary>
        /// <remarks>
        /// Fetch the document for a specific invoice.
        /// GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <returns>Task of UrlResponse</returns>
        
        System.Threading.Tasks.Task<UrlResponse> GetBillingContractsInvoiceDocumentAsync (string invoiceId);

        /// <summary>
        /// Get invoice document
        /// </summary>
        /// <remarks>
        /// Fetch the document for a specific invoice.
        /// GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UrlResponse>> GetBillingContractsInvoiceDocumentAsyncWithHttpInfo (string invoiceId);

        /// <summary>
        /// Get invoice lines
        /// </summary>
        /// <remarks>
        /// Fetch a list of all bills for the specified account.
        /// GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of BillingInvoiceItemListing</returns>
        
        System.Threading.Tasks.Task<BillingInvoiceItemListing> GetBillingContractsInvoiceLinesAsync (string invoiceId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get invoice lines
        /// </summary>
        /// <remarks>
        /// Fetch a list of all bills for the specified account.
        /// GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of ApiResponse (BillingInvoiceItemListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BillingInvoiceItemListing>> GetBillingContractsInvoiceLinesAsyncWithHttpInfo (string invoiceId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get invoices
        /// </summary>
        /// <remarks>
        /// Retrieve a list of invoices stored in the system.
        /// GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="paymentStatus">Payment Status (optional)</param>
        /// <returns>Task of BillingInvoiceListing</returns>
        
        System.Threading.Tasks.Task<BillingInvoiceListing> GetBillingContractsInvoicesAsync (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null);

        /// <summary>
        /// Get invoices
        /// </summary>
        /// <remarks>
        /// Retrieve a list of invoices stored in the system.
        /// GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="paymentStatus">Payment Status (optional)</param>
        /// <returns>Task of ApiResponse (BillingInvoiceListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BillingInvoiceListing>> GetBillingContractsInvoicesAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null);

        /// <summary>
        /// Get a report of the billable license usages
        /// </summary>
        /// <remarks>
        /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <returns>Task of BillingUsageReport</returns>
        
        System.Threading.Tasks.Task<BillingUsageReport> GetBillingReportsBillableusageAsync (DateTime? startDate, DateTime? endDate);

        /// <summary>
        /// Get a report of the billable license usages
        /// </summary>
        /// <remarks>
        /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <returns>Task of ApiResponse (BillingUsageReport)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BillingUsageReport>> GetBillingReportsBillableusageAsyncWithHttpInfo (DateTime? startDate, DateTime? endDate);

        /// <summary>
        /// Get the billing overview for an organization that is managed by a partner.
        /// </summary>
        /// <remarks>
        /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
        /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
        /// <returns>Task of TrusteeBillingOverview</returns>
        
        System.Threading.Tasks.Task<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdAsync (string trustorOrgId, int? billingPeriodIndex = null);

        /// <summary>
        /// Get the billing overview for an organization that is managed by a partner.
        /// </summary>
        /// <remarks>
        /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
        /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (TrusteeBillingOverview)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TrusteeBillingOverview>> GetBillingTrusteebillingoverviewTrustorOrgIdAsyncWithHttpInfo (string trustorOrgId, int? billingPeriodIndex = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BillingApi : IBillingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillingApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BillingApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PureCloudPlatform.Client.V2.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
             return this.Configuration.ApiClient.ClientOptions.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PureCloudPlatform.Client.V2.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }


        /// <summary>
        /// Get billing contract 
        /// Retrieve a single contract from the system.
        /// GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <returns>BillingContract</returns>
        
        public BillingContract GetBillingContract (string contractId)
        {
             ApiResponse<BillingContract> localVarResponse = GetBillingContractWithHttpInfo(contractId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get billing contract 
        /// Retrieve a single contract from the system.
        /// GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <returns>ApiResponse of BillingContract</returns>
        
        public ApiResponse< BillingContract > GetBillingContractWithHttpInfo (string contractId)
        { 
            // verify the required parameter 'contractId' is set
            if (contractId == null)
                throw new ApiException(400, "Missing required parameter 'contractId' when calling BillingApi->GetBillingContract");

            var localVarPath = "/api/v2/billing/contracts/{contractId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contractId != null) localVarPathParams.Add("contractId", this.Configuration.ApiClient.ParameterToString(contractId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContract: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContract: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingContract>(localVarStatusCode,
                localVarHeaders,
                (BillingContract) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingContract)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get billing contract 
        /// Retrieve a single contract from the system.
        /// GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <returns>Task of BillingContract</returns>
        
        public async System.Threading.Tasks.Task<BillingContract> GetBillingContractAsync (string contractId)
        {
             ApiResponse<BillingContract> localVarResponse = await GetBillingContractAsyncWithHttpInfo(contractId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get billing contract 
        /// Retrieve a single contract from the system.
        /// GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <returns>Task of ApiResponse (BillingContract)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BillingContract>> GetBillingContractAsyncWithHttpInfo (string contractId)
        { 
            // verify the required parameter 'contractId' is set
            if (contractId == null)
                throw new ApiException(400, "Missing required parameter 'contractId' when calling BillingApi->GetBillingContract");
            

            var localVarPath = "/api/v2/billing/contracts/{contractId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contractId != null) localVarPathParams.Add("contractId", this.Configuration.ApiClient.ParameterToString(contractId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContract: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContract: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingContract>(localVarStatusCode,
                localVarHeaders,
                (BillingContract) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingContract)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get contract billing period 
        /// Fetch the billing information for a given Organization by billing period.
        /// GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <param name="billingPeriodId">The Billing Period Id for the Org.</param>
        /// <returns>BillingContractPeriodDetail</returns>
        
        public BillingContractPeriodDetail GetBillingContractBillingperiod (string contractId, string billingPeriodId)
        {
             ApiResponse<BillingContractPeriodDetail> localVarResponse = GetBillingContractBillingperiodWithHttpInfo(contractId, billingPeriodId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get contract billing period 
        /// Fetch the billing information for a given Organization by billing period.
        /// GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <param name="billingPeriodId">The Billing Period Id for the Org.</param>
        /// <returns>ApiResponse of BillingContractPeriodDetail</returns>
        
        public ApiResponse< BillingContractPeriodDetail > GetBillingContractBillingperiodWithHttpInfo (string contractId, string billingPeriodId)
        { 
            // verify the required parameter 'contractId' is set
            if (contractId == null)
                throw new ApiException(400, "Missing required parameter 'contractId' when calling BillingApi->GetBillingContractBillingperiod");
            // verify the required parameter 'billingPeriodId' is set
            if (billingPeriodId == null)
                throw new ApiException(400, "Missing required parameter 'billingPeriodId' when calling BillingApi->GetBillingContractBillingperiod");

            var localVarPath = "/api/v2/billing/contracts/{contractId}/billingperiods/{billingPeriodId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contractId != null) localVarPathParams.Add("contractId", this.Configuration.ApiClient.ParameterToString(contractId));
            if (billingPeriodId != null) localVarPathParams.Add("billingPeriodId", this.Configuration.ApiClient.ParameterToString(billingPeriodId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractBillingperiod: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractBillingperiod: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingContractPeriodDetail>(localVarStatusCode,
                localVarHeaders,
                (BillingContractPeriodDetail) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingContractPeriodDetail)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get contract billing period 
        /// Fetch the billing information for a given Organization by billing period.
        /// GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <param name="billingPeriodId">The Billing Period Id for the Org.</param>
        /// <returns>Task of BillingContractPeriodDetail</returns>
        
        public async System.Threading.Tasks.Task<BillingContractPeriodDetail> GetBillingContractBillingperiodAsync (string contractId, string billingPeriodId)
        {
             ApiResponse<BillingContractPeriodDetail> localVarResponse = await GetBillingContractBillingperiodAsyncWithHttpInfo(contractId, billingPeriodId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get contract billing period 
        /// Fetch the billing information for a given Organization by billing period.
        /// GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractId">The contract number.</param>
        /// <param name="billingPeriodId">The Billing Period Id for the Org.</param>
        /// <returns>Task of ApiResponse (BillingContractPeriodDetail)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BillingContractPeriodDetail>> GetBillingContractBillingperiodAsyncWithHttpInfo (string contractId, string billingPeriodId)
        { 
            // verify the required parameter 'contractId' is set
            if (contractId == null)
                throw new ApiException(400, "Missing required parameter 'contractId' when calling BillingApi->GetBillingContractBillingperiod");
            
            // verify the required parameter 'billingPeriodId' is set
            if (billingPeriodId == null)
                throw new ApiException(400, "Missing required parameter 'billingPeriodId' when calling BillingApi->GetBillingContractBillingperiod");
            

            var localVarPath = "/api/v2/billing/contracts/{contractId}/billingperiods/{billingPeriodId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contractId != null) localVarPathParams.Add("contractId", this.Configuration.ApiClient.ParameterToString(contractId));
            if (billingPeriodId != null) localVarPathParams.Add("billingPeriodId", this.Configuration.ApiClient.ParameterToString(billingPeriodId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractBillingperiod: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractBillingperiod: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingContractPeriodDetail>(localVarStatusCode,
                localVarHeaders,
                (BillingContractPeriodDetail) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingContractPeriodDetail)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get billing contracts 
        /// Retrieve a list of contracts stored in the system.
        /// GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="status">Filter by the status of contracts (optional)</param>
        /// <param name="externalNumber">Filter by the unique external number. (optional)</param>
        /// <returns>BillingContractListing</returns>
        
        public BillingContractListing GetBillingContracts (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null)
        {
             ApiResponse<BillingContractListing> localVarResponse = GetBillingContractsWithHttpInfo(before, after, pageSize, dateStart, dateEnd, status, externalNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get billing contracts 
        /// Retrieve a list of contracts stored in the system.
        /// GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="status">Filter by the status of contracts (optional)</param>
        /// <param name="externalNumber">Filter by the unique external number. (optional)</param>
        /// <returns>ApiResponse of BillingContractListing</returns>
        
        public ApiResponse< BillingContractListing > GetBillingContractsWithHttpInfo (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null)
        { 

            var localVarPath = "/api/v2/billing/contracts";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (externalNumber != null) localVarQueryParams.Add(new Tuple<string, string>("externalNumber", this.Configuration.ApiClient.ParameterToString(externalNumber)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContracts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContracts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingContractListing>(localVarStatusCode,
                localVarHeaders,
                (BillingContractListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingContractListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get billing contracts 
        /// Retrieve a list of contracts stored in the system.
        /// GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="status">Filter by the status of contracts (optional)</param>
        /// <param name="externalNumber">Filter by the unique external number. (optional)</param>
        /// <returns>Task of BillingContractListing</returns>
        
        public async System.Threading.Tasks.Task<BillingContractListing> GetBillingContractsAsync (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null)
        {
             ApiResponse<BillingContractListing> localVarResponse = await GetBillingContractsAsyncWithHttpInfo(before, after, pageSize, dateStart, dateEnd, status, externalNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get billing contracts 
        /// Retrieve a list of contracts stored in the system.
        /// GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="status">Filter by the status of contracts (optional)</param>
        /// <param name="externalNumber">Filter by the unique external number. (optional)</param>
        /// <returns>Task of ApiResponse (BillingContractListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BillingContractListing>> GetBillingContractsAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null)
        { 

            var localVarPath = "/api/v2/billing/contracts";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (externalNumber != null) localVarQueryParams.Add(new Tuple<string, string>("externalNumber", this.Configuration.ApiClient.ParameterToString(externalNumber)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContracts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContracts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingContractListing>(localVarStatusCode,
                localVarHeaders,
                (BillingContractListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingContractListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get invoice document 
        /// Fetch the document for a specific invoice.
        /// GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <returns>UrlResponse</returns>
        
        public UrlResponse GetBillingContractsInvoiceDocument (string invoiceId)
        {
             ApiResponse<UrlResponse> localVarResponse = GetBillingContractsInvoiceDocumentWithHttpInfo(invoiceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get invoice document 
        /// Fetch the document for a specific invoice.
        /// GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        
        public ApiResponse< UrlResponse > GetBillingContractsInvoiceDocumentWithHttpInfo (string invoiceId)
        { 
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceId' when calling BillingApi->GetBillingContractsInvoiceDocument");

            var localVarPath = "/api/v2/billing/contracts/invoices/{invoiceId}/document";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (invoiceId != null) localVarPathParams.Add("invoiceId", this.Configuration.ApiClient.ParameterToString(invoiceId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoiceDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoiceDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get invoice document 
        /// Fetch the document for a specific invoice.
        /// GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <returns>Task of UrlResponse</returns>
        
        public async System.Threading.Tasks.Task<UrlResponse> GetBillingContractsInvoiceDocumentAsync (string invoiceId)
        {
             ApiResponse<UrlResponse> localVarResponse = await GetBillingContractsInvoiceDocumentAsyncWithHttpInfo(invoiceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get invoice document 
        /// Fetch the document for a specific invoice.
        /// GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UrlResponse>> GetBillingContractsInvoiceDocumentAsyncWithHttpInfo (string invoiceId)
        { 
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceId' when calling BillingApi->GetBillingContractsInvoiceDocument");
            

            var localVarPath = "/api/v2/billing/contracts/invoices/{invoiceId}/document";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (invoiceId != null) localVarPathParams.Add("invoiceId", this.Configuration.ApiClient.ParameterToString(invoiceId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoiceDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoiceDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get invoice lines 
        /// Fetch a list of all bills for the specified account.
        /// GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>BillingInvoiceItemListing</returns>
        
        public BillingInvoiceItemListing GetBillingContractsInvoiceLines (string invoiceId, string before = null, string after = null, string pageSize = null)
        {
             ApiResponse<BillingInvoiceItemListing> localVarResponse = GetBillingContractsInvoiceLinesWithHttpInfo(invoiceId, before, after, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get invoice lines 
        /// Fetch a list of all bills for the specified account.
        /// GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>ApiResponse of BillingInvoiceItemListing</returns>
        
        public ApiResponse< BillingInvoiceItemListing > GetBillingContractsInvoiceLinesWithHttpInfo (string invoiceId, string before = null, string after = null, string pageSize = null)
        { 
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceId' when calling BillingApi->GetBillingContractsInvoiceLines");

            var localVarPath = "/api/v2/billing/contracts/invoices/{invoiceId}/lines";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (invoiceId != null) localVarPathParams.Add("invoiceId", this.Configuration.ApiClient.ParameterToString(invoiceId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoiceLines: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoiceLines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingInvoiceItemListing>(localVarStatusCode,
                localVarHeaders,
                (BillingInvoiceItemListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingInvoiceItemListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get invoice lines 
        /// Fetch a list of all bills for the specified account.
        /// GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of BillingInvoiceItemListing</returns>
        
        public async System.Threading.Tasks.Task<BillingInvoiceItemListing> GetBillingContractsInvoiceLinesAsync (string invoiceId, string before = null, string after = null, string pageSize = null)
        {
             ApiResponse<BillingInvoiceItemListing> localVarResponse = await GetBillingContractsInvoiceLinesAsyncWithHttpInfo(invoiceId, before, after, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get invoice lines 
        /// Fetch a list of all bills for the specified account.
        /// GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceId">invoiceId</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of ApiResponse (BillingInvoiceItemListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BillingInvoiceItemListing>> GetBillingContractsInvoiceLinesAsyncWithHttpInfo (string invoiceId, string before = null, string after = null, string pageSize = null)
        { 
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceId' when calling BillingApi->GetBillingContractsInvoiceLines");
            

            var localVarPath = "/api/v2/billing/contracts/invoices/{invoiceId}/lines";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (invoiceId != null) localVarPathParams.Add("invoiceId", this.Configuration.ApiClient.ParameterToString(invoiceId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoiceLines: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoiceLines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingInvoiceItemListing>(localVarStatusCode,
                localVarHeaders,
                (BillingInvoiceItemListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingInvoiceItemListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get invoices 
        /// Retrieve a list of invoices stored in the system.
        /// GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="paymentStatus">Payment Status (optional)</param>
        /// <returns>BillingInvoiceListing</returns>
        
        public BillingInvoiceListing GetBillingContractsInvoices (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null)
        {
             ApiResponse<BillingInvoiceListing> localVarResponse = GetBillingContractsInvoicesWithHttpInfo(before, after, pageSize, dateStart, dateEnd, paymentStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get invoices 
        /// Retrieve a list of invoices stored in the system.
        /// GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="paymentStatus">Payment Status (optional)</param>
        /// <returns>ApiResponse of BillingInvoiceListing</returns>
        
        public ApiResponse< BillingInvoiceListing > GetBillingContractsInvoicesWithHttpInfo (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null)
        { 

            var localVarPath = "/api/v2/billing/contracts/invoices";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));
            if (paymentStatus != null) localVarQueryParams.Add(new Tuple<string, string>("paymentStatus", this.Configuration.ApiClient.ParameterToString(paymentStatus)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoices: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingInvoiceListing>(localVarStatusCode,
                localVarHeaders,
                (BillingInvoiceListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingInvoiceListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get invoices 
        /// Retrieve a list of invoices stored in the system.
        /// GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="paymentStatus">Payment Status (optional)</param>
        /// <returns>Task of BillingInvoiceListing</returns>
        
        public async System.Threading.Tasks.Task<BillingInvoiceListing> GetBillingContractsInvoicesAsync (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null)
        {
             ApiResponse<BillingInvoiceListing> localVarResponse = await GetBillingContractsInvoicesAsyncWithHttpInfo(before, after, pageSize, dateStart, dateEnd, paymentStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get invoices 
        /// Retrieve a list of invoices stored in the system.
        /// GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="dateStart">Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="dateEnd">End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="paymentStatus">Payment Status (optional)</param>
        /// <returns>Task of ApiResponse (BillingInvoiceListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BillingInvoiceListing>> GetBillingContractsInvoicesAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null)
        { 

            var localVarPath = "/api/v2/billing/contracts/invoices";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));
            if (paymentStatus != null) localVarQueryParams.Add(new Tuple<string, string>("paymentStatus", this.Configuration.ApiClient.ParameterToString(paymentStatus)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoices: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingContractsInvoices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingInvoiceListing>(localVarStatusCode,
                localVarHeaders,
                (BillingInvoiceListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingInvoiceListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a report of the billable license usages 
        /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <returns>BillingUsageReport</returns>
        
        public BillingUsageReport GetBillingReportsBillableusage (DateTime? startDate, DateTime? endDate)
        {
             ApiResponse<BillingUsageReport> localVarResponse = GetBillingReportsBillableusageWithHttpInfo(startDate, endDate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a report of the billable license usages 
        /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <returns>ApiResponse of BillingUsageReport</returns>
        
        public ApiResponse< BillingUsageReport > GetBillingReportsBillableusageWithHttpInfo (DateTime? startDate, DateTime? endDate)
        { 
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling BillingApi->GetBillingReportsBillableusage");
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling BillingApi->GetBillingReportsBillableusage");

            var localVarPath = "/api/v2/billing/reports/billableusage";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startDate != null) localVarQueryParams.Add(new Tuple<string, string>("startDate", this.Configuration.ApiClient.ParameterToString(startDate)));
            if (endDate != null) localVarQueryParams.Add(new Tuple<string, string>("endDate", this.Configuration.ApiClient.ParameterToString(endDate)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingUsageReport>(localVarStatusCode,
                localVarHeaders,
                (BillingUsageReport) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingUsageReport)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a report of the billable license usages 
        /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <returns>Task of BillingUsageReport</returns>
        
        public async System.Threading.Tasks.Task<BillingUsageReport> GetBillingReportsBillableusageAsync (DateTime? startDate, DateTime? endDate)
        {
             ApiResponse<BillingUsageReport> localVarResponse = await GetBillingReportsBillableusageAsyncWithHttpInfo(startDate, endDate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a report of the billable license usages 
        /// Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <returns>Task of ApiResponse (BillingUsageReport)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BillingUsageReport>> GetBillingReportsBillableusageAsyncWithHttpInfo (DateTime? startDate, DateTime? endDate)
        { 
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling BillingApi->GetBillingReportsBillableusage");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling BillingApi->GetBillingReportsBillableusage");
            

            var localVarPath = "/api/v2/billing/reports/billableusage";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startDate != null) localVarQueryParams.Add(new Tuple<string, string>("startDate", this.Configuration.ApiClient.ParameterToString(startDate)));
            if (endDate != null) localVarQueryParams.Add(new Tuple<string, string>("endDate", this.Configuration.ApiClient.ParameterToString(endDate)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingUsageReport>(localVarStatusCode,
                localVarHeaders,
                (BillingUsageReport) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingUsageReport)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the billing overview for an organization that is managed by a partner. 
        /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
        /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
        /// <returns>TrusteeBillingOverview</returns>
        
        public TrusteeBillingOverview GetBillingTrusteebillingoverviewTrustorOrgId (string trustorOrgId, int? billingPeriodIndex = null)
        {
             ApiResponse<TrusteeBillingOverview> localVarResponse = GetBillingTrusteebillingoverviewTrustorOrgIdWithHttpInfo(trustorOrgId, billingPeriodIndex);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the billing overview for an organization that is managed by a partner. 
        /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
        /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
        /// <returns>ApiResponse of TrusteeBillingOverview</returns>
        
        public ApiResponse< TrusteeBillingOverview > GetBillingTrusteebillingoverviewTrustorOrgIdWithHttpInfo (string trustorOrgId, int? billingPeriodIndex = null)
        { 
            // verify the required parameter 'trustorOrgId' is set
            if (trustorOrgId == null)
                throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling BillingApi->GetBillingTrusteebillingoverviewTrustorOrgId");

            var localVarPath = "/api/v2/billing/trusteebillingoverview/{trustorOrgId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (trustorOrgId != null) localVarPathParams.Add("trustorOrgId", this.Configuration.ApiClient.ParameterToString(trustorOrgId));

            // Query params
            if (billingPeriodIndex != null) localVarQueryParams.Add(new Tuple<string, string>("billingPeriodIndex", this.Configuration.ApiClient.ParameterToString(billingPeriodIndex)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingTrusteebillingoverviewTrustorOrgId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingTrusteebillingoverviewTrustorOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrusteeBillingOverview>(localVarStatusCode,
                localVarHeaders,
                (TrusteeBillingOverview) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrusteeBillingOverview)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the billing overview for an organization that is managed by a partner. 
        /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
        /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
        /// <returns>Task of TrusteeBillingOverview</returns>
        
        public async System.Threading.Tasks.Task<TrusteeBillingOverview> GetBillingTrusteebillingoverviewTrustorOrgIdAsync (string trustorOrgId, int? billingPeriodIndex = null)
        {
             ApiResponse<TrusteeBillingOverview> localVarResponse = await GetBillingTrusteebillingoverviewTrustorOrgIdAsyncWithHttpInfo(trustorOrgId, billingPeriodIndex);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the billing overview for an organization that is managed by a partner. 
        /// Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trustorOrgId">The organization ID of the trustor (customer) organization.</param>
        /// <param name="billingPeriodIndex">0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (TrusteeBillingOverview)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TrusteeBillingOverview>> GetBillingTrusteebillingoverviewTrustorOrgIdAsyncWithHttpInfo (string trustorOrgId, int? billingPeriodIndex = null)
        { 
            // verify the required parameter 'trustorOrgId' is set
            if (trustorOrgId == null)
                throw new ApiException(400, "Missing required parameter 'trustorOrgId' when calling BillingApi->GetBillingTrusteebillingoverviewTrustorOrgId");
            

            var localVarPath = "/api/v2/billing/trusteebillingoverview/{trustorOrgId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (trustorOrgId != null) localVarPathParams.Add("trustorOrgId", this.Configuration.ApiClient.ParameterToString(trustorOrgId));

            // Query params
            if (billingPeriodIndex != null) localVarQueryParams.Add(new Tuple<string, string>("billingPeriodIndex", this.Configuration.ApiClient.ParameterToString(billingPeriodIndex)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingTrusteebillingoverviewTrustorOrgId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingTrusteebillingoverviewTrustorOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrusteeBillingOverview>(localVarStatusCode,
                localVarHeaders,
                (TrusteeBillingOverview) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrusteeBillingOverview)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
