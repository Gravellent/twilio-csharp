using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Wireless.V1 
{

    /// <summary>
    /// FetchSimOptions
    /// </summary>
    public class FetchSimOptions : IOptions<SimResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSimOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchSimOptions(string pathSid)
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
    /// ReadSimOptions
    /// </summary>
    public class ReadSimOptions : ReadOptions<SimResource> 
    {
        /// <summary>
        /// The status
        /// </summary>
        public SimResource.StatusEnum Status { get; set; }
        /// <summary>
        /// The iccid
        /// </summary>
        public string Iccid { get; set; }
        /// <summary>
        /// The rate_plan
        /// </summary>
        public string RatePlan { get; set; }
        /// <summary>
        /// The e_id
        /// </summary>
        public string EId { get; set; }
        /// <summary>
        /// The sim_registration_code
        /// </summary>
        public string SimRegistrationCode { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (Iccid != null)
            {
                p.Add(new KeyValuePair<string, string>("Iccid", Iccid));
            }

            if (RatePlan != null)
            {
                p.Add(new KeyValuePair<string, string>("RatePlan", RatePlan));
            }

            if (EId != null)
            {
                p.Add(new KeyValuePair<string, string>("EId", EId));
            }

            if (SimRegistrationCode != null)
            {
                p.Add(new KeyValuePair<string, string>("SimRegistrationCode", SimRegistrationCode));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateSimOptions
    /// </summary>
    public class UpdateSimOptions : IOptions<SimResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The callback_method
        /// </summary>
        public Twilio.Http.HttpMethod CallbackMethod { get; set; }
        /// <summary>
        /// The callback_url
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The rate_plan
        /// </summary>
        public string RatePlan { get; set; }
        /// <summary>
        /// The status
        /// </summary>
        public SimResource.StatusEnum Status { get; set; }
        /// <summary>
        /// The commands_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod CommandsCallbackMethod { get; set; }
        /// <summary>
        /// The commands_callback_url
        /// </summary>
        public Uri CommandsCallbackUrl { get; set; }
        /// <summary>
        /// The sms_fallback_method
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
        /// <summary>
        /// The sms_fallback_url
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// The sms_method
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// The sms_url
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// The voice_fallback_method
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// The voice_fallback_url
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// The voice_method
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// The voice_url
        /// </summary>
        public Uri VoiceUrl { get; set; }

        /// <summary>
        /// Construct a new UpdateSimOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdateSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", CallbackUrl.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (RatePlan != null)
            {
                p.Add(new KeyValuePair<string, string>("RatePlan", RatePlan.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (CommandsCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsCallbackMethod", CommandsCallbackMethod.ToString()));
            }

            if (CommandsCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsCallbackUrl", CommandsCallbackUrl.ToString()));
            }

            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }

            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", SmsFallbackUrl.ToString()));
            }

            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }

            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", SmsUrl.ToString()));
            }

            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }

            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", VoiceFallbackUrl.ToString()));
            }

            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }

            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", VoiceUrl.ToString()));
            }

            return p;
        }
    }

}