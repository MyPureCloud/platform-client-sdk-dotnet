using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKnowledgeApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>KnowledgeBase</returns>
        KnowledgeBase DeleteKnowledgeKnowledgebase (string knowledgeBaseId);

        /// <summary>
        /// Delete knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>ApiResponse of KnowledgeBase</returns>
        ApiResponse<KnowledgeBase> DeleteKnowledgeKnowledgebaseWithHttpInfo (string knowledgeBaseId);
        
        /// <summary>
        /// Delete category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeCategory</returns>
        KnowledgeCategory DeleteKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Delete category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeCategory</returns>
        ApiResponse<KnowledgeCategory> DeleteKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Delete document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeDocument</returns>
        KnowledgeDocument DeleteKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Delete document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeDocument</returns>
        ApiResponse<KnowledgeDocument> DeleteKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Get knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>KnowledgeBase</returns>
        KnowledgeBase GetKnowledgeKnowledgebase (string knowledgeBaseId);

        /// <summary>
        /// Get knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>ApiResponse of KnowledgeBase</returns>
        ApiResponse<KnowledgeBase> GetKnowledgeKnowledgebaseWithHttpInfo (string knowledgeBaseId);
        
        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Filter to return the categories that starts with the given category name. (optional)</param>
        /// <returns>CategoryListing</returns>
        CategoryListing GetKnowledgeKnowledgebaseLanguageCategories (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null);

        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Filter to return the categories that starts with the given category name. (optional)</param>
        /// <returns>ApiResponse of CategoryListing</returns>
        ApiResponse<CategoryListing> GetKnowledgeKnowledgebaseLanguageCategoriesWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null);
        
        /// <summary>
        /// Get category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeExtendedCategory</returns>
        KnowledgeExtendedCategory GetKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Get category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeExtendedCategory</returns>
        ApiResponse<KnowledgeExtendedCategory> GetKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Get document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeDocument</returns>
        KnowledgeDocument GetKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Get document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeDocument</returns>
        ApiResponse<KnowledgeDocument> GetKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Get documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="categories">Filter by categories ids, comma separated values expected. (optional)</param>
        /// <param name="title">Filter by document title. (optional)</param>
        /// <returns>DocumentListing</returns>
        DocumentListing GetKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null);

        /// <summary>
        /// Get documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="categories">Filter by categories ids, comma separated values expected. (optional)</param>
        /// <param name="title">Filter by document title. (optional)</param>
        /// <returns>ApiResponse of DocumentListing</returns>
        ApiResponse<DocumentListing> GetKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null);
        
        /// <summary>
        /// Get training detail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>KnowledgeTraining</returns>
        KnowledgeTraining GetKnowledgeKnowledgebaseLanguageTraining (string knowledgeBaseId, string languageCode, string trainingId);

        /// <summary>
        /// Get training detail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>ApiResponse of KnowledgeTraining</returns>
        ApiResponse<KnowledgeTraining> GetKnowledgeKnowledgebaseLanguageTrainingWithHttpInfo (string knowledgeBaseId, string languageCode, string trainingId);
        
        /// <summary>
        /// Get all trainings information for a knowledgebase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="knowledgeDocumentsState">Return the training with the specified state of the trained documents. (optional)</param>
        /// <returns>TrainingListing</returns>
        TrainingListing GetKnowledgeKnowledgebaseLanguageTrainings (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null);

        /// <summary>
        /// Get all trainings information for a knowledgebase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="knowledgeDocumentsState">Return the training with the specified state of the trained documents. (optional)</param>
        /// <returns>ApiResponse of TrainingListing</returns>
        ApiResponse<TrainingListing> GetKnowledgeKnowledgebaseLanguageTrainingsWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null);
        
        /// <summary>
        /// Get knowledge bases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Name of the KnowledgeBase to filter. (optional)</param>
        /// <returns>KnowledgeBaseListing</returns>
        KnowledgeBaseListing GetKnowledgeKnowledgebases (string before = null, string after = null, string limit = null, string pageSize = null, string name = null);

        /// <summary>
        /// Get knowledge bases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Name of the KnowledgeBase to filter. (optional)</param>
        /// <returns>ApiResponse of KnowledgeBaseListing</returns>
        ApiResponse<KnowledgeBaseListing> GetKnowledgeKnowledgebasesWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null);
        
        /// <summary>
        /// Update knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeBase</returns>
        KnowledgeBase PatchKnowledgeKnowledgebase (string knowledgeBaseId, KnowledgeBase body);

        /// <summary>
        /// Update knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeBase</returns>
        ApiResponse<KnowledgeBase> PatchKnowledgeKnowledgebaseWithHttpInfo (string knowledgeBaseId, KnowledgeBase body);
        
        /// <summary>
        /// Update category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeExtendedCategory</returns>
        KnowledgeExtendedCategory PatchKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body);

        /// <summary>
        /// Update category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeExtendedCategory</returns>
        ApiResponse<KnowledgeExtendedCategory> PatchKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body);
        
        /// <summary>
        /// Update document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeDocument</returns>
        KnowledgeDocument PatchKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body);

        /// <summary>
        /// Update document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeDocument</returns>
        ApiResponse<KnowledgeDocument> PatchKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body);
        
        /// <summary>
        /// Update documents collection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>DocumentListing</returns>
        DocumentListing PatchKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body);

        /// <summary>
        /// Update documents collection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DocumentListing</returns>
        ApiResponse<DocumentListing> PatchKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body);
        
        /// <summary>
        /// Create new category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeExtendedCategory</returns>
        KnowledgeExtendedCategory PostKnowledgeKnowledgebaseLanguageCategories (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body);

        /// <summary>
        /// Create new category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeExtendedCategory</returns>
        ApiResponse<KnowledgeExtendedCategory> PostKnowledgeKnowledgebaseLanguageCategoriesWithHttpInfo (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body);
        
        /// <summary>
        /// Create document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeDocument</returns>
        KnowledgeDocument PostKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body);

        /// <summary>
        /// Create document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeDocument</returns>
        ApiResponse<KnowledgeDocument> PostKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body);
        
        /// <summary>
        /// Promote trained documents from draft state to active.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>KnowledgeTraining</returns>
        KnowledgeTraining PostKnowledgeKnowledgebaseLanguageTrainingPromote (string knowledgeBaseId, string languageCode, string trainingId);

        /// <summary>
        /// Promote trained documents from draft state to active.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>ApiResponse of KnowledgeTraining</returns>
        ApiResponse<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingPromoteWithHttpInfo (string knowledgeBaseId, string languageCode, string trainingId);
        
        /// <summary>
        /// Trigger training
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeTraining</returns>
        KnowledgeTraining PostKnowledgeKnowledgebaseLanguageTrainings (string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Trigger training
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeTraining</returns>
        ApiResponse<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingsWithHttpInfo (string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Search Documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>KnowledgeSearchResponse</returns>
        KnowledgeSearchResponse PostKnowledgeKnowledgebaseSearch (string knowledgeBaseId, KnowledgeSearchRequest body = null);

        /// <summary>
        /// Search Documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of KnowledgeSearchResponse</returns>
        ApiResponse<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchWithHttpInfo (string knowledgeBaseId, KnowledgeSearchRequest body = null);
        
        /// <summary>
        /// Create new knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>KnowledgeBase</returns>
        KnowledgeBase PostKnowledgeKnowledgebases (KnowledgeBase body);

        /// <summary>
        /// Create new knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeBase</returns>
        ApiResponse<KnowledgeBase> PostKnowledgeKnowledgebasesWithHttpInfo (KnowledgeBase body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>Task of KnowledgeBase</returns>
        System.Threading.Tasks.Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync (string knowledgeBaseId);

        /// <summary>
        /// Delete knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>Task of ApiResponse (KnowledgeBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeBase>> DeleteKnowledgeKnowledgebaseAsyncWithHttpInfo (string knowledgeBaseId);
        
        /// <summary>
        /// Delete category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeCategory</returns>
        System.Threading.Tasks.Task<KnowledgeCategory> DeleteKnowledgeKnowledgebaseLanguageCategoryAsync (string categoryId, string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Delete category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeCategory)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeCategory>> DeleteKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Delete document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeDocument</returns>
        System.Threading.Tasks.Task<KnowledgeDocument> DeleteKnowledgeKnowledgebaseLanguageDocumentAsync (string documentId, string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Delete document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeDocument>> DeleteKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Get knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>Task of KnowledgeBase</returns>
        System.Threading.Tasks.Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync (string knowledgeBaseId);

        /// <summary>
        /// Get knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>Task of ApiResponse (KnowledgeBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeBase>> GetKnowledgeKnowledgebaseAsyncWithHttpInfo (string knowledgeBaseId);
        
        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Filter to return the categories that starts with the given category name. (optional)</param>
        /// <returns>Task of CategoryListing</returns>
        System.Threading.Tasks.Task<CategoryListing> GetKnowledgeKnowledgebaseLanguageCategoriesAsync (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null);

        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Filter to return the categories that starts with the given category name. (optional)</param>
        /// <returns>Task of ApiResponse (CategoryListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CategoryListing>> GetKnowledgeKnowledgebaseLanguageCategoriesAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null);
        
        /// <summary>
        /// Get category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeExtendedCategory</returns>
        System.Threading.Tasks.Task<KnowledgeExtendedCategory> GetKnowledgeKnowledgebaseLanguageCategoryAsync (string categoryId, string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Get category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeExtendedCategory)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeExtendedCategory>> GetKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Get document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeDocument</returns>
        System.Threading.Tasks.Task<KnowledgeDocument> GetKnowledgeKnowledgebaseLanguageDocumentAsync (string documentId, string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Get document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeDocument>> GetKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Get documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="categories">Filter by categories ids, comma separated values expected. (optional)</param>
        /// <param name="title">Filter by document title. (optional)</param>
        /// <returns>Task of DocumentListing</returns>
        System.Threading.Tasks.Task<DocumentListing> GetKnowledgeKnowledgebaseLanguageDocumentsAsync (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null);

        /// <summary>
        /// Get documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="categories">Filter by categories ids, comma separated values expected. (optional)</param>
        /// <param name="title">Filter by document title. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentListing>> GetKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null);
        
        /// <summary>
        /// Get training detail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>Task of KnowledgeTraining</returns>
        System.Threading.Tasks.Task<KnowledgeTraining> GetKnowledgeKnowledgebaseLanguageTrainingAsync (string knowledgeBaseId, string languageCode, string trainingId);

        /// <summary>
        /// Get training detail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>Task of ApiResponse (KnowledgeTraining)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeTraining>> GetKnowledgeKnowledgebaseLanguageTrainingAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string trainingId);
        
        /// <summary>
        /// Get all trainings information for a knowledgebase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="knowledgeDocumentsState">Return the training with the specified state of the trained documents. (optional)</param>
        /// <returns>Task of TrainingListing</returns>
        System.Threading.Tasks.Task<TrainingListing> GetKnowledgeKnowledgebaseLanguageTrainingsAsync (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null);

        /// <summary>
        /// Get all trainings information for a knowledgebase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="knowledgeDocumentsState">Return the training with the specified state of the trained documents. (optional)</param>
        /// <returns>Task of ApiResponse (TrainingListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrainingListing>> GetKnowledgeKnowledgebaseLanguageTrainingsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null);
        
        /// <summary>
        /// Get knowledge bases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Name of the KnowledgeBase to filter. (optional)</param>
        /// <returns>Task of KnowledgeBaseListing</returns>
        System.Threading.Tasks.Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync (string before = null, string after = null, string limit = null, string pageSize = null, string name = null);

        /// <summary>
        /// Get knowledge bases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Name of the KnowledgeBase to filter. (optional)</param>
        /// <returns>Task of ApiResponse (KnowledgeBaseListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeBaseListing>> GetKnowledgeKnowledgebasesAsyncWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null);
        
        /// <summary>
        /// Update knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeBase</returns>
        System.Threading.Tasks.Task<KnowledgeBase> PatchKnowledgeKnowledgebaseAsync (string knowledgeBaseId, KnowledgeBase body);

        /// <summary>
        /// Update knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeBase>> PatchKnowledgeKnowledgebaseAsyncWithHttpInfo (string knowledgeBaseId, KnowledgeBase body);
        
        /// <summary>
        /// Update category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeExtendedCategory</returns>
        System.Threading.Tasks.Task<KnowledgeExtendedCategory> PatchKnowledgeKnowledgebaseLanguageCategoryAsync (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body);

        /// <summary>
        /// Update category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeExtendedCategory)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeExtendedCategory>> PatchKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body);
        
        /// <summary>
        /// Update document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeDocument</returns>
        System.Threading.Tasks.Task<KnowledgeDocument> PatchKnowledgeKnowledgebaseLanguageDocumentAsync (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body);

        /// <summary>
        /// Update document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeDocument>> PatchKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body);
        
        /// <summary>
        /// Update documents collection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of DocumentListing</returns>
        System.Threading.Tasks.Task<DocumentListing> PatchKnowledgeKnowledgebaseLanguageDocumentsAsync (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body);

        /// <summary>
        /// Update documents collection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DocumentListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentListing>> PatchKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body);
        
        /// <summary>
        /// Create new category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeExtendedCategory</returns>
        System.Threading.Tasks.Task<KnowledgeExtendedCategory> PostKnowledgeKnowledgebaseLanguageCategoriesAsync (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body);

        /// <summary>
        /// Create new category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeExtendedCategory)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeExtendedCategory>> PostKnowledgeKnowledgebaseLanguageCategoriesAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body);
        
        /// <summary>
        /// Create document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeDocument</returns>
        System.Threading.Tasks.Task<KnowledgeDocument> PostKnowledgeKnowledgebaseLanguageDocumentsAsync (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body);

        /// <summary>
        /// Create document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeDocument>> PostKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body);
        
        /// <summary>
        /// Promote trained documents from draft state to active.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>Task of KnowledgeTraining</returns>
        System.Threading.Tasks.Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsync (string knowledgeBaseId, string languageCode, string trainingId);

        /// <summary>
        /// Promote trained documents from draft state to active.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>Task of ApiResponse (KnowledgeTraining)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeTraining>> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string trainingId);
        
        /// <summary>
        /// Trigger training
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeTraining</returns>
        System.Threading.Tasks.Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingsAsync (string knowledgeBaseId, string languageCode);

        /// <summary>
        /// Trigger training
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeTraining)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeTraining>> PostKnowledgeKnowledgebaseLanguageTrainingsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode);
        
        /// <summary>
        /// Search Documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of KnowledgeSearchResponse</returns>
        System.Threading.Tasks.Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync (string knowledgeBaseId, KnowledgeSearchRequest body = null);

        /// <summary>
        /// Search Documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (KnowledgeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeSearchResponse>> PostKnowledgeKnowledgebaseSearchAsyncWithHttpInfo (string knowledgeBaseId, KnowledgeSearchRequest body = null);
        
        /// <summary>
        /// Create new knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeBase</returns>
        System.Threading.Tasks.Task<KnowledgeBase> PostKnowledgeKnowledgebasesAsync (KnowledgeBase body);

        /// <summary>
        /// Create new knowledge base
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<KnowledgeBase>> PostKnowledgeKnowledgebasesAsyncWithHttpInfo (KnowledgeBase body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KnowledgeApi : IKnowledgeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KnowledgeApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KnowledgeApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
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
        /// Delete knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>KnowledgeBase</returns>
        public KnowledgeBase DeleteKnowledgeKnowledgebase (string knowledgeBaseId)
        {
             ApiResponse<KnowledgeBase> localVarResponse = DeleteKnowledgeKnowledgebaseWithHttpInfo(knowledgeBaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>ApiResponse of KnowledgeBase</returns>
        public ApiResponse< KnowledgeBase > DeleteKnowledgeKnowledgebaseWithHttpInfo (string knowledgeBaseId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebase");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBase>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>Task of KnowledgeBase</returns>
        public async System.Threading.Tasks.Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync (string knowledgeBaseId)
        {
             ApiResponse<KnowledgeBase> localVarResponse = await DeleteKnowledgeKnowledgebaseAsyncWithHttpInfo(knowledgeBaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>Task of ApiResponse (KnowledgeBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeBase>> DeleteKnowledgeKnowledgebaseAsyncWithHttpInfo (string knowledgeBaseId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebase");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBase>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeCategory</returns>
        public KnowledgeCategory DeleteKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeCategory> localVarResponse = DeleteKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo(categoryId, knowledgeBaseId, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeCategory</returns>
        public ApiResponse< KnowledgeCategory > DeleteKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageCategory");
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageCategory");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageCategory");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeCategory>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeCategory</returns>
        public async System.Threading.Tasks.Task<KnowledgeCategory> DeleteKnowledgeKnowledgebaseLanguageCategoryAsync (string categoryId, string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeCategory> localVarResponse = await DeleteKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo(categoryId, knowledgeBaseId, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeCategory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeCategory>> DeleteKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageCategory");
            
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageCategory");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageCategory");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeCategory>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeDocument</returns>
        public KnowledgeDocument DeleteKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeDocument> localVarResponse = DeleteKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo(documentId, knowledgeBaseId, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeDocument</returns>
        public ApiResponse< KnowledgeDocument > DeleteKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageDocument");
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageDocument");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageDocument");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (documentId != null) localVarPathParams.Add("documentId", this.Configuration.ApiClient.ParameterToString(documentId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeDocument>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeDocument</returns>
        public async System.Threading.Tasks.Task<KnowledgeDocument> DeleteKnowledgeKnowledgebaseLanguageDocumentAsync (string documentId, string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeDocument> localVarResponse = await DeleteKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo(documentId, knowledgeBaseId, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeDocument>> DeleteKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageDocument");
            
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageDocument");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->DeleteKnowledgeKnowledgebaseLanguageDocument");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (documentId != null) localVarPathParams.Add("documentId", this.Configuration.ApiClient.ParameterToString(documentId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeDocument>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>KnowledgeBase</returns>
        public KnowledgeBase GetKnowledgeKnowledgebase (string knowledgeBaseId)
        {
             ApiResponse<KnowledgeBase> localVarResponse = GetKnowledgeKnowledgebaseWithHttpInfo(knowledgeBaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>ApiResponse of KnowledgeBase</returns>
        public ApiResponse< KnowledgeBase > GetKnowledgeKnowledgebaseWithHttpInfo (string knowledgeBaseId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebase");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBase>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>Task of KnowledgeBase</returns>
        public async System.Threading.Tasks.Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync (string knowledgeBaseId)
        {
             ApiResponse<KnowledgeBase> localVarResponse = await GetKnowledgeKnowledgebaseAsyncWithHttpInfo(knowledgeBaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <returns>Task of ApiResponse (KnowledgeBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeBase>> GetKnowledgeKnowledgebaseAsyncWithHttpInfo (string knowledgeBaseId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebase");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBase>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get categories 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Filter to return the categories that starts with the given category name. (optional)</param>
        /// <returns>CategoryListing</returns>
        public CategoryListing GetKnowledgeKnowledgebaseLanguageCategories (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        {
             ApiResponse<CategoryListing> localVarResponse = GetKnowledgeKnowledgebaseLanguageCategoriesWithHttpInfo(knowledgeBaseId, languageCode, before, after, limit, pageSize, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get categories 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Filter to return the categories that starts with the given category name. (optional)</param>
        /// <returns>ApiResponse of CategoryListing</returns>
        public ApiResponse< CategoryListing > GetKnowledgeKnowledgebaseLanguageCategoriesWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategories");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategories");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CategoryListing>(localVarStatusCode,
                localVarHeaders,
                (CategoryListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get categories 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Filter to return the categories that starts with the given category name. (optional)</param>
        /// <returns>Task of CategoryListing</returns>
        public async System.Threading.Tasks.Task<CategoryListing> GetKnowledgeKnowledgebaseLanguageCategoriesAsync (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        {
             ApiResponse<CategoryListing> localVarResponse = await GetKnowledgeKnowledgebaseLanguageCategoriesAsyncWithHttpInfo(knowledgeBaseId, languageCode, before, after, limit, pageSize, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get categories 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Filter to return the categories that starts with the given category name. (optional)</param>
        /// <returns>Task of ApiResponse (CategoryListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CategoryListing>> GetKnowledgeKnowledgebaseLanguageCategoriesAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategories");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategories");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CategoryListing>(localVarStatusCode,
                localVarHeaders,
                (CategoryListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeExtendedCategory</returns>
        public KnowledgeExtendedCategory GetKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeExtendedCategory> localVarResponse = GetKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo(categoryId, knowledgeBaseId, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeExtendedCategory</returns>
        public ApiResponse< KnowledgeExtendedCategory > GetKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategory");
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategory");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategory");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeExtendedCategory>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeExtendedCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeExtendedCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeExtendedCategory</returns>
        public async System.Threading.Tasks.Task<KnowledgeExtendedCategory> GetKnowledgeKnowledgebaseLanguageCategoryAsync (string categoryId, string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeExtendedCategory> localVarResponse = await GetKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo(categoryId, knowledgeBaseId, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeExtendedCategory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeExtendedCategory>> GetKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategory");
            
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategory");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageCategory");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeExtendedCategory>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeExtendedCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeExtendedCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeDocument</returns>
        public KnowledgeDocument GetKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeDocument> localVarResponse = GetKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo(documentId, knowledgeBaseId, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeDocument</returns>
        public ApiResponse< KnowledgeDocument > GetKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocument");
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocument");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocument");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (documentId != null) localVarPathParams.Add("documentId", this.Configuration.ApiClient.ParameterToString(documentId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeDocument>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeDocument</returns>
        public async System.Threading.Tasks.Task<KnowledgeDocument> GetKnowledgeKnowledgebaseLanguageDocumentAsync (string documentId, string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeDocument> localVarResponse = await GetKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo(documentId, knowledgeBaseId, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeDocument>> GetKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocument");
            
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocument");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocument");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (documentId != null) localVarPathParams.Add("documentId", this.Configuration.ApiClient.ParameterToString(documentId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeDocument>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get documents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="categories">Filter by categories ids, comma separated values expected. (optional)</param>
        /// <param name="title">Filter by document title. (optional)</param>
        /// <returns>DocumentListing</returns>
        public DocumentListing GetKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null)
        {
             ApiResponse<DocumentListing> localVarResponse = GetKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo(knowledgeBaseId, languageCode, before, after, limit, pageSize, categories, title);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get documents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="categories">Filter by categories ids, comma separated values expected. (optional)</param>
        /// <param name="title">Filter by document title. (optional)</param>
        /// <returns>ApiResponse of DocumentListing</returns>
        public ApiResponse< DocumentListing > GetKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocuments");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocuments");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (categories != null) localVarQueryParams.Add(new Tuple<string, string>("categories", this.Configuration.ApiClient.ParameterToString(categories)));
            if (title != null) localVarQueryParams.Add(new Tuple<string, string>("title", this.Configuration.ApiClient.ParameterToString(title)));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentListing>(localVarStatusCode,
                localVarHeaders,
                (DocumentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get documents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="categories">Filter by categories ids, comma separated values expected. (optional)</param>
        /// <param name="title">Filter by document title. (optional)</param>
        /// <returns>Task of DocumentListing</returns>
        public async System.Threading.Tasks.Task<DocumentListing> GetKnowledgeKnowledgebaseLanguageDocumentsAsync (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null)
        {
             ApiResponse<DocumentListing> localVarResponse = await GetKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo(knowledgeBaseId, languageCode, before, after, limit, pageSize, categories, title);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get documents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="categories">Filter by categories ids, comma separated values expected. (optional)</param>
        /// <param name="title">Filter by document title. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentListing>> GetKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocuments");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageDocuments");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (categories != null) localVarQueryParams.Add(new Tuple<string, string>("categories", this.Configuration.ApiClient.ParameterToString(categories)));
            if (title != null) localVarQueryParams.Add(new Tuple<string, string>("title", this.Configuration.ApiClient.ParameterToString(title)));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentListing>(localVarStatusCode,
                localVarHeaders,
                (DocumentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get training detail 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>KnowledgeTraining</returns>
        public KnowledgeTraining GetKnowledgeKnowledgebaseLanguageTraining (string knowledgeBaseId, string languageCode, string trainingId)
        {
             ApiResponse<KnowledgeTraining> localVarResponse = GetKnowledgeKnowledgebaseLanguageTrainingWithHttpInfo(knowledgeBaseId, languageCode, trainingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get training detail 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>ApiResponse of KnowledgeTraining</returns>
        public ApiResponse< KnowledgeTraining > GetKnowledgeKnowledgebaseLanguageTrainingWithHttpInfo (string knowledgeBaseId, string languageCode, string trainingId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTraining");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTraining");
            // verify the required parameter 'trainingId' is set
            if (trainingId == null)
                throw new ApiException(400, "Missing required parameter 'trainingId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTraining");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));
            if (trainingId != null) localVarPathParams.Add("trainingId", this.Configuration.ApiClient.ParameterToString(trainingId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageTraining: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageTraining: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeTraining>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeTraining) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeTraining)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get training detail 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>Task of KnowledgeTraining</returns>
        public async System.Threading.Tasks.Task<KnowledgeTraining> GetKnowledgeKnowledgebaseLanguageTrainingAsync (string knowledgeBaseId, string languageCode, string trainingId)
        {
             ApiResponse<KnowledgeTraining> localVarResponse = await GetKnowledgeKnowledgebaseLanguageTrainingAsyncWithHttpInfo(knowledgeBaseId, languageCode, trainingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get training detail 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>Task of ApiResponse (KnowledgeTraining)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeTraining>> GetKnowledgeKnowledgebaseLanguageTrainingAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string trainingId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTraining");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTraining");
            
            // verify the required parameter 'trainingId' is set
            if (trainingId == null)
                throw new ApiException(400, "Missing required parameter 'trainingId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTraining");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));
            if (trainingId != null) localVarPathParams.Add("trainingId", this.Configuration.ApiClient.ParameterToString(trainingId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageTraining: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageTraining: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeTraining>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeTraining) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeTraining)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get all trainings information for a knowledgebase 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="knowledgeDocumentsState">Return the training with the specified state of the trained documents. (optional)</param>
        /// <returns>TrainingListing</returns>
        public TrainingListing GetKnowledgeKnowledgebaseLanguageTrainings (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null)
        {
             ApiResponse<TrainingListing> localVarResponse = GetKnowledgeKnowledgebaseLanguageTrainingsWithHttpInfo(knowledgeBaseId, languageCode, before, after, limit, pageSize, knowledgeDocumentsState);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all trainings information for a knowledgebase 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="knowledgeDocumentsState">Return the training with the specified state of the trained documents. (optional)</param>
        /// <returns>ApiResponse of TrainingListing</returns>
        public ApiResponse< TrainingListing > GetKnowledgeKnowledgebaseLanguageTrainingsWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTrainings");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTrainings");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (knowledgeDocumentsState != null) localVarQueryParams.Add(new Tuple<string, string>("knowledgeDocumentsState", this.Configuration.ApiClient.ParameterToString(knowledgeDocumentsState)));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageTrainings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageTrainings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrainingListing>(localVarStatusCode,
                localVarHeaders,
                (TrainingListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrainingListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get all trainings information for a knowledgebase 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="knowledgeDocumentsState">Return the training with the specified state of the trained documents. (optional)</param>
        /// <returns>Task of TrainingListing</returns>
        public async System.Threading.Tasks.Task<TrainingListing> GetKnowledgeKnowledgebaseLanguageTrainingsAsync (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null)
        {
             ApiResponse<TrainingListing> localVarResponse = await GetKnowledgeKnowledgebaseLanguageTrainingsAsyncWithHttpInfo(knowledgeBaseId, languageCode, before, after, limit, pageSize, knowledgeDocumentsState);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all trainings information for a knowledgebase 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="knowledgeDocumentsState">Return the training with the specified state of the trained documents. (optional)</param>
        /// <returns>Task of ApiResponse (TrainingListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrainingListing>> GetKnowledgeKnowledgebaseLanguageTrainingsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTrainings");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->GetKnowledgeKnowledgebaseLanguageTrainings");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (knowledgeDocumentsState != null) localVarQueryParams.Add(new Tuple<string, string>("knowledgeDocumentsState", this.Configuration.ApiClient.ParameterToString(knowledgeDocumentsState)));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageTrainings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseLanguageTrainings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrainingListing>(localVarStatusCode,
                localVarHeaders,
                (TrainingListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrainingListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get knowledge bases 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Name of the KnowledgeBase to filter. (optional)</param>
        /// <returns>KnowledgeBaseListing</returns>
        public KnowledgeBaseListing GetKnowledgeKnowledgebases (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        {
             ApiResponse<KnowledgeBaseListing> localVarResponse = GetKnowledgeKnowledgebasesWithHttpInfo(before, after, limit, pageSize, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get knowledge bases 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Name of the KnowledgeBase to filter. (optional)</param>
        /// <returns>ApiResponse of KnowledgeBaseListing</returns>
        public ApiResponse< KnowledgeBaseListing > GetKnowledgeKnowledgebasesWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        { 

            var localVarPath = "/api/v2/knowledge/knowledgebases";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBaseListing>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBaseListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBaseListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get knowledge bases 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Name of the KnowledgeBase to filter. (optional)</param>
        /// <returns>Task of KnowledgeBaseListing</returns>
        public async System.Threading.Tasks.Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        {
             ApiResponse<KnowledgeBaseListing> localVarResponse = await GetKnowledgeKnowledgebasesAsyncWithHttpInfo(before, after, limit, pageSize, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get knowledge bases 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Name of the KnowledgeBase to filter. (optional)</param>
        /// <returns>Task of ApiResponse (KnowledgeBaseListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeBaseListing>> GetKnowledgeKnowledgebasesAsyncWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        { 

            var localVarPath = "/api/v2/knowledge/knowledgebases";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBaseListing>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBaseListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBaseListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeBase</returns>
        public KnowledgeBase PatchKnowledgeKnowledgebase (string knowledgeBaseId, KnowledgeBase body)
        {
             ApiResponse<KnowledgeBase> localVarResponse = PatchKnowledgeKnowledgebaseWithHttpInfo(knowledgeBaseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeBase</returns>
        public ApiResponse< KnowledgeBase > PatchKnowledgeKnowledgebaseWithHttpInfo (string knowledgeBaseId, KnowledgeBase body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PatchKnowledgeKnowledgebase");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PatchKnowledgeKnowledgebase");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBase>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeBase</returns>
        public async System.Threading.Tasks.Task<KnowledgeBase> PatchKnowledgeKnowledgebaseAsync (string knowledgeBaseId, KnowledgeBase body)
        {
             ApiResponse<KnowledgeBase> localVarResponse = await PatchKnowledgeKnowledgebaseAsyncWithHttpInfo(knowledgeBaseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeBase>> PatchKnowledgeKnowledgebaseAsyncWithHttpInfo (string knowledgeBaseId, KnowledgeBase body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PatchKnowledgeKnowledgebase");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PatchKnowledgeKnowledgebase");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBase>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeExtendedCategory</returns>
        public KnowledgeExtendedCategory PatchKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)
        {
             ApiResponse<KnowledgeExtendedCategory> localVarResponse = PatchKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo(categoryId, knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeExtendedCategory</returns>
        public ApiResponse< KnowledgeExtendedCategory > PatchKnowledgeKnowledgebaseLanguageCategoryWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageCategory");
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageCategory");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageCategory");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageCategory");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeExtendedCategory>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeExtendedCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeExtendedCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeExtendedCategory</returns>
        public async System.Threading.Tasks.Task<KnowledgeExtendedCategory> PatchKnowledgeKnowledgebaseLanguageCategoryAsync (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)
        {
             ApiResponse<KnowledgeExtendedCategory> localVarResponse = await PatchKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo(categoryId, knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeExtendedCategory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeExtendedCategory>> PatchKnowledgeKnowledgebaseLanguageCategoryAsyncWithHttpInfo (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageCategory");
            
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageCategory");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageCategory");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageCategory");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeExtendedCategory>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeExtendedCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeExtendedCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeDocument</returns>
        public KnowledgeDocument PatchKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)
        {
             ApiResponse<KnowledgeDocument> localVarResponse = PatchKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo(documentId, knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeDocument</returns>
        public ApiResponse< KnowledgeDocument > PatchKnowledgeKnowledgebaseLanguageDocumentWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)
        { 
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocument");
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocument");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocument");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocument");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (documentId != null) localVarPathParams.Add("documentId", this.Configuration.ApiClient.ParameterToString(documentId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeDocument>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeDocument</returns>
        public async System.Threading.Tasks.Task<KnowledgeDocument> PatchKnowledgeKnowledgebaseLanguageDocumentAsync (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)
        {
             ApiResponse<KnowledgeDocument> localVarResponse = await PatchKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo(documentId, knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeDocument>> PatchKnowledgeKnowledgebaseLanguageDocumentAsyncWithHttpInfo (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)
        { 
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocument");
            
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocument");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocument");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocument");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (documentId != null) localVarPathParams.Add("documentId", this.Configuration.ApiClient.ParameterToString(documentId));
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeDocument>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update documents collection 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>DocumentListing</returns>
        public DocumentListing PatchKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body)
        {
             ApiResponse<DocumentListing> localVarResponse = PatchKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo(knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update documents collection 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DocumentListing</returns>
        public ApiResponse< DocumentListing > PatchKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocuments");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocuments");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocuments");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentListing>(localVarStatusCode,
                localVarHeaders,
                (DocumentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update documents collection 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of DocumentListing</returns>
        public async System.Threading.Tasks.Task<DocumentListing> PatchKnowledgeKnowledgebaseLanguageDocumentsAsync (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body)
        {
             ApiResponse<DocumentListing> localVarResponse = await PatchKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo(knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update documents collection 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DocumentListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentListing>> PatchKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocuments");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocuments");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PatchKnowledgeKnowledgebaseLanguageDocuments");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentListing>(localVarStatusCode,
                localVarHeaders,
                (DocumentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create new category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeExtendedCategory</returns>
        public KnowledgeExtendedCategory PostKnowledgeKnowledgebaseLanguageCategories (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)
        {
             ApiResponse<KnowledgeExtendedCategory> localVarResponse = PostKnowledgeKnowledgebaseLanguageCategoriesWithHttpInfo(knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeExtendedCategory</returns>
        public ApiResponse< KnowledgeExtendedCategory > PostKnowledgeKnowledgebaseLanguageCategoriesWithHttpInfo (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageCategories");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageCategories");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageCategories");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeExtendedCategory>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeExtendedCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeExtendedCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create new category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeExtendedCategory</returns>
        public async System.Threading.Tasks.Task<KnowledgeExtendedCategory> PostKnowledgeKnowledgebaseLanguageCategoriesAsync (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)
        {
             ApiResponse<KnowledgeExtendedCategory> localVarResponse = await PostKnowledgeKnowledgebaseLanguageCategoriesAsyncWithHttpInfo(knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new category 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeExtendedCategory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeExtendedCategory>> PostKnowledgeKnowledgebaseLanguageCategoriesAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageCategories");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageCategories");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageCategories");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeExtendedCategory>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeExtendedCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeExtendedCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>KnowledgeDocument</returns>
        public KnowledgeDocument PostKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)
        {
             ApiResponse<KnowledgeDocument> localVarResponse = PostKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo(knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeDocument</returns>
        public ApiResponse< KnowledgeDocument > PostKnowledgeKnowledgebaseLanguageDocumentsWithHttpInfo (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageDocuments");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageDocuments");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageDocuments");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeDocument>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeDocument</returns>
        public async System.Threading.Tasks.Task<KnowledgeDocument> PostKnowledgeKnowledgebaseLanguageDocumentsAsync (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)
        {
             ApiResponse<KnowledgeDocument> localVarResponse = await PostKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo(knowledgeBaseId, languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create document 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeDocument>> PostKnowledgeKnowledgebaseLanguageDocumentsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageDocuments");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageDocuments");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageDocuments");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeDocument>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Promote trained documents from draft state to active. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>KnowledgeTraining</returns>
        public KnowledgeTraining PostKnowledgeKnowledgebaseLanguageTrainingPromote (string knowledgeBaseId, string languageCode, string trainingId)
        {
             ApiResponse<KnowledgeTraining> localVarResponse = PostKnowledgeKnowledgebaseLanguageTrainingPromoteWithHttpInfo(knowledgeBaseId, languageCode, trainingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Promote trained documents from draft state to active. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>ApiResponse of KnowledgeTraining</returns>
        public ApiResponse< KnowledgeTraining > PostKnowledgeKnowledgebaseLanguageTrainingPromoteWithHttpInfo (string knowledgeBaseId, string languageCode, string trainingId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainingPromote");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainingPromote");
            // verify the required parameter 'trainingId' is set
            if (trainingId == null)
                throw new ApiException(400, "Missing required parameter 'trainingId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainingPromote");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId}/promote";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));
            if (trainingId != null) localVarPathParams.Add("trainingId", this.Configuration.ApiClient.ParameterToString(trainingId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageTrainingPromote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageTrainingPromote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeTraining>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeTraining) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeTraining)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Promote trained documents from draft state to active. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>Task of KnowledgeTraining</returns>
        public async System.Threading.Tasks.Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsync (string knowledgeBaseId, string languageCode, string trainingId)
        {
             ApiResponse<KnowledgeTraining> localVarResponse = await PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsyncWithHttpInfo(knowledgeBaseId, languageCode, trainingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Promote trained documents from draft state to active. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <param name="trainingId">Training ID</param>
        /// <returns>Task of ApiResponse (KnowledgeTraining)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeTraining>> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsyncWithHttpInfo (string knowledgeBaseId, string languageCode, string trainingId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainingPromote");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainingPromote");
            
            // verify the required parameter 'trainingId' is set
            if (trainingId == null)
                throw new ApiException(400, "Missing required parameter 'trainingId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainingPromote");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId}/promote";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));
            if (trainingId != null) localVarPathParams.Add("trainingId", this.Configuration.ApiClient.ParameterToString(trainingId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageTrainingPromote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageTrainingPromote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeTraining>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeTraining) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeTraining)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Trigger training 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>KnowledgeTraining</returns>
        public KnowledgeTraining PostKnowledgeKnowledgebaseLanguageTrainings (string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeTraining> localVarResponse = PostKnowledgeKnowledgebaseLanguageTrainingsWithHttpInfo(knowledgeBaseId, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Trigger training 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>ApiResponse of KnowledgeTraining</returns>
        public ApiResponse< KnowledgeTraining > PostKnowledgeKnowledgebaseLanguageTrainingsWithHttpInfo (string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainings");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainings");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageTrainings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageTrainings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeTraining>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeTraining) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeTraining)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Trigger training 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of KnowledgeTraining</returns>
        public async System.Threading.Tasks.Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingsAsync (string knowledgeBaseId, string languageCode)
        {
             ApiResponse<KnowledgeTraining> localVarResponse = await PostKnowledgeKnowledgebaseLanguageTrainingsAsyncWithHttpInfo(knowledgeBaseId, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Trigger training 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="languageCode">Language code, format: iso2-LOCALE</param>
        /// <returns>Task of ApiResponse (KnowledgeTraining)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeTraining>> PostKnowledgeKnowledgebaseLanguageTrainingsAsyncWithHttpInfo (string knowledgeBaseId, string languageCode)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainings");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling KnowledgeApi->PostKnowledgeKnowledgebaseLanguageTrainings");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageTrainings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseLanguageTrainings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeTraining>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeTraining) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeTraining)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Search Documents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>KnowledgeSearchResponse</returns>
        public KnowledgeSearchResponse PostKnowledgeKnowledgebaseSearch (string knowledgeBaseId, KnowledgeSearchRequest body = null)
        {
             ApiResponse<KnowledgeSearchResponse> localVarResponse = PostKnowledgeKnowledgebaseSearchWithHttpInfo(knowledgeBaseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Documents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of KnowledgeSearchResponse</returns>
        public ApiResponse< KnowledgeSearchResponse > PostKnowledgeKnowledgebaseSearchWithHttpInfo (string knowledgeBaseId, KnowledgeSearchRequest body = null)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseSearch");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeSearchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Search Documents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of KnowledgeSearchResponse</returns>
        public async System.Threading.Tasks.Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync (string knowledgeBaseId, KnowledgeSearchRequest body = null)
        {
             ApiResponse<KnowledgeSearchResponse> localVarResponse = await PostKnowledgeKnowledgebaseSearchAsyncWithHttpInfo(knowledgeBaseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Documents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (KnowledgeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeSearchResponse>> PostKnowledgeKnowledgebaseSearchAsyncWithHttpInfo (string knowledgeBaseId, KnowledgeSearchRequest body = null)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling KnowledgeApi->PostKnowledgeKnowledgebaseSearch");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeSearchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create new knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>KnowledgeBase</returns>
        public KnowledgeBase PostKnowledgeKnowledgebases (KnowledgeBase body)
        {
             ApiResponse<KnowledgeBase> localVarResponse = PostKnowledgeKnowledgebasesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of KnowledgeBase</returns>
        public ApiResponse< KnowledgeBase > PostKnowledgeKnowledgebasesWithHttpInfo (KnowledgeBase body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PostKnowledgeKnowledgebases");

            var localVarPath = "/api/v2/knowledge/knowledgebases";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBase>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create new knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of KnowledgeBase</returns>
        public async System.Threading.Tasks.Task<KnowledgeBase> PostKnowledgeKnowledgebasesAsync (KnowledgeBase body)
        {
             ApiResponse<KnowledgeBase> localVarResponse = await PostKnowledgeKnowledgebasesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new knowledge base 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (KnowledgeBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KnowledgeBase>> PostKnowledgeKnowledgebasesAsyncWithHttpInfo (KnowledgeBase body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KnowledgeApi->PostKnowledgeKnowledgebases");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
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

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KnowledgeBase>(localVarStatusCode,
                localVarHeaders,
                (KnowledgeBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KnowledgeBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
