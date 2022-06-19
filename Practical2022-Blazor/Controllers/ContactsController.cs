using Practical2022_Blazor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practical2022_Blazor.Api
{
    public class ContactsController : ControllerBase
    {

        /// <summary>
        /// Api url.
        /// </summary>
        private string baseUrl = "https://localhost:5001";

        /// <summary>
        /// Fetches contacts from Api.
        /// </summary>
        /// <returns>Task containing List of Contacts.</returns>
        public async Task<List<ContactModel>> GetAllContacts()
        {
            List<ContactModel> contacts = new List<ContactModel>();
            var uri = "api/Contacts";
            
            using (var httpclient = new HttpClient())
            {
                httpclient.BaseAddress = new Uri(baseUrl);
                httpclient.DefaultRequestHeaders.Clear();

                HttpResponseMessage Res = await httpclient.GetAsync(uri);

                if (Res.IsSuccessStatusCode)
                {
                    var record = Res.Content.ReadAsStringAsync().Result;
                    contacts = JsonSerializer.Deserialize<List<ContactModel>>(record);
                }
            };

            return contacts;
        }

    }
}