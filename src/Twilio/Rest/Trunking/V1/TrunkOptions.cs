/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Trunking.V1 
{

    /// <summary>
    /// FetchTrunkOptions
    /// </summary>
    public class FetchTrunkOptions : IOptions<TrunkResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchTrunkOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public FetchTrunkOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// DeleteTrunkOptions
    /// </summary>
    public class DeleteTrunkOptions : IOptions<TrunkResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteTrunkOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public DeleteTrunkOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateTrunkOptions
    /// </summary>
    public class CreateTrunkOptions : IOptions<TrunkResource> 
    {
        /// <summary>
        /// A human-readable name for the Trunk.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The unique address you reserve on Twilio to which you route your SIP traffic.
        /// </summary>
        public string DomainName { get; set; }
        /// <summary>
        /// The HTTP URL that Twilio will request if an error occurs while sending SIP traffic towards your configured Origination URL.
        /// </summary>
        public Uri DisasterRecoveryUrl { get; set; }
        /// <summary>
        /// The HTTP method Twilio will use when requesting the DisasterRecoveryUrl.
        /// </summary>
        public Twilio.Http.HttpMethod DisasterRecoveryMethod { get; set; }
        /// <summary>
        /// The recording settings for this trunk.
        /// </summary>
        public TrunkResource.RecordingSettingEnum Recording { get; set; }
        /// <summary>
        /// The Secure Trunking  settings for this trunk.
        /// </summary>
        public bool? Secure { get; set; }
        /// <summary>
        /// The cnam_lookup_enabled
        /// </summary>
        public bool? CnamLookupEnabled { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }

            if (DisasterRecoveryUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("DisasterRecoveryUrl", Serializers.Url(DisasterRecoveryUrl)));
            }

            if (DisasterRecoveryMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("DisasterRecoveryMethod", DisasterRecoveryMethod.ToString()));
            }

            if (Recording != null)
            {
                p.Add(new KeyValuePair<string, string>("Recording", Recording.ToString()));
            }

            if (Secure != null)
            {
                p.Add(new KeyValuePair<string, string>("Secure", Secure.Value.ToString().ToLower()));
            }

            if (CnamLookupEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("CnamLookupEnabled", CnamLookupEnabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadTrunkOptions
    /// </summary>
    public class ReadTrunkOptions : ReadOptions<TrunkResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateTrunkOptions
    /// </summary>
    public class UpdateTrunkOptions : IOptions<TrunkResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human-readable name for the Trunk.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The unique address you reserve on Twilio to which you route your SIP traffic.
        /// </summary>
        public string DomainName { get; set; }
        /// <summary>
        /// The HTTP URL that Twilio will request if an error occurs while sending SIP traffic towards your configured Origination URL.
        /// </summary>
        public Uri DisasterRecoveryUrl { get; set; }
        /// <summary>
        /// The HTTP method Twilio will use when requesting the DisasterRecoveryUrl.
        /// </summary>
        public Twilio.Http.HttpMethod DisasterRecoveryMethod { get; set; }
        /// <summary>
        /// The recording settings for this trunk.
        /// </summary>
        public TrunkResource.RecordingSettingEnum Recording { get; set; }
        /// <summary>
        /// The Secure Trunking  settings for this trunk.
        /// </summary>
        public bool? Secure { get; set; }
        /// <summary>
        /// The cnam_lookup_enabled
        /// </summary>
        public bool? CnamLookupEnabled { get; set; }

        /// <summary>
        /// Construct a new UpdateTrunkOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public UpdateTrunkOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }

            if (DisasterRecoveryUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("DisasterRecoveryUrl", Serializers.Url(DisasterRecoveryUrl)));
            }

            if (DisasterRecoveryMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("DisasterRecoveryMethod", DisasterRecoveryMethod.ToString()));
            }

            if (Recording != null)
            {
                p.Add(new KeyValuePair<string, string>("Recording", Recording.ToString()));
            }

            if (Secure != null)
            {
                p.Add(new KeyValuePair<string, string>("Secure", Secure.Value.ToString().ToLower()));
            }

            if (CnamLookupEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("CnamLookupEnabled", CnamLookupEnabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}