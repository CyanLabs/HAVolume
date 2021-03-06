﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace HA_Volume
{
    /// <summary>
    /// Helper class to simplify sending and retrieving of HA API RESTful functions
    /// </summary>
    public class HAAPI
    {
        /// <summary>
        /// Sends a HTTP POST request to send commands to the media_player.
        /// </summary>      
        /// <param name="servicename">HA service name e.g volume_up or toggle</param>
        /// <param name="json">Some services require additional json to action the service</param>
        public static void POST(string servicename, [Optional] string json)
        {
            try
            {
                if (String.IsNullOrEmpty(json)) json = new JavaScriptSerializer().Serialize(new { entity_id = Properties.Settings.Default.HAEntity });

                HttpClientHandler handler = new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                };

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Properties.Settings.Default.HAToken);
                    var response = httpClient.PostAsync(Properties.Settings.Default.HAURL + "/api/services/" + servicename, new StringContent(json, Encoding.UTF8, "application/json")).Result;
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    MessageBox.Show("Unable to communicate with Home Assistant correctly, please confirm Home Assistant is running and that your settings are correct and that the entity you have selected is showing in Home Assistant.", "HA Volume - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Sends a HTTP GET request to HA to retrieve attributes.
        /// </summary>      
        /// <param name="entity">Optional: filter it to a specific entity.</param>
        public static dynamic GET([Optional] string entity)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            try
            {
                HttpClientHandler handler = new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                };

                using (var httpClient = new HttpClient(handler))
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Properties.Settings.Default.HAToken);
                    if(String.IsNullOrEmpty(entity))
                    {
                        var response = httpClient.GetStringAsync(new Uri(Properties.Settings.Default.HAURL + "/api/states")).Result;
                        return jsonSerializer.Deserialize<dynamic>((response));
                    }
                    else
                    {
                        
                        var response = httpClient.GetStringAsync(new Uri(Properties.Settings.Default.HAURL + "/api/states/" + entity)).Result;
                        return jsonSerializer.Deserialize<dynamic>((response));
                    }
                }
            }
            catch (WebException)
            {
                return 99;
            }
            catch (HttpRequestException)
            {
                return 99;
            }
        }

        /// <summary>
        /// Toggles Power of the media_player.
        /// </summary>
        public static void Power() => POST("media_player/toggle");

        /// <summary>
        /// Increases volume of the media_player.
        /// </summary>
        public static void Volume_Up() => POST("media_player/volume_up");

        /// <summary>
        /// Decreases volume of the media_player.
        /// </summary>
        public static void Volume_Down() => POST("media_player/volume_down");

        /// <summary>
        /// Sets volume of the media_player.
        /// </summary>
        public static void Volume_Set(decimal volume)
        {
            string json = new JavaScriptSerializer().Serialize(new
            {

                entity_id = Properties.Settings.Default.HAEntity,
                volume_level = volume
            });
            POST("media_player/volume_set", json);
        }
        /// <summary>
        /// Detects mute state and toggles mute of the media_player.
        /// </summary>      
        /// <param name="state">Pass the variable which contains True/False of the media_player mute state</param>
        public static void Volume_Mute(bool state)
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                entity_id = Properties.Settings.Default.HAEntity,
                is_volume_muted = !state
            });
            POST("media_player/volume_mute", json);
        }

        /// <summary>
        /// Changes source of media_player, if no source set will use "OnInput"
        /// </summary>      
        /// <param name="state">Optional: string containing the source you want to switch to.</param>
        public static void Set_Input([Optional] string source)
        {
            string json;
            if (String.IsNullOrEmpty(source))
            {
                json = new JavaScriptSerializer().Serialize(new
                {
                    entity_id = Properties.Settings.Default.HAEntity,
                    source = Properties.Settings.Default.OnInput
                });
            }
            else
            {
                json = new JavaScriptSerializer().Serialize(new
                {
                    entity_id = Properties.Settings.Default.HAEntity,
                    source = source
                });
            }
            POST("media_player/select_source", json);
        }

        /// <summary>
        /// Validates HA URL to make sure its a valid URL.
        /// </summary>      
        /// <param name="url">text to validate as URL.</param>
        public static bool Validate_URL(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        /// <summary>
        /// Turns ON additional seitch
        /// </summary>
        public static void Toggle_Switch(string action, string additionalswitch)
        {
            string json = new JavaScriptSerializer().Serialize(new {entity_id = additionalswitch});
            POST("switch/" + action, json);
        }
    }
}