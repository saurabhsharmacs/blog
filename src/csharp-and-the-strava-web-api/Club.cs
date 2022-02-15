using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_and_the_strava_web_api
{
    public class Club
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("resource_state")]
        public int? ResourceState { get; set; }

        [JsonProperty("name")]
        public int? Name { get; set; }


        [JsonProperty("profile_medium")]
        public int? ProfileMedium { get; set; }


        [JsonProperty("profile")]
        public int? Profile { get; set; }

        [JsonProperty("cover_photo")]
        public int? CoverPhoto { get; set; }

        [JsonProperty("cover_photo_small")]
        public int? CoverPhotoSmall { get; set; }

        [JsonProperty("sport_type")]
        public int? SportsType { get; set; }

        [JsonProperty("city")]
        public int? City { get; set; }

        [JsonProperty("state")]
        public int? State { get; set; }

        [JsonProperty("country")]
        public int? Country { get; set; }

        [JsonProperty("private")]
        public int? Private { get; set; }

        [JsonProperty("member_count")]
        public int? MemberCount { get; set; }

        [JsonProperty("featured")]
        public int? Featured { get; set; }

        [JsonProperty("verified")]
        public int? Verified { get; set; }

        [JsonProperty("url")]
        public int? Url { get; set; }

    }
}
