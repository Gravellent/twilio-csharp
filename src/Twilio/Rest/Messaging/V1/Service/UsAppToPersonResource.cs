/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// UsAppToPersonResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Messaging.V1.Service
{

    public class UsAppToPersonResource : Resource
    {
        private static Request BuildCreateRequest(CreateUsAppToPersonOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathMessagingServiceSid + "/Compliance/Usa2p",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create UsAppToPerson parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPerson </returns>
        public static UsAppToPersonResource Create(CreateUsAppToPersonOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create UsAppToPerson parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPerson </returns>
        public static async System.Threading.Tasks.Task<UsAppToPersonResource> CreateAsync(CreateUsAppToPersonOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to create the resource from </param>
        /// <param name="brandRegistrationSid"> A2P Brand Registration SID </param>
        /// <param name="description"> A short description of what this SMS campaign does </param>
        /// <param name="messageSamples"> Message samples </param>
        /// <param name="usAppToPersonUsecase"> A2P Campaign Use Case. </param>
        /// <param name="hasEmbeddedLinks"> Indicates that this SMS campaign will send messages that contain links </param>
        /// <param name="hasEmbeddedPhone"> Indicates that this SMS campaign will send messages that contain phone numbers
        ///                        </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPerson </returns>
        public static UsAppToPersonResource Create(string pathMessagingServiceSid,
                                                   string brandRegistrationSid,
                                                   string description,
                                                   List<string> messageSamples,
                                                   string usAppToPersonUsecase,
                                                   bool? hasEmbeddedLinks,
                                                   bool? hasEmbeddedPhone,
                                                   ITwilioRestClient client = null)
        {
            var options = new CreateUsAppToPersonOptions(pathMessagingServiceSid, brandRegistrationSid, description, messageSamples, usAppToPersonUsecase, hasEmbeddedLinks, hasEmbeddedPhone);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to create the resource from </param>
        /// <param name="brandRegistrationSid"> A2P Brand Registration SID </param>
        /// <param name="description"> A short description of what this SMS campaign does </param>
        /// <param name="messageSamples"> Message samples </param>
        /// <param name="usAppToPersonUsecase"> A2P Campaign Use Case. </param>
        /// <param name="hasEmbeddedLinks"> Indicates that this SMS campaign will send messages that contain links </param>
        /// <param name="hasEmbeddedPhone"> Indicates that this SMS campaign will send messages that contain phone numbers
        ///                        </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPerson </returns>
        public static async System.Threading.Tasks.Task<UsAppToPersonResource> CreateAsync(string pathMessagingServiceSid,
                                                                                           string brandRegistrationSid,
                                                                                           string description,
                                                                                           List<string> messageSamples,
                                                                                           string usAppToPersonUsecase,
                                                                                           bool? hasEmbeddedLinks,
                                                                                           bool? hasEmbeddedPhone,
                                                                                           ITwilioRestClient client = null)
        {
            var options = new CreateUsAppToPersonOptions(pathMessagingServiceSid, brandRegistrationSid, description, messageSamples, usAppToPersonUsecase, hasEmbeddedLinks, hasEmbeddedPhone);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteUsAppToPersonOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathMessagingServiceSid + "/Compliance/Usa2p/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete UsAppToPerson parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPerson </returns>
        public static bool Delete(DeleteUsAppToPersonOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete UsAppToPerson parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPerson </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteUsAppToPersonOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to delete the resource from </param>
        /// <param name="pathSid"> The SID that identifies the US A2P Compliance resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPerson </returns>
        public static bool Delete(string pathMessagingServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteUsAppToPersonOptions(pathMessagingServiceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to delete the resource from </param>
        /// <param name="pathSid"> The SID that identifies the US A2P Compliance resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPerson </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathMessagingServiceSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteUsAppToPersonOptions(pathMessagingServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadUsAppToPersonOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathMessagingServiceSid + "/Compliance/Usa2p",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read UsAppToPerson parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPerson </returns>
        public static ResourceSet<UsAppToPersonResource> Read(ReadUsAppToPersonOptions options,
                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<UsAppToPersonResource>.FromJson("compliance", response.Content);
            return new ResourceSet<UsAppToPersonResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read UsAppToPerson parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPerson </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UsAppToPersonResource>> ReadAsync(ReadUsAppToPersonOptions options,
                                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<UsAppToPersonResource>.FromJson("compliance", response.Content);
            return new ResourceSet<UsAppToPersonResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to fetch the resource from </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPerson </returns>
        public static ResourceSet<UsAppToPersonResource> Read(string pathMessagingServiceSid,
                                                              int? pageSize = null,
                                                              long? limit = null,
                                                              ITwilioRestClient client = null)
        {
            var options = new ReadUsAppToPersonOptions(pathMessagingServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to fetch the resource from </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPerson </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UsAppToPersonResource>> ReadAsync(string pathMessagingServiceSid,
                                                                                                      int? pageSize = null,
                                                                                                      long? limit = null,
                                                                                                      ITwilioRestClient client = null)
        {
            var options = new ReadUsAppToPersonOptions(pathMessagingServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<UsAppToPersonResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UsAppToPersonResource>.FromJson("compliance", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<UsAppToPersonResource> NextPage(Page<UsAppToPersonResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Messaging)
            );

            var response = client.Request(request);
            return Page<UsAppToPersonResource>.FromJson("compliance", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<UsAppToPersonResource> PreviousPage(Page<UsAppToPersonResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Messaging)
            );

            var response = client.Request(request);
            return Page<UsAppToPersonResource>.FromJson("compliance", response.Content);
        }

        private static Request BuildFetchRequest(FetchUsAppToPersonOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathMessagingServiceSid + "/Compliance/Usa2p/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch UsAppToPerson parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPerson </returns>
        public static UsAppToPersonResource Fetch(FetchUsAppToPersonOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch UsAppToPerson parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPerson </returns>
        public static async System.Threading.Tasks.Task<UsAppToPersonResource> FetchAsync(FetchUsAppToPersonOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to fetch the resource from </param>
        /// <param name="pathSid"> The SID that identifies the US A2P Compliance resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPerson </returns>
        public static UsAppToPersonResource Fetch(string pathMessagingServiceSid,
                                                  string pathSid,
                                                  ITwilioRestClient client = null)
        {
            var options = new FetchUsAppToPersonOptions(pathMessagingServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to fetch the resource from </param>
        /// <param name="pathSid"> The SID that identifies the US A2P Compliance resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPerson </returns>
        public static async System.Threading.Tasks.Task<UsAppToPersonResource> FetchAsync(string pathMessagingServiceSid,
                                                                                          string pathSid,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new FetchUsAppToPersonOptions(pathMessagingServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a UsAppToPersonResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UsAppToPersonResource object represented by the provided JSON </returns>
        public static UsAppToPersonResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<UsAppToPersonResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies a US A2P Compliance resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A2P Brand Registration SID
        /// </summary>
        [JsonProperty("brand_registration_sid")]
        public string BrandRegistrationSid { get; private set; }
        /// <summary>
        /// The SID of the Messaging Service the resource is associated with
        /// </summary>
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }
        /// <summary>
        /// A short description of what this SMS campaign does
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// Message samples
        /// </summary>
        [JsonProperty("message_samples")]
        public List<string> MessageSamples { get; private set; }
        /// <summary>
        /// A2P Campaign Use Case.
        /// </summary>
        [JsonProperty("us_app_to_person_usecase")]
        public string UsAppToPersonUsecase { get; private set; }
        /// <summary>
        /// Indicate that this SMS campaign will send messages that contain links
        /// </summary>
        [JsonProperty("has_embedded_links")]
        public bool? HasEmbeddedLinks { get; private set; }
        /// <summary>
        /// Indicates that this SMS campaign will send messages that contain phone numbers
        /// </summary>
        [JsonProperty("has_embedded_phone")]
        public bool? HasEmbeddedPhone { get; private set; }
        /// <summary>
        /// Campaign status
        /// </summary>
        [JsonProperty("campaign_status")]
        public string CampaignStatus { get; private set; }
        /// <summary>
        /// The Campaign Registry (TCR) Campaign ID.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; private set; }
        /// <summary>
        /// Indicates whether the campaign was registered externally or not
        /// </summary>
        [JsonProperty("is_externally_registered")]
        public bool? IsExternallyRegistered { get; private set; }
        /// <summary>
        /// Rate limit and/or classification set by each carrier
        /// </summary>
        [JsonProperty("rate_limits")]
        public object RateLimits { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The absolute URL of the US App to Person resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// A boolean that specifies whether campaign is a mock or not.
        /// </summary>
        [JsonProperty("mock")]
        public bool? Mock { get; private set; }

        private UsAppToPersonResource()
        {

        }
    }

}